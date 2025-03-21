using Photon.Pun;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Animator))]
public class PlayerMowement : MonoBehaviour
{
    [SerializeField] private float _runSpeed = 5f;
    [SerializeField] private float _walkSpeed = 2f;
    [SerializeField] private float _rotationSpeed = 6f;

    private float _speed;

    private CharacterController _characterController;

    private PhotonView _photonView;
    private PlayerInput _playerInput;
    private Animator _animator;
    private Vector2 _movementVector;
    private Vector3 _desiredVelosity;
    private Vector3 _velosity;
    private bool _isSprinting;


    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();

        _playerInput = new PlayerInput();

        _photonView = GetComponent<PhotonView>();
     
        _playerInput.PlayerKeebordInput.Movement.started += OnPlayerMowe;
        _playerInput.PlayerKeebordInput.Movement.canceled += OnPlayerMowe;
        _playerInput.PlayerKeebordInput.Movement.performed += OnPlayerMowe;

        _playerInput.PlayerKeebordInput.Sprint.started += OnPlayerSprint;
        _playerInput.PlayerKeebordInput.Sprint.canceled += OnPlayerSprint;
    }

    private void Start()
    {
        if(_photonView.IsMine)
        {
            CameraController.instance.SetTarget(transform);
        }
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void OnPlayerMowe(InputAction.CallbackContext context)
    {
        _movementVector = context.ReadValue<Vector2>();
    }

    private void OnPlayerSprint(InputAction.CallbackContext context)
    {
        _isSprinting = context.ReadValueAsButton();
    }

    private void Update()
    {
        if (_photonView.IsMine)
        {
            Move();
            Rotete();
        }
    }

    private void Move()
    {
        _speed = _isSprinting ? _walkSpeed : _runSpeed;

        _desiredVelosity = new Vector3(_speed * _movementVector.x, 0, _speed * _movementVector.y) * Time.deltaTime;
        _velosity = Vector3.Lerp(_velosity, _desiredVelosity, _speed * Time.deltaTime);
        _characterController.Move(_velosity);
        _animator.SetFloat("Speed", _movementVector.magnitude * _speed);
    }

    private void Rotete()
    {
        if (_movementVector.magnitude > 0)
        {
            Quaternion targetRotarion = Quaternion.LookRotation(_velosity, Vector3.up);
            Quaternion rotation = Quaternion.Lerp(transform.rotation, targetRotarion, _rotationSpeed * Time.deltaTime);
            transform.rotation = rotation;
        }
    }
}
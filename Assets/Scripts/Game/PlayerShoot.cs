using Photon.Pun;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject _trailRenderer;
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _bulletOrigin;

    private Camera _camera;

    private PhotonView _view;
    private PlayerInput _playerInput;

    private bool _isAiming;

    private void Start()
    {
        _camera = Camera.main;

        if (_view.IsMine)
        {
            _playerInput.PlayerKeebordInput.Aim.started += OnAimChanged;
            _playerInput.PlayerKeebordInput.Aim.canceled += OnAimChanged;

            _playerInput.PlayerKeebordInput.Fire.started += Shoot;
        }
    }

    private void Update()
    {
        Aim();
    }

    private void Awake()
    {
        _playerInput = new();
        _view = GetComponent<PhotonView>();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void OnAimChanged(InputAction.CallbackContext context)
    {
        _isAiming = context.ReadValueAsButton();
        _trailRenderer.SetActive(_isAiming);
    }

    private void Aim()
    {
        if (_isAiming)
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                Vector3 point = new(hitInfo.point.x, _trailRenderer.transform.position.y, hitInfo.point.z);
                Vector3 direction = point - transform.position;
                _trailRenderer.transform.forward = direction;
            }
        }
    }

    private void Shoot(InputAction.CallbackContext context)
    {
        if (_isAiming)
        {
            GameObject bullet = PhotonNetwork.Instantiate("Bullet", _bulletOrigin.position, _trailRenderer.transform.rotation);
            bullet.GetComponentInChildren<CapsuleCollider>().enabled = true;
        }
    }
}
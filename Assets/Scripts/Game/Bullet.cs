using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float _speed = 8f;
    private void Start()
    {
        Initialize();

    }

    private void Initialize()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.AddForce(transform.forward * _speed, ForceMode.Impulse);
        Destroy(gameObject, 8f / _speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out IDamageble damageble))
        {
            damageble.TakeDamage(1000000);
        }
    }
}
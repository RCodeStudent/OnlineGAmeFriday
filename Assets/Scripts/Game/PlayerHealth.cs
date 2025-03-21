using Photon.Pun;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageble
{
    [SerializeField] private int _maxHealth = 100;

    private int _health;
    private int Health { get { return _health; } set { if (_health != value) _health = value; _healthBar.SetValue(value); } }

    private UIHealthBar _healthBar;
    private PhotonView _view;

    public void TakeDamage(int damage)
    {
        _view.RPC("RemoteDamage", RpcTarget.All, damage);
    }

    [PunRPC]
    private void RemoteDamage(int damage)
    {
        Health -= damage;
    }

    private void Start()
    {
        _healthBar = GetComponentInChildren<UIHealthBar>();
        _healthBar.SetMax(_maxHealth);
        Health = _maxHealth;
        _view = GetComponent<PhotonView>();
    }
}
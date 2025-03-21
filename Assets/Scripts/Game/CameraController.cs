using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;

    [SerializeField] private float _smooth = 2.0f;
    [SerializeField] private Vector3 _offset = new(0, 5, -4);

    private Transform _target;
    private Vector3 _velosity;
    
    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        Work();
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }

    private void Work()
    {
        if (_target == null)
            return;

        Vector3 newPosition = Vector3.SmoothDamp(transform.position, _target.position + _offset, ref _velosity, Time.deltaTime);
        transform.position = newPosition;
    }
}
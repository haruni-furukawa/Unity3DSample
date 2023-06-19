using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _distance = 5.0f;
    [SerializeField] private float _zoomSpeed = 2.0f;
    [SerializeField] private float _minZoom = 1.0f;
    [SerializeField] private float _maxZoom = 15.0f;
    [SerializeField] private float _xSpeed = 120.0f;
    [SerializeField] private float _ySpeed = 120.0f;
    [SerializeField] private float _yMinLimit = -20f;
    [SerializeField] private float _yMaxLimit = 80f;

    private float _x = 0.0f;
    private float _y = 0.0f;

    // Use this for initialization
    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        _x = angles.y;
        _y = angles.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (_target)
        {
            _x += Input.GetAxis("Mouse X") * _xSpeed * 0.02f;
            _y -= Input.GetAxis("Mouse Y") * _ySpeed * 0.02f;

            _y = ClampAngle(_y, _yMinLimit, _yMaxLimit);

            _distance = Mathf.Clamp(_distance - Input.GetAxis("Mouse ScrollWheel") * _zoomSpeed, _minZoom, _maxZoom);

            Quaternion rotation = Quaternion.Euler(_y, _x, 0);
            Vector3 position = rotation * new Vector3(0.0f, 0.0f, -_distance) + _target.position;

            transform.rotation = rotation;
            transform.position = position;
        }
    }

    private float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360.0f)
            angle += 360.0f;
        if (angle > 360.0f)
            angle -= 360.0f;
        return Mathf.Clamp(angle, min, max);
    }
}
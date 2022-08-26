using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelRotator : MonoBehaviour
{
    [SerializeField] private Transform _model;
    [SerializeField] private float _rotationSpeed;
    private bool _rotateModel;

    private void Update()
    {
        if (_rotateModel)
        {
            Rotate();
        }
    }

    private void Rotate()
    {
        _model.RotateAround(_model.transform.position, Vector3.down, _rotationSpeed * Time.deltaTime);
    }

    public void StartRotation()
    {
        _rotateModel = true;
    }

    public void StopRotation()
    {
        _rotateModel = true;
    }

    public void ToggleRotation()
    {
        _rotateModel = !_rotateModel;
    }
}

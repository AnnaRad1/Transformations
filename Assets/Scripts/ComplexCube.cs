using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2 : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _movementSpeed;

    private void Update()
    {
        Rotate();
        ChangeScale();
        Move();
    }

    private void Rotate()
    {
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }

    private void ChangeScale()
    {
        transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * _movementSpeed * Time.deltaTime);
    }
}

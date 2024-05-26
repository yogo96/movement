using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        float distance = _moveSpeed * Time.deltaTime;
        transform.Translate(distance * Vector3.forward);
    }
}

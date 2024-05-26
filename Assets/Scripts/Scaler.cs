using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    void Update()
    {
        transform.localScale += Vector3.one * _moveSpeed * Time.deltaTime;
    }
}

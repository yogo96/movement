using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    
    void Update()
    {
        float rotateAngle = _moveSpeed * Time.deltaTime;
        transform.Rotate(0, rotateAngle,0);
    }
}

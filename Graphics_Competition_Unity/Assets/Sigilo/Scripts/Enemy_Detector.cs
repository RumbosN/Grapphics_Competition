using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Detector : MonoBehaviour
{
    public Transform _tPlayer;
    public float _depthOV;
    public float _RangeOv;

    private Transform _transform;

    private void Awake()
    {
        _transform = this.GetComponent<Transform>();
    }

    private void Update()
    {
        
    }

}

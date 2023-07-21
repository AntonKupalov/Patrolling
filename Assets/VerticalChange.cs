using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalChange : MonoBehaviour
{
    private float _t = 0;
    private float _amplitude = 0.75f;
    private float _frequancice = 2;
    private float _offset = 0;
    private Vector3 _startPosition;

    void Update()
    {
        _t += Time.deltaTime;
        _offset = _amplitude * Mathf.Sin(_t * _frequancice);
        transform.position = _startPosition + new Vector3(0, _offset, 0);
    }
}

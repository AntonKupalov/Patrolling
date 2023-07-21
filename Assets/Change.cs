using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Change : MonoBehaviour
{
    [SerializeField] private float minimum = 10.0F;
    [SerializeField] private float maximum = 20.0F;

    private void Update()
    {
        transform.localScale = new Vector2(Mathf.PingPong(Time.time, maximum-minimum)+minimum, Mathf.PingPong(Time.time, maximum-minimum)+minimum);
    }
}

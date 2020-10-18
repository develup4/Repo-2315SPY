﻿using UnityEngine;
using System.Collections;

public class TargetedCircle : MonoBehaviour
{
    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }

    public void MeshRendererOn(bool value)
    {
        GetComponent<MeshRenderer>().enabled = value;
    }
}
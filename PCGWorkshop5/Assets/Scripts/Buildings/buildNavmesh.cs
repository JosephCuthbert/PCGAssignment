﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class buildNavmesh : MonoBehaviour
{
    public NavMeshSurface surface;
    void Start()
    {
        surface.BuildNavMesh();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

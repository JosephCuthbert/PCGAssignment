using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CaveGeneration))]
public class customEditor : Editor
{
    public static bool runTime = false;
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        CaveGeneration generationScript = (CaveGeneration)target;

        if(GUILayout.Button("Generate Terrain"))
        {
            
            generationScript.Generate();
        }
    }
}

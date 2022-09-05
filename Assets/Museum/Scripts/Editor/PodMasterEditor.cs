using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PodMaster))]
public class PodMasterEditor : Editor
{
    private PodMaster _podMaster;


    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Get Pods"))
        {
            _podMaster.GetPods();
        }

        if (GUILayout.Button("Clear Pods"))
        {
            _podMaster.ClearPods();
        }

        if (GUILayout.Button("Populate Pods"))
        {
            _podMaster.PopulatePods();
        }

        if (GUILayout.Button("Disable Shadow Casting"))
        {
            _podMaster.DisableShadowCasting();
        }

        if (GUILayout.Button("Enable Shadow Casting"))
        {
            _podMaster.EnableShadowCasting();
        }
    }

    private void OnEnable()
    {
        _podMaster = target as PodMaster;
    }
}


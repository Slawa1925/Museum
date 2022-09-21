using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PodPlacer))]
public class PodPlacerEditior : Editor
{
    private PodPlacer _podPlacer;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Find Placeholders"))
        {
            _podPlacer.FindPlaceholders();
        }

        if (GUILayout.Button("Remove Pods"))
        {
            _podPlacer.RemovePods();
        }

        if (GUILayout.Button("Place Pods"))
        {
            _podPlacer.PlacePods();
        }
    }

    private void OnEnable()
    {
        _podPlacer = target as PodPlacer;
    }
}

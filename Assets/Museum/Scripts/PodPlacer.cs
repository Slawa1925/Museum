using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class PodPlacer : MonoBehaviour
{
    [SerializeField] private List<GameObject> _placeholders;
    [SerializeField] private GameObject _pod;


    public void PlacePods()
    {
#if UNITY_EDITOR
        for (int i = 0; i < _placeholders.Count; i++)
        {
            var pod = (GameObject)PrefabUtility.InstantiatePrefab(_pod);
            pod.transform.position = _placeholders[i].transform.position;
            pod.name = "Pod[" + i + "]";
            pod.transform.parent = transform;
            pod.transform.rotation = Quaternion.LookRotation(-_placeholders[i].transform.right);
        }
#endif
    }

    public void RemovePods()
    {
        for (int i = this.transform.childCount; i > 0; --i)
        {
            DestroyImmediate(this.transform.GetChild(0).gameObject);
        }
    }

    public void FindPlaceholders()
    {
        _placeholders = new List<GameObject>();

        GameObject[] gos = (GameObject[])FindObjectsOfType(typeof(GameObject));
        for (int i = 0; i < gos.Length; i++)
            if (gos[i].name.Contains("Pod_Placeholder"))
                _placeholders.Add(gos[i]);
    }
}

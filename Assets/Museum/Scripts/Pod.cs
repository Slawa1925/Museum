using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pod : MonoBehaviour
{
    [SerializeField] Transform _modelParent;
    private GameObject _model;

    public void Populate(GameObject model)
    {
        ClearPod();
        _model = Instantiate(model, _modelParent);
    }

    public void DisableShadowCasting()
    {
        foreach (Transform child in _model.transform)
        {
            child.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
        }
    }

    public void EnableShadowCasting()
    {
        foreach (Transform child in _model.transform)
        {
            child.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
        }
    }

    public void ClearPod()
    {
        foreach (Transform child in _modelParent)
        {
            DestroyImmediate(child.gameObject);
        }
    }
}

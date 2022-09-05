using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PodMaster : MonoBehaviour
{
    [SerializeField] private Pod[] _pod;
    [SerializeField] private GameObject[] _model;

    public void GetPods()
    {
        _pod = FindObjectsOfType<Pod>();
    }

    public void ClearPods()
    {
        for (int i = 0; i < _pod.Length; i++)
        {
            _pod[i].ClearPod();
        }
    }

    public void PopulatePods()
    {
        for (int i = 0; i < _pod.Length; i++)
        {
            if (_model.Length <= i)
            {
                _pod[i].Populate(_model[_model.Length - 1]);
                print("not enough models");
            }
            else
            {
                _pod[i].Populate(_model[i]);
            }
        }
    }

    public void DisableShadowCasting()
    {
        for (int i = 0; i < _pod.Length; i++)
        {
            _pod[i].DisableShadowCasting();
        }
    }

    public void EnableShadowCasting()
    {
        for (int i = 0; i < _pod.Length; i++)
        {
            _pod[i].EnableShadowCasting();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outfit : MonoBehaviour
{
    [SerializeField] private Transform headParentTransform;
    [SerializeField] private GameObject headOutfit;

    private void Awake()
    {
        OnInit();
    }

    private void OnInit(){
        headOutfit.transform.SetParent(headParentTransform);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour
{
    [SerializeField] private Transform parentTransform;

    private void Awake()
    {
        OnInit();
    }

    private void OnInit(){
        this.transform.SetParent(this.parentTransform);
    }
    
}

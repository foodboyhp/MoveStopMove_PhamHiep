using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour 
{
    [SerializeField] private float speed;
    [SerializeField] private WeaponData weaponData;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject hitVFX;
    private void Awake(){
        OnInit();
    }

    public void OnInit(){
        speed = 5;
        rb.velocity = transform.forward * speed;
        Invoke(nameof(OnDespawn), 5f);
    }

    public void OnDespawn(){
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag(Constants.TAG_PLAYER) || other.CompareTag(Constants.TAG_ENEMY)){
            Instantiate(hitVFX, transform.position, transform.rotation);
            OnDespawn();
        }
    }
}

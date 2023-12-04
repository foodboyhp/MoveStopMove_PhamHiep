using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : GameUnit
{
    [SerializeField] private WeaponHolder weaponHolder;
    [SerializeField] private Outfit outfit;
    [SerializeField] private AttackRange attackRange;
    [SerializeField] private Animator anim;
    [SerializeField] protected float speed;
    [SerializeField] private Weapon weaponPrefab;
    [SerializeField] private WeaponType weaponType;
    [SerializeField] private Transform attackPoint;

    private string currentAnim;
    
    private void Start(){

    }

    private void Update(){
        if(Input.GetKeyDown(KeyCode.C)){
            Attack();
        }
    }

    

    public override void OnInit(){

    }

    public override void OnDespawn(){

    }

    public void ChangeAnim(string animName){
        if(currentAnim != animName){
            anim.ResetTrigger(currentAnim);
            currentAnim = animName;
            anim.SetTrigger(currentAnim);
        }
    }

    private void SetDestination(){

    }

    

    private void Attack(){
        ChangeAnim(Constants.ANIM_ATTACK);
        Instantiate(weaponPrefab, attackPoint.position, attackPoint.rotation);
    }
}

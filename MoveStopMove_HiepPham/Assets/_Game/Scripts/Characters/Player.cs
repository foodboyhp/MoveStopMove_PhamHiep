using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField] private FloatingJoystick floatingJoystick;
    [SerializeField] private Rigidbody rbPlayer;
    private void FixedUpdate(){
        Move();
    }

    private void Move(){
        rbPlayer.velocity = new Vector3(floatingJoystick.Horizontal * speed, rbPlayer.velocity.y, floatingJoystick.Vertical * speed);
        
        if(floatingJoystick.Horizontal != 0 || floatingJoystick.Vertical != 0){
            TF.rotation = Quaternion.LookRotation(rbPlayer.velocity);
            ChangeAnim(Constants.ANIM_RUN);
        } else {
            ChangeAnim(Constants.ANIM_IDLE);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType {Arrow, Axe, Boomerang}
[CreateAssetMenu(fileName = "WeaponData", menuName = "MoveStopMove_HiepPham/WeaponData", order = 0)]
public class WeaponData : ScriptableObject {
    [SerializeField] GameObject[] weapons;
    public GameObject GetWeapon(WeaponType weaponType) {
        return weapons[(int)weaponType];
    }
}
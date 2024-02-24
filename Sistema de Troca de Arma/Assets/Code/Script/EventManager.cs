using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    [SerializeField] private ChangeWeapon changeWeapon;
    [SerializeField] private ChangeIndex changeIndex;

    void Start()
    {
        changeIndex.WeaponChanged += changeWeapon.OnChangeGun;
    }
}

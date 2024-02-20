using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeIndex : MonoBehaviour
{
    [SerializeField] private ChangeWeapon weaponChanger;
    [SerializeField] private Sprite[] weapons;

    private int currentIndex = 0;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            weaponChanger.ChangeGun(weapons, DecreaseIndex());
        }

        if (Input.GetButtonDown("Fire2"))
        {
            weaponChanger.ChangeGun(weapons, IncreaseIndex());
        }
    }

    int DecreaseIndex()
    {
       currentIndex--;

       if (currentIndex < 0)
       {
            currentIndex = weapons.Length - 1;
       }

       return currentIndex;
    }

    int IncreaseIndex()
    {
        currentIndex++;

        if (currentIndex >= weapons.Length)
        {
            currentIndex = 0;
        }

        return currentIndex;
    }
}

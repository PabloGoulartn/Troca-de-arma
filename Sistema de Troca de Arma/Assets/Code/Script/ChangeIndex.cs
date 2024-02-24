using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeIndex : MonoBehaviour
{
    public delegate void WeaponChangeManipulator(WeaponData[] weapon, int index);
    public event WeaponChangeManipulator WeaponChanged;

    [SerializeField] private WeaponData[] weapons;

    private int currentIndex = 0;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if (WeaponChanged != null)
            {
                WeaponChanged(weapons, DecreaseIndex());
            }
        }

        if (Input.GetButtonDown("Fire2"))
        {
            if (WeaponChanged != null)
            {
                WeaponChanged(weapons, IncreaseIndex());
            }
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

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName ="Weapon", menuName = "ScriptableObject/Weapon")]
public class WeaponData : ScriptableObject
{
    [SerializeField] private string weaponName;
    [SerializeField] private string weaponAmmunition;
    [SerializeField] private Sprite weaponSprite;

    public string GetWeaponName()
    {
        return weaponName;
    }

    public string GetWeaponAmmunition()
    {
        return weaponAmmunition;
    }

    public Sprite GetWeaponSprite()
    {
        return weaponSprite;
    }
}

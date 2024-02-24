using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{
    private SpriteRenderer sprite;
    [SerializeField] private TMP_Text weaponName;
    [SerializeField] private TMP_Text weaponAmmunition;

    [SerializeField] private WeaponData weaponData;

    void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        weaponName.SetText(weaponData.GetWeaponName());
        weaponAmmunition.SetText(weaponData.GetWeaponAmmunition());
    }

    public void OnChangeGun(WeaponData[] weapon, int index)
    {
        sprite.sprite = weapon[index].GetWeaponSprite();
        weaponName.SetText(weapon[index].GetWeaponName());
        weaponAmmunition.SetText(weapon[index].GetWeaponAmmunition());
    }
}

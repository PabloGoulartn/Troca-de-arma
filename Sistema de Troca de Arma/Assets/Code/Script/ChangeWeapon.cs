using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{
    private SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    public void ChangeGun(Sprite[] weapon, int index)
    {
        sprite.sprite = weapon[index];
    }
}

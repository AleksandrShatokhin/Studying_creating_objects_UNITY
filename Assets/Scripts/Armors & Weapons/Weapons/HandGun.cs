using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGun : WeaponManager
{
    Weapon weapon = new Weapon();

    private void Start()
    {
        weapon.SetCurrentWeapon(GameController.GetInstance().GetHandGun());
    }

    public void Shot()
    {
        Instantiate(projectile, spawnProjectilePosition.position, spawnProjectilePosition.rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            weapon.PlayerTakesWeapon();
        }
    }
}

using System.Collections.Generic;
using UnityEngine;

public class WeaponSwap : MonoBehaviour
{
    public int weaponNumber = 0;
    FPSControls input;
    public List<GameObject> Weapons;
    public List<GameObject> Crosshair;
    public GameObject CurrentWeapon;

    private void Awake()
    {
        input = new FPSControls();
    }

    private void Update()
    {
        ScrollWeaponSwap();
    }

    public void ScrollWeaponSwap()
    {
        var previousWeapon = weaponNumber;
        var scroll = input.Player.WeaponSwap.ReadValue<float>();
        if (scroll > 0 || input.Player.SwapQ.triggered)
        {
            if (weaponNumber >= Weapons.Count - 1)
            {
                weaponNumber = 0;
            }
            else
            {
                weaponNumber += 1;
            }
        }
        else if (scroll < 0)
        {
            if (weaponNumber <= 0)
            {
                weaponNumber = Weapons.Count - 1;
            }
            else
            {
                weaponNumber -= 1;
            }
        }

        if (previousWeapon != weaponNumber)
        {
            SelectWeapon();
        }

        CurrentWeapon = Weapons[weaponNumber];
    }

    public void SelectWeapon()
    {
        for (int i = 0; i < Weapons.Count; i++)
        {
            if (i == weaponNumber)
            {
                Weapons[i].gameObject.SetActive(true);
                Crosshair[i].gameObject.SetActive(true);
            }
            else
            {
                Weapons[i].gameObject.SetActive(false);
                Crosshair[i].gameObject.SetActive(false);
            }
        }
    }

    private void OnEnable()
    {
        input.Player.Enable();
    }

    private void OnDisable()
    {
        input.Player.Disable();
    }
} 

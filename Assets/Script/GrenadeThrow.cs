using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrow : MonoBehaviour
{
    public int grenadeAmount = -1;
    public GameObject grenade;
    public Transform spawnPoint;
    FPSControls input;
    private void Awake()
    {
        input = new FPSControls();
    }

    private void Update()
    {
        CheckNadesAmount();
        if (input.Player.Shooting.triggered)
        {
            Throwing();
        }
    }

    public void Throwing()
    {
        grenadeAmount--;
        var grenadeInstance = Instantiate(grenade, spawnPoint.position, spawnPoint.rotation);
        grenadeInstance.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * 10f, ForceMode.Impulse);
    }

    public void CheckNadesAmount()
    {
        //Swap to weapon if you run out of grenades
        if (grenadeAmount < 1)
        {
            var Swap = GetComponentInParent<WeaponSwap>();
            Swap.Weapons.RemoveAt(Swap.Weapons.Count - 1);
            Swap.weaponNumber = Swap.Weapons.Count - 1;
            Swap.CurrentWeapon = Swap.Weapons[Swap.weaponNumber];
            Swap.SelectWeapon();
            Destroy(gameObject);
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

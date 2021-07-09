using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Aiming : MonoBehaviour
{
    FPSControls input;
    public Animator animator;
    public GameObject scopeOverlay;
    public GameObject crosshair;
    public GameObject weaponHolder;
    public CinemachineVirtualCamera vcam;
    public bool aimMode = false;
    
    private void Awake()
    {
        input = new FPSControls();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (input.Player.Aim.triggered)
        {
            aimMode = !aimMode;
            animator.SetBool("isAiming", aimMode);

            if(aimMode)
            {
                GetComponentInParent<WeaponSwap>().enabled = false;
                StartCoroutine(ScopeEnable());
            }
            else
            {
                GetComponentInParent<WeaponSwap>().enabled = true;
                ScopeDisable();
            }
        }
    }

    IEnumerator ScopeEnable()
    {
        yield return new WaitForSeconds(.25f);
        scopeOverlay.SetActive(true);
        weaponHolder.SetActive(false);
        crosshair.SetActive(false);
        vcam.m_Lens.FieldOfView = 15;
    }
 
    public void ScopeDisable()
    {
        crosshair.SetActive(true);
        scopeOverlay.SetActive(false);
        weaponHolder.SetActive(true);
        vcam.m_Lens.FieldOfView = 40;
    }

    private void OnEnable()
    {
        input.Player.Aim.Enable();
    }

    private void OnDisable()
    {
        input.Player.Aim.Disable();
    }
}

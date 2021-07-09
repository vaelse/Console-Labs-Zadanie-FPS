using UnityEngine;

public class Shooting : MonoBehaviour
{
    RaycastHit rayHit;
    FPSControls input;
    Transform cameraPosition;
    public Animator animator;
    public ParticleSystem muzzleFlashEffect;
    public GameObject bulletImpactEffect;
    public AudioSource audiosource;

    private bool shotDelay;
    private int bulletsShot;

    public int damage, bulletsPerTap;
    public float shotDelayTime, spread, timeBetweenShot;
    public bool holdDownShoot;
    public bool material1;
    public bool material2;

    private void Awake()
    {
        shotDelay = true;
        input = new FPSControls();
        cameraPosition = Camera.main.transform;
        animator = GetComponent<Animator>();
        Cursor.visible = false;
    }

    private void Update()
    {
        Input();
    }

    private void Input()
    {
        if (holdDownShoot && input.Player.Shooting.ReadValue<float>() != 0 && shotDelay)
        {
            animator.SetBool("isShooting", true);
            Shoot();
        }
        else if (input.Player.Shooting.triggered && shotDelay)
        {
            bulletsShot = bulletsPerTap;
            animator.SetBool("isShooting", true);
            Shoot();
        }
        else
        {
            animator.SetBool("isShooting", false);
        }
    }
    private void Shoot()
    {
        shotDelay = false;
        audiosource.Play();
        muzzleFlashEffect.Play();
        //Spread
        var x = Random.Range(-spread, spread);
        var y = Random.Range(-spread, spread);
        Vector3 direction = cameraPosition.transform.forward + new Vector3(x, y, 0);

        //RayCast
        if (Physics.Raycast(cameraPosition.position, direction, out rayHit))
        {
            var target = rayHit.transform.GetComponent<TakingDamage>();
            if (target != null )
            {
                if (target.CompareTag("Material1") && material1)
                {
                    target.TakeDamage(damage);
                }
                if (target.CompareTag("Material2") && material2)
                {
                    target.TakeDamage(damage);
                }
            }
        }

        //bullet impact
        var impact = Instantiate(bulletImpactEffect, rayHit.point, Quaternion.LookRotation(rayHit.normal));
        Destroy(impact, 0.5f);
        bulletsShot--;

        Invoke(nameof(ResetShot), shotDelayTime);

        if (bulletsShot > 0)
            Invoke(nameof(Shoot), timeBetweenShot);
    }

    private void ResetShot()
    {
        shotDelay = true;
    }

    private void OnEnable()
    {
        input.Player.Shooting.Enable();
    }

    private void OnDisable()
    {
        input.Player.Shooting.Disable();
    }
}
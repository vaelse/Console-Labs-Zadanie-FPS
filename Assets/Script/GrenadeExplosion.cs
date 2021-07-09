using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeExplosion : MonoBehaviour
{
    public ParticleSystem explosionEffect;
    public float explosionForce;
    public float explosionRadius;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Explosion();
        }
    }
    public void Explosion()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        var colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach(var col in colliders)
        {
            var rb = col.GetComponent<Rigidbody>();
            var targetCol = col.GetComponent<TakingDamage>();
            if (rb != null && targetCol != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius, 1f, ForceMode.Impulse);
                targetCol.TakeDamage(50);
            }
        }
    }
}

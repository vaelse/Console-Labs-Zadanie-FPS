using UnityEngine;
using UnityEngine.Events;

public class TakingDamage : MonoBehaviour
{
    public float health = 50f;
    public GameObject DestroyEffect;

    public void TakeDamage(float dmgAmount)
    {
        health -= dmgAmount;
        if (health <= 0)
        {
            if (DestroyEffect != null)
            {
                var instantiateEffect = Instantiate(DestroyEffect, gameObject.transform.position, gameObject.transform.rotation);
                Destroy(instantiateEffect, 4f);
            }
            gameObject.SetActive(false);          
        }
    }
}
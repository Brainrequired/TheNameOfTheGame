using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class PlayerStruckBehaviour : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            HealthBehaviour health = gameObject.GetComponent(typeof(HealthBehaviour)) as HealthBehaviour;
            DamageBehaviour damage = collision.gameObject.GetComponent(typeof(DamageBehaviour)) as DamageBehaviour;
            if (health != null && damage != null)
            {
                health.ApplyDamage(damage.DamageAmount);
            }
        }
    }
}
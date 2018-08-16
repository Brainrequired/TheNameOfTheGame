using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class DestroyOnNonPlayerImpact : MonoBehaviour
{
  void OnCollisionEnter2D(Collision2D collision)
  {
    if(!collision.gameObject.CompareTag("Player"))
    {
        Destroy(gameObject);
    }
  }
}
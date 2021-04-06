using System.Collections;
using System.Collections.Generic;
using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;
  
    public class DeathZone : MonoBehaviour 

{
    public int damageOncollision = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            PlayerHealf playerHealf = collision.transform.GetComponent<PlayerHealf>();
            playerHealf.TakeDamage(damageOncollision);
        }
    }
}

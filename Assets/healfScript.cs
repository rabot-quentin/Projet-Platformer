using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healfScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.CompareTag("Player"))
        {
            
            PlayerHealf playerHealf = collider.transform.GetComponent<PlayerHealf>();
            playerHealf.Takeheal(1);

            Destroy(transform.gameObject);
        }
    }
}

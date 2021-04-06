using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteB : MonoBehaviour
{
    public GameObject porte;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            if(GameManager.Instance.p.clé == 1)
            {
                Destroy(this.porte);
            }
            
        }
    }
}

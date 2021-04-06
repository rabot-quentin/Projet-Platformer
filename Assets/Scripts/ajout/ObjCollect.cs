using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjCollect : MonoBehaviour
{
  
    public GameObject Obj;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            Destroy(this.Obj);
        }
    }
}

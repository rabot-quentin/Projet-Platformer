using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Avancer : MonoBehaviour
{
    public Text text ;
     
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Duret();
            StartCoroutine(Duret());
        }
        
    }
     IEnumerator Duret()
    {
        text.text = " Pour avancer appuiller sur la touche -> de votre clavier puis sur <- pour reculer ";
        yield return new WaitForSeconds(3f);
        text.text = " ";
        

    }
}

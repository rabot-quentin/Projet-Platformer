using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Exolication : MonoBehaviour
{
   public Text text ;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            text.text = "pour avancer appuiller sur -> de votre clavier ";
        }

    }
    
}

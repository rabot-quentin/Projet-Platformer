using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class tir : MonoBehaviour
{
    public Text txt;

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
        txt.text = " Pour tirer apuiler sur alt  ";
        yield return new WaitForSeconds(3f);
        txt.text = " ";


    }
}

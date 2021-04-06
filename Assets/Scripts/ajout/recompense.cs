using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class recompense : MonoBehaviour
{
    public Text txt;
    public Image image;
    public class Avancer : MonoBehaviour
    {
        public Text text;

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
            text.text = " Bravo vous avez deblocker la meidalle oursons ";
            yield return new WaitForSeconds(3f);
            text.text = " ";


        }
    }
}

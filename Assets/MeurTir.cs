using UnityEngine;

public class MeurTir : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TirAlli�"))
        {
            Destroy(transform.parent.parent.gameObject);
        }
    }
}


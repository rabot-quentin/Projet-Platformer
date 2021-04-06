using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMouve : MonoBehaviour
{
    public float speed;
    public Transform[] waypoint;

    public int damageOncollision = 1 ; 

    public SpriteRenderer enemieBasique ; 
    private Transform target;
    private int destPoint = 0; 
    void Start()
    {
        target = waypoint[0]; 
    }

    
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) < 0.2f) 
        {
            destPoint = (destPoint + 1) % waypoint.Length;
            target = waypoint[destPoint];
            enemieBasique.flipX = !enemieBasique.flipX; 
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            PlayerHealf playerHealf = collision.transform.GetComponent<PlayerHealf>();
            playerHealf.TakeDamage(1); 
        }
    }
}

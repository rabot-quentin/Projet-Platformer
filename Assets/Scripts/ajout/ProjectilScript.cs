using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilScript : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float lifeTime = 6;
    public int damage = 1;
    public bool enemie = false;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifeTime);
    }

    public Vector2 speed = new Vector2(10,0);
    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = speed ;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieTirScript : MonoBehaviour
{
    public GameObject thePrefab;
    public float shotTime;
    private float startTime;
    private float elapsedTime;

    void Start()
    {
        startTime = Time.time;


    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime = Time.time - startTime;

        if (elapsedTime >= shotTime)
        {
            startTime = Time.time;
            var pos = transform.position;
            pos.x += 1f;
            var instance = Instantiate(thePrefab, pos, transform.rotation);
        }

    }
}

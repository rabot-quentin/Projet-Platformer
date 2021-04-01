using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public int hp = 1;
    public bool isEnemy = true;

    void OnCollisionEnter2D(Collision2D coll)
    {
        var collider = coll.collider;
        
        ProjectilScript shot = collider.gameObject.GetComponent<ProjectilScript>();

        if (shot != null){
            if(shot.enemie != isEnemy)
            {
                hp -= shot.damage;
            Destroy(shot.gameObject);

                if (hp <= 0)
                {
                Destroy(gameObject);

                //var ScoreManager = GameObject.Find("script");

                if(isEnemy)
                    {
                        //ScoreManager.GetComponent<ScoreManager>().score += 200;
                        Destroy(gameObject);
                    }else
                    {
                        //ScoreManager.GetComponent<ScoreManager>().gameOver = true;
                    }
                }
            }else
            {
                collider.enabled = false;
            }
            
        }
    }
    
}

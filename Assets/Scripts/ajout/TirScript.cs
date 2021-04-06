using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirScript : MonoBehaviour
{
    public GameObject thePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("left alt")&& GameManager.Instance.p.munition > 0)
        {
            var pos = transform.position;
            pos.x += 1f;
            var instance = Instantiate(thePrefab, pos , transform.rotation);
            GameManager.Instance.p.munition -= 1;
        }
    }
}

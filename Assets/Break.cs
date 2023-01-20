using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    ScoreScript ss;
    // Start is called before the first frame update
    void Start()
    {
        ss = GameObject.FindGameObjectWithTag("PlayCanvas").GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {  
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ball"){
            ss.UpdateScore();
            Destroy(gameObject);
        }
    }
}

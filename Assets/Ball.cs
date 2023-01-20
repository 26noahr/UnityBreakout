using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    [SerializeField]
    float speed;
    //float radius;
    Vector2 direction;


    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.down.normalized; //   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (direction * speed * Time.deltaTime);
        if (Input.GetKey("escape"))
             Application.Quit();   
    }

    //Bounce on contact
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Side"){
            direction.x = -direction.x;
        }
        if (other.tag == "Vert" || other.tag == "Block"){
            direction.y = -direction.y;
        }
        if (other.tag == "Player"){
            direction.y = -direction.y;
            direction.x = (gameObject.transform.position.x - other.transform.position.x);
            direction = direction.normalized;
        }
        if (other.tag == "Finish"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

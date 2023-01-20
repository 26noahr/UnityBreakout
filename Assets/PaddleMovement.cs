using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PaddleMovement : MonoBehaviour
{

   string input;
   [SerializeField]
   float speed;

    // Start is called before the first frame update
    void Start()
    {
        input = "Horizontal";
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis(input) * Time.deltaTime * speed;
        transform.Translate (move * Vector2.right);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //key input

        moveHorizontal = Input.GetKey("a") ? -1 : Input.GetKey("d") ? 1 : moveHorizontal;
        moveVertical = Input.GetKey("w") ?  1 : Input.GetKey("s") ? -1 : moveVertical;

        

        //Movement through cursor
        moveHorizontal = Input.GetKey("left")? -1 : Input.GetKey("right")? 1 : moveHorizontal;
        

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        transform.position = transform.position + movement * speed * Time.deltaTime;
        
        
    }
}

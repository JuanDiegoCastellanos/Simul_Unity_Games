using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalasScript : MonoBehaviour
{
    public float speed = 0.5f;
    public Vector2 direction;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        Vector2 movement;
        //Vector2 movement;
        // transform.position = new Vector2(transform.position.x + movement.x, transform.position.y + movement.y);
        //transform.Translate(movement);
         
          
        //if (Direction == Vector3.left) transform.localScale = new Vector3(-0.1885742f, 0.1930227f, 1.0f);
        //else transform.localScale = new Vector3(0.1885742f, 0.1930227f, 1.0f);
         
         
          if (transform.position.x == 2.32f)
        {
        //Debug.Log("Se esta moviendo en :" + transform.position.x);
        direction = new Vector2(-0.1f, 0);
        speed = 0.5f;
        movement = direction.normalized * speed * Time.deltaTime;
        transform.localScale = movement;
        transform.Translate(movement);
         
        } 
        else if (transform.position.x == -2.32f)
        {
        direction = new Vector2(0.1f, 0);
        speed = 0.5f;
        movement = direction.normalized * speed * Time.deltaTime;
           transform.localScale = movement;
        transform.Translate(movement);
      
        }
        else 
        {
        movement = direction.normalized * speed * Time.deltaTime;  
        transform.Translate(movement);
        }
        
    }
}

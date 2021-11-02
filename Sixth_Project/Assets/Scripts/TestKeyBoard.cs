using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestKeyBoard : MonoBehaviour
{
   
    void Start()
    {
   
        
    }

    void Update()
    {
    // 1. Test the mouse
    if (Input.GetMouseButtonDown(0)) //Al oprimir el botón izquierdo
    {
    Debug.Log("Botón izquierdo se ha presionado. Solo lo aplica una vez");
    }
    if (Input.GetMouseButton(0))
    {
    Debug.Log("Se está presionando el botón izquierdo");
    }
    
    if (Input.GetMouseButtonUp(0))
    {
    Debug.Log("Se ha liberado el botón izquierdo");
    }
    
    // 2. test the keyboard
    if (Input.GetKeyDown(KeyCode.Space))
    {
    Debug.Log("Se ha oprimido el espacio. Aparece solo una vez");
    }
    
    // 3. Using the default configs
    if (Input.GetButtonDown("Jump"))
    {
    Debug.Log("Usando Jump. Solo se llama una vez al oprimir");
    }
    
    // 4. Using the right or left arrow keys 
    
    float horizontal = Input.GetAxis("Horizontal"); // Values -1 to 1
    float vertical = Input.GetAxis("Vertical"); // Values -1 to 1
    
    if (horizontal < 0 || horizontal > 0)
    {
    Debug.Log("Horizontal axis is: " + horizontal);
    }
    
    if (vertical < 0 || vertical > 0)
    {
    Debug.Log("Vertical axis is: "+ vertical);
    }
    
    
    }
}

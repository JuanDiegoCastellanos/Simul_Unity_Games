using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{

public GameObject prefabBala;
private Transform shootPointX;
public GameObject tirador;

private void Awake()
{
 shootPointX = transform.Find("shootPoint");
}

    void Start()
    {
    //Instantiate(prefabBala, shootPointX.position, Quaternion.identity);
    Disparo();
        
    }


    void Update()
    {
        
    }
    
    void Disparo()
    {
    if (prefabBala != null  && shootPointX != null && tirador != null)
    {
    GameObject myBullet = Instantiate(prefabBala, shootPointX.position, Quaternion.identity) as GameObject;
    
    //Se toma el nombre del script de balas
    BalasScript bulletComponent = myBullet.GetComponent<BalasScript>();
    
    if(tirador.transform.localScale.x < 0)
    {
       bulletComponent.direction = Vector2.left;
    
    }       
    else
    {
    bulletComponent.direction = Vector2.right;
    }
    }
    
    
    }
}

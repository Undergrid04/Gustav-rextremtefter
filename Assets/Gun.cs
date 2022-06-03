using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    //betyder precis som vad det st�r
    public float damage = 20f;
    public float range = 100f;
    public Camera fpsCam;
    
    
    void Update()
    {         //knapp f�r att skjuta (fire 1 
        if (Input.GetButtonDown("Fire1")) 
        {
            Shoot();
        }

       
    }

    void Shoot() 
    {     //skjuter ut en Raycast (skott) p� ett objekt och visar det i consolen om den tr�ffar. 
        RaycastHit hit;
       if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

           Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }  //N�r den tr�ffar objektet s� tar den "skada"
        }
    }
}


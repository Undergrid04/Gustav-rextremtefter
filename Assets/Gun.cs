using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    //betyder precis som vad det står
    public float damage = 20f;
    public float range = 100f;
    public Camera fpsCam;
    
    
    void Update()
    {         //knapp för att skjuta (fire 1 
        if (Input.GetButtonDown("Fire1")) 
        {
            Shoot();
        }

       
    }

    void Shoot() 
    {     //skjuter ut en Raycast (skott) på ett objekt och visar det i consolen om den träffar. 
        RaycastHit hit;
       if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

           Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }  //När den träffar objektet så tar den "skada"
        }
    }
}


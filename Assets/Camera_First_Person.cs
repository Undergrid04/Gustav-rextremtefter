using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_First_Person : MonoBehaviour
{
    // as said. sensivity
    public float mouseSensivity = 100f;

    public Transform Cylinder;

    float xRotation = 0f;

    void Start() 
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    //gör så att muspekarn alltid blir center då den är i en låst position

    void Update()
    {   //musen gör att du kan vända på dig.
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 80f);
        //gör så att du inte kan gå mer än -90 eller 80 på y axeln, alltså att du inte kan fortsätta snurra när du tittar upp/ned
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        Cylinder.Rotate(Vector3.up * mouseX);
        //objectet tittar alltid fram, det vrider samtidigt med ditt perspektiv


    }
}
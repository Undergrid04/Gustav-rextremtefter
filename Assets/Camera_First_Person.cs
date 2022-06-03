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
    //g�r s� att muspekarn alltid blir center d� den �r i en l�st position

    void Update()
    {   //musen g�r att du kan v�nda p� dig.
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 80f);
        //g�r s� att du inte kan g� mer �n -90 eller 80 p� y axeln, allts� att du inte kan forts�tta snurra n�r du tittar upp/ned
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        Cylinder.Rotate(Vector3.up * mouseX);
        //objectet tittar alltid fram, det vrider samtidigt med ditt perspektiv


    }
}
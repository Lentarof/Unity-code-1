using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject thirdPersonCamera;
    public GameObject firstPersonCamera;
    int aux = 1;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("CamSwitch"))
        {
            if (aux == 1)
            {
                thirdPersonCamera.SetActive(false);
                firstPersonCamera.SetActive(true);
                aux = 2;
            }
            else 
            {
                if (aux == 2)
                {
                    thirdPersonCamera.SetActive(true);
                    firstPersonCamera.SetActive(false);
                    aux = 1;
                }
            }
        }
    }
}

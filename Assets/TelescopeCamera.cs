using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelescopeCamera : MonoBehaviour
{

    private Camera cam;
    float camFieldOfView;
    
    // Start is called before the first frame update
    void Start()
    {
        cam = gameObject.GetComponent<Camera>();
        camFieldOfView = cam.fieldOfView;
        cam.fieldOfView = 40f;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.P))
        {

            
            //Debug.Log("Vpravo");
            cam.fieldOfView = camFieldOfView++;
            return;

        }

        if (Input.GetKeyDown(KeyCode.O))
        {

              
             //Debug.Log("Vlevo");
             cam.fieldOfView = camFieldOfView--;
             return;

            
        }

    }


    void AdjustFieldOfView(int i)
    {
        cam.fieldOfView = camFieldOfView + i;


    }
}

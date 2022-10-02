using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TelescopeCamera : MonoBehaviour
{

    private Camera cam;
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject mainPanel;
    float camFieldOfView;
    float maxFieldOfView=120f;

   


    // Start is called before the first frame update
    void Start()
    {
        cam = gameObject.GetComponent<Camera>();
        camFieldOfView = cam.fieldOfView;
        cam.fieldOfView = 100f;

      

    }

    // Update is called once per frame
    void Update()
    {

        if (cam.fieldOfView <= 0) return;

            //Debug.Log(cam.fieldOfView);
        if (cam.fieldOfView >= maxFieldOfView)

        {
            gameOver.SetActive(true);
            mainPanel.SetActive(false);
            return;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {

            
            //Debug.Log("Vpravo");
            cam.fieldOfView = cam.fieldOfView + 1;
            return;

        }

        if (Input.GetKeyDown(KeyCode.A))
        {

              
             //Debug.Log("Vlevo");
             cam.fieldOfView = cam.fieldOfView - 1;
             return;

            
        }

    }


    void AdjustFieldOfView(int i)
    {
        cam.fieldOfView = camFieldOfView + i;


    }
}

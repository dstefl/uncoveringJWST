using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUpdate : MonoBehaviour
{


    [SerializeField] Camera cam;
    private TextMeshProUGUI textMesh;

    private void Start()
    {

        textMesh = gameObject.GetComponent<TextMeshProUGUI>();
        //Debug.Log(textMesh.text);
        textMesh.text = " " + cam.fieldOfView;
    }
    void Update()
    {
        textMesh.text = " " + cam.fieldOfView;
        Debug.Log(textMesh.text);
        //Debug.Log(cam.fieldOfView);
    }
}

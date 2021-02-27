using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globos : MonoBehaviour
{
    void Start()
    {
        gameObject.tag = "Globos";
        Globe(6.81f, 4.28f, 5.93f);
        Globe(1.9f, 3.28f, 0.6f);
        Globe(-5.32f, 6.3f, 8.93f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Globe(float x, float y, float z){ 
        GameObject Up = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Up.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        Up.transform.position = new Vector3(x,y,z);
        Up.GetComponent<Renderer>().material.color= new Color(1,0.5293f,0);
        Up.transform.parent = GameObject.FindWithTag("Globos").transform;
        GameObject arriba = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        arriba.transform.parent = Up.transform;
        arriba.transform.localPosition = new Vector3(0, -0.5f, 0);
        arriba.transform.localScale = new Vector3(0.5f, 0.1f, 0.5f);
        arriba.GetComponent<Renderer>().material.color= new Color(1,0.2174f,0);
        GameObject canasta = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        canasta.transform.parent = Up.transform;
        canasta.transform.localPosition = new Vector3(0, -1.2f, 0);
        canasta.transform.localScale = new Vector3(0.5f, 0.2f, 0.5f);
        canasta.GetComponent<Renderer>().material.color= new Color(0.3379f,0.2290f,0.2290f);
        GameObject lightGameObject = new GameObject("The Light");
        Light lightComp = lightGameObject.AddComponent<Light>();
        lightComp.color = Color.yellow;
        lightGameObject.transform.parent = arriba.transform;
        lightGameObject.transform.localPosition = new Vector3(0, -1, 0);
    }
}

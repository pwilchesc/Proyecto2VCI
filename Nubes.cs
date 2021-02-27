using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nubes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Nubes";
        transform.localPosition = new Vector3(0, 0, 0);
        Nube(-3f,7.09f,10f);
        Nube(10.87f,7f,2f);   
        Nube(7f,9.66f,-2f);
        Nube(-4f,5.5f,-6.9f);
        Nube(0,7f,5f);
        Nube(3.77f,8.45f,10f);
    }

    // Update is called once per frame
  void Nube(float x, float y, float z){ 
        GameObject nube1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        nube1.transform.localScale = new Vector3(1,1,1);
        nube1.transform.localPosition = new Vector3(x,y,z);
        nube1.GetComponent<Renderer>().material.color= new Color(0.5f,0.8292f,1);
        nube1.transform.parent = GameObject.FindWithTag("Nubes").transform;
        GameObject nube2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        nube2.transform.parent = nube1.transform;
        nube2.transform.localPosition = new Vector3(0,-0.5F,0);
        nube2.GetComponent<Renderer>().material.color= new Color(0.5f,0.8292f,1);
        GameObject nube3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        nube3.transform.parent = nube1.transform;
        nube3.transform.localPosition = new Vector3(-0.5F,-0.3F,0);
        nube3.GetComponent<Renderer>().material.color= new Color(0.5f,0.8292f,1);
        GameObject nube4 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        nube4.transform.parent = nube1.transform;
        nube4.transform.localPosition = new Vector3(0.5F,-0.3F,0);
        nube4.GetComponent<Renderer>().material.color= new Color(0.5f,0.8292f,1);
        GameObject nube5 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        nube5.transform.parent = nube1.transform;
        nube5.transform.localPosition = new Vector3(-0.8F,-0.6F,0);
        nube5.GetComponent<Renderer>().material.color= new Color(0.5f,0.8292f,1);
        GameObject nube6 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        nube6.transform.parent = nube1.transform;
        nube6.transform.localPosition = new Vector3(0.8F,-0.6F,0);
        nube6.GetComponent<Renderer>().material.color= new Color(0.5f,0.8292f,1);
    }
    
}

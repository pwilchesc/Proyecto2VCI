using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Avion";
        Plane(-7.19f, 7.52f,-2); 

    }

    void Plane(float x, float y, float z){
        GameObject body = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        body.transform.position = new Vector3(x,y,z);
        body.transform.localScale = new Vector3(1, 1, 1);
        body.transform.rotation = Quaternion.Euler(0, 0, 90f);
        body.GetComponent<Renderer>().material.color= new Color(0.1415f,0.1216f,0.1161f);
        body.transform.parent = GameObject.FindWithTag("Avion").transform;
        GameObject back = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        back.transform.parent = body.transform;
        back.transform.localPosition = new Vector3(0, -1f, 0);
        back.transform.localScale = new Vector3(0.5f, 0.3f, 0.5f);
        back.transform.rotation = Quaternion.Euler(0, 0, 90f);
        back.GetComponent<Renderer>().material.color= new Color(0.1415f,0.1216f,0.1161f);
        GameObject Wings = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Wings.transform.parent = body.transform;
        Wings.transform.localScale = new Vector3(0.5f, 0.2f, 2f);
        Wings.transform.localPosition = new Vector3(0, 0, 0);
        Wings.GetComponent<Renderer>().material.color= new Color(0.1415f,0.1216f,0.1161f);
    }
}

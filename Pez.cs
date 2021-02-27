using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pez : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Pez";
        Pez1(-6.41f, 0.9f, -26f);
    }

    // Update is called once per frame
    void Pez1(float x, float y, float z)
    {
        GameObject Center = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Center.transform.localScale = new Vector3(0.5f, 1f, 2f);
        Center.transform.position = new Vector3(x,y,z);
        Center.GetComponent<Renderer>().material.color= new Color(1,0.5293f,0);
        Center.transform.parent = GameObject.FindWithTag("Pez").transform;   
        GameObject eye1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        eye1.transform.localScale = new Vector3(1f, 0.5f, 0.5f);
        eye1.transform.localPosition = new Vector3(1f,1f,1f);
        eye1.transform.rotation = Quaternion.Euler(0, -10.385f, 0);
        eye1.GetComponent<Renderer>().material.color= new Color(0,0,0);
        eye1.transform.parent = Center.transform;  
        GameObject Aleta1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Aleta1.transform.localScale = new Vector3(1f, 1f, 1f);
        Aleta1.transform.localPosition = new Vector3(1f,1f,1f);
        Aleta1.GetComponent<Renderer>().material.color= new Color(0.1415f,0.1216f,0.1161f);
        Aleta1.transform.parent = Center.transform;
    }
}

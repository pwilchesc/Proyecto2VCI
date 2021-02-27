using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barcos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Barco";
        transform.localPosition = new Vector3(0, 0, 0);
        Bote(-8f, 0.5f, 2.4f);
        Bote(6f, 0.5f, -8.5f);
    }

    // Update is called once per frame
    void Bote(float x, float y, float z)
    {
        Vector3[] Vertices1 = new Vector3[5];
        Vector2[] uv = new Vector2[5];
        Vertices1[0] = new Vector3(0, 0, 0);
        Vertices1[1] = new Vector3(1f, 0, 0.5f);
        Vertices1[2] = new Vector3(1f, 0, -0.5f);
        Vertices1[3] = new Vector3(1f, -1, -0.5f);
        Vertices1[4] = new Vector3(1f, -1, 0.5f);
        uv[0] = new Vector3(0, 0, 0);
        uv[1] = new Vector3(1f, 0, 0.5f);
        uv[2] = new Vector3(1f, 0, -0.5f);
        uv[3] = new Vector3(1f, -1, -0.5f);
        uv[4] = new Vector3(1f, -1, 0.5f);

        Mesh mesh = new Mesh();
        mesh.vertices = Vertices1;
        mesh.uv = uv;
        mesh.triangles = new int[] { 0, 1, 2, 0, 2, 3, 0, 3, 4, 0, 4, 1, 2, 1, 4, 2, 4, 3 };

        GameObject Centro = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Centro.transform.localScale = new Vector3(2, 1, 1);
        Centro.transform.localPosition = new Vector3(x, y, z);
        Centro.GetComponent<Renderer>().material.color = new Color(0.3379f, 0.2290f, 0.2290f);
        Centro.transform.parent = GameObject.FindWithTag("Barco").transform;

        GameObject Triangle = new GameObject("Triangle", typeof(MeshFilter), typeof(MeshRenderer));
        Triangle.transform.parent = Centro.transform;
        Triangle.transform.localScale = new Vector3(1, 1, 1);
        Triangle.transform.localPosition = new Vector3(-1.5f, 0.5f, 0);
        Triangle.GetComponent<MeshFilter>().mesh = mesh;
        Triangle.GetComponent<Renderer>().material.color = new Color(0.3379f, 0.2290f, 0.2290f);
        GameObject Triangle2 = new GameObject("Triangle2", typeof(MeshFilter), typeof(MeshRenderer));
        Triangle2.transform.parent = Centro.transform;
        Triangle2.transform.rotation = Quaternion.Euler(0, 180f, 0);
        Triangle2.transform.localScale = new Vector3(1, 1, 1);
        Triangle2.transform.localPosition = new Vector3(1.5f, 0.5f, 0);
        Triangle2.GetComponent<MeshFilter>().mesh = mesh;
        Triangle2.GetComponent<Renderer>().material.color = new Color(0.3379f, 0.2290f, 0.2290f);
        GameObject Triangle3 = new GameObject("Triangle2", typeof(MeshFilter), typeof(MeshRenderer));
        Triangle3.transform.parent = Centro.transform;
        Triangle3.transform.rotation = Quaternion.Euler(270f, -45f, 45f);
        Triangle3.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        Triangle3.transform.localPosition = new Vector3(-0.5F, 1.5F, 0);
        Triangle3.GetComponent<MeshFilter>().mesh = mesh;
        Triangle3.GetComponent<Renderer>().material.color = new Color(0.8584f, 0.0242f, 0.1429f);
    }
}

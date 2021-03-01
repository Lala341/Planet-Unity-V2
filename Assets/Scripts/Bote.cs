using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bote : MonoBehaviour
{
    GameObject vela1;
    GameObject vela2;
    GameObject cilindro;
    GameObject borde1;
    GameObject borde2;
    GameObject cuerpo;
    GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        parent= GameObject.Find("PlanetSphere");

        //Parent-vela1
        vela1= createPyramid("Bote");
        vela1.transform.parent = parent.transform;
        configureObjectGlobal(vela1, 0.123999998f, -0.202999994f, -0.632000029f, 0.09963608f, 0.1266475f, 0.03514599f, 55.1339111f, 43.8657684f, 135.551407f, Color.magenta );

        //Children
        vela2= createPyramid("Vela2");
        configureObjectLocal(vela2, vela1,-0.28f, -0.68f, -0.6f, 0.7620897f, 1.0808f, 0.7020901f, 33.718f, -122.599f, -1011.968f ,Color.magenta );

        cilindro= GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        configureObjectLocal(cilindro, vela1,0.12f, -0.1f, 0f, 0.14552f, 1.071125f, -0.6836469f, 0f, 0f, 90f ,new Color(82f/255f, 57f/255f, 6f/255f) );

        cuerpo= GameObject.CreatePrimitive(PrimitiveType.Cube);
        configureObjectLocal(cuerpo, vela1, 1.68f, -0.02f, -0.44f, 1.096278f, 2.130411f, 2.8f, 0f, 0f, 0f ,new Color(82f/255f, 57f/255f, 6f/255f) );

        borde1= GameObject.CreatePrimitive(PrimitiveType.Cube);
        configureObjectLocal(borde1, vela1, 1.61f, -1.1f, -0.44f, 1.045093f, 0.6714199f, 2.8f, 0f, 0f, 32.521f ,new Color(82f/255f, 57f/255f, 6f/255f) );

        borde2= GameObject.CreatePrimitive(PrimitiveType.Cube);
        configureObjectLocal(borde2, vela1, 1.64f, 1.06f, -0.44f, 1.045093f, 0.6714199f, 2.8f, 0f, 0f, -32.521f ,new Color(82f/255f, 57f/255f, 6f/255f) );



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Auxiliary Methods

    void configureObjectGlobal(GameObject obj, float posx,float posy, float posz,float scalex,float  scaley,float  scalez,float  rotx,float  roty,float rotz,Color color){
        
        obj.transform.localPosition= new Vector3(posx, posy, posz);
        obj.gameObject.transform.localEulerAngles = new Vector3(rotx, roty, rotz);
        obj.gameObject.transform.localScale= new Vector3(scalex, scaley, scalez);
        obj.GetComponent<Renderer>().material.color= color;

    }
    void configureObjectLocal(GameObject obj, GameObject parent, float posx,float posy, float posz,float scalex,float  scaley,float  scalez,float  rotx,float  roty,float rotz,Color color){
        
        obj.transform.parent = parent.transform;
        obj.transform.localPosition= new Vector3(posx, posy, posz);
        obj.gameObject.transform.localEulerAngles = new Vector3(rotx, roty, rotz);
        obj.gameObject.transform.localScale= new Vector3(scalex, scaley, scalez);
        obj.GetComponent<Renderer>().material.color= color;

    }
    
    GameObject createPyramid(string name){

        GameObject obj= new GameObject(name);
        MeshRenderer meshRenderer = obj.AddComponent<MeshRenderer>();
        MeshFilter meshFilter = obj.AddComponent<MeshFilter>();
        Mesh mesh = new Mesh();

        Vector3[] vertices= new Vector3[4];
        // Pyramid base vertices
        vertices[0] = new Vector3(-1.0f, 0.0f, 0.0f);
        vertices[1] = new Vector3(0.0f, 0.0f, -1.5f);
        vertices[2] = new Vector3(1.0f, 0.0f, 0.0f);
        // Pyramid tip vertex
        vertices[3] = new Vector3(0.0f, 1.0f, -0.8f);

        mesh.vertices= vertices;

        int numTriangles = 4;
        int[] triangleIndices = new int[3 * numTriangles];

        // Botton triangle
        triangleIndices[0] = 0;
        triangleIndices[1] = 1;
        triangleIndices[2] = 2;

        // Side triangles
        triangleIndices[3] = 0;
        triangleIndices[4] = 3;
        triangleIndices[5] = 1;

        triangleIndices[6] = 1;
        triangleIndices[7] = 3;
        triangleIndices[8] = 2;

        triangleIndices[9] = 2;
        triangleIndices[10] = 3;
        triangleIndices[11] = 0;
        mesh.triangles= triangleIndices;

        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
        mesh.Optimize();

        meshFilter.mesh = mesh;

        return obj;

    }
}

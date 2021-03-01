using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    GameObject punta1;
    GameObject punta2;
    GameObject tallo;
    GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        parent= GameObject.Find("PlanetSphere");

         createTree(new Vector3(-0.0250000004f, 0.39199999f, 0.375999987f), 0.0257314425f,0.0840705633f,0.0257314425f, new Vector3(39.1254158f, 26.1396923f, 17.0739899f));
        createTree(new Vector3(0.0769999996f, 0.109999999f, 0.531000018f), 0.0256725736f,0.0838782266f,0.0256725736f, new Vector3(86.2202072f, 49.3619118f, 47.2975807f));
        createTree(new Vector3(0.175091356f, 0.065307118f, 0.481074214f), 0.0256725736f,0.0838782266f,0.0256725736f, new Vector3(66.376503f, 266.183868f, 262.739288f));
        createTree(new Vector3(-0.289578825f, 0.282831341f, 0.391160727f), 0.0256725736f,0.0838782266f,0.0256725736f, new Vector3(46.1053352f, 5.59585047f, 24.4686451f));


        createTree(new Vector3(319.964539f, 341.783966f, 44.6853867f), 0.0256725736f, 0.0838782266f, 0.0256725736f, new Vector3(319.964539f, 341.783966f, 44.6853867f));
        createTree(new Vector3(-0.00179809786f, 0.408616483f, -0.361885577f), 0.0256725736f, 0.0838782266f, 0.0256725736f, new Vector3(314.783722f, 341.260498f, 17.9491386f));
        createTree(new Vector3(0.0182975791f, 0.504256248f, 0.20637393f), 0.0256725736f, 0.0838782266f, 0.0256725736f, new Vector3(21.2570839f, 8.96197987f, 1.68746901f));



    }
    // Update is called once per frame
    void Update()
    {
        
    }
    Vector3 convertcilindricas(float r, float y, float z)
    {
        return new Vector3(r * Mathf.Sin(y) * Mathf.Cos(z), r * Mathf.Sin(y) * Mathf.Sin(z), r * Mathf.Cos(y));
    }
    //Auxiliary Methods
    void createTree(Vector3 x, float scax, float scay, float scaz, Vector3 rotx){
        //Parent-vela1
        tallo= GameObject.CreatePrimitive(PrimitiveType.Cube);
        tallo.transform.parent = parent.transform;
        configureObjectGlobal(tallo, x.x, x.y,  x.z, scax,  scay, scaz, rotx.x, rotx.y, rotx.z, new Color(164f,73f,40f,0f) );

        //Children
        punta1= createPyramid("Punta 1");
        configureObjectLocal(punta1, tallo,0f, 0.21f, 1.42f, 3.52f, 1.228723f, 3.37612f, 0f, 0f, 0f,new Color(129,178,20) );

        punta2= createPyramid("Punta 2");
        configureObjectLocal(punta2, tallo,0f, 0.66f, 1.42f, 3.52f, 1.228723f, 3.37612f, 0f, 0f, 0f,new Color(129,178,20) );


    }
    void configureObjectGlobal(GameObject obj, float posx,float posy, float posz,float scalex,float  scaley,float  scalez,float  rotx,float  roty,float rotz,Color color){
        
        obj.transform.localPosition= new Vector3(posx, posy, posz);
        obj.gameObject.transform.localEulerAngles = new Vector3(rotx, roty, rotz);
        obj.gameObject.transform.localScale= new Vector3(scalex, scaley, scalez);
        obj.GetComponent<Renderer>().material.SetColor("_Color", new Color(82f/255f, 57f/255f, 6f/255f));

    }
    void configureObjectLocal(GameObject obj, GameObject parent, float posx,float posy, float posz,float scalex,float  scaley,float  scalez,float  rotx,float  roty,float rotz,Color color){
        
        obj.transform.parent = parent.transform;
        obj.transform.localPosition= new Vector3(posx, posy, posz);
        obj.gameObject.transform.localEulerAngles = new Vector3(rotx, roty, rotz);
        obj.gameObject.transform.localScale= new Vector3(scalex, scaley, scalez);
        obj.GetComponent<Renderer>().material.SetColor("_Color", Color.green);

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

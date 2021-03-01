using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mountain : MonoBehaviour
{
    GameObject punta1;
    GameObject punta2;
    GameObject punta4;
    GameObject punta;
    GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        parent= GameObject.Find("PlanetSphere");
        createMountain(0.133660004f,0.240250006f,0.128790006f, 0.279992193f,0.327297509f,0.289074779f, 86.6180649f,251.123627f,26.15168f);
     //   createMountain(-0.116873682f,0.168851048f,-0.0765359104f, 0.310511321f,0.314424247f,0.299654901f,23.0004978f,54.8308105f,191.727463f);

        


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Auxiliary Methods
    void createMountain(float x, float y, float z, float scax, float scay, float scaz, float rotx, float roty, float rotz){
        //Parent-vela1
        punta= createPyramid("Punta 3");
        punta.transform.parent = parent.transform;
        configureObjectGlobal(punta, x, y,  z, scax,  scay, scaz, rotx, roty, rotz, new Color(192f/255f, 226f/255f, 24f/255f) );

        //Children
        punta1= createPyramid("Punta 1");
        configureObjectLocal(punta1, punta,-0.641f, -0.488f, 0.013f, 0.3535f, 1.1876f,1f, 34.318f, 38.011f, 52.495f,new Color(192f/255f, 226f/255f, 24f/255f) );

        punta2= createPyramid("Punta 2");
        configureObjectLocal(punta2, punta,0.2725756f, -0.56407f, 0.1786916f, 0.8666667f, 0.8666667f, 0.7112039f, 8.797f, 2.32f, 16.79f,new Color(192f/255f, 226f/255f, 24f/255f) );
        
        punta4= createPyramid("Punta 4");
        configureObjectLocal(punta4, punta,-0.392f, -0.266f, 0.412f, 1f, 1f, 1.0921f, 0.994f, 14.522f, -14.178f,new Color(192f/255f, 226f/255f, 24f/255f) );


    }
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

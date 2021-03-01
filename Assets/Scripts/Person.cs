using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    GameObject muslo1;
    GameObject muslo2;
    GameObject pierna1;
    GameObject pierna2;
    GameObject brazo1;
    GameObject brazo2;
    GameObject cabeza;
    GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        parent= GameObject.Find("PlanetSphere");

        
        //Parent-vela1

        muslo1= createPyramid("Muslo 1");
        muslo1.transform.parent = parent.transform;
        configureObjectGlobal(muslo1,0.0489999987f,0.470999986f,-0.370000005f, 0.0204475038f,0.0409381352f,0.0233928598f, 290.540985f,226.656006f,8.44799995f, Color.magenta );

        //Children
        muslo2= createPyramid("Muslo 2");
        configureObjectLocal(muslo2, muslo1,0f, 0f, 0f, 0.9977319f, 1.001137f, 1f, 0f, 0f, 182.73f ,Color.magenta );

        pierna1= createPyramid("Pierna 1");
        configureObjectLocal(pierna1, muslo1,0.4225895f, 1.331167f, -0.6236172f, 0.9228991f, 1.069805f, 0.9604609f, -16.553f, -24.38f, 166.161f ,Color.magenta );

        pierna2= createPyramid("Pierna 2");
        configureObjectLocal(pierna2, muslo1,0.02765689f, -0.4278232f, -1.381725f, 0.5223942f, 3.557213f, 0.9462274f, -197.797f, 19.909f, -84.29999f ,Color.magenta );

        brazo1= createPyramid("Brazo 1");
        configureObjectLocal(brazo1, muslo1,-1.496757f, 0.01619608f, 0.4729736f, 0.925332f, 2.000562f, 1.075317f, -1.002f, 48.347f, 0.916f ,Color.magenta );

        brazo2= createPyramid("Brazo 2");
        configureObjectLocal(brazo2, muslo1,-1.496757f, 0.01619608f, 0.4729736f, 0.9253317f, 2.000561f, 1.075317f, -1.002f, 48.347f, 180.916f ,Color.magenta );

        cabeza= GameObject.CreatePrimitive(PrimitiveType.Cube);
        configureObjectLocal(cabeza, muslo1, -3.083075f, 0.07206856f, 1.2852f, 0.3689898f, 0.7247849f, 0.6561308f, -0.468f, 20.994f, 91.274f ,Color.magenta );




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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    GameObject punta1;
    GameObject punta2;
    GameObject punta3;
    GameObject punta4;
    GameObject parent;

    GameObject punta12;
    GameObject punta13;
    // Start is called before the first frame update
    void Start()
    {
        parent= GameObject.Find("PlanetSphere");

        //Parent-vela1
        punta1= createPyramid("Start 1");
        punta1.transform.parent = parent.transform;
        configureObjectGlobal(punta1,0.3810751f, 0.5386152f, 0.3053086f, 0.02f, 0.02f, 0.02f, -196.268f, 200.423f, -198.715f, Color.yellow );

        createStar();

 

        punta1= createPyramid("Start 2");
        configureObjectGlobal(punta1,6f,11f,26f, 1f, 3f, 2f, 353.136108f,65.145752f,327.294952f, Color.yellow );
        createStar();
        punta12= punta1;


        punta1= createPyramid("Start 3");
        configureObjectGlobal(punta1,3f,-12f,41f, 1f, 3f, 2f, 353.136108f,65.145752f,327.294952f, Color.yellow );
        createStar();
        punta13= punta1;



        punta1 = createPyramid("Start 2");
        configureObjectGlobal(punta1, 6f, 11f, 26f, 1f, 3f, 2f, 353.136108f, 65.145752f, 327.294952f, Color.yellow);
        createStar();
        punta12 = punta1;


        punta1 = createPyramid("Start 3");
        configureObjectGlobal(punta1, 3f, -12f, 41f, 1f, 3f, 2f, 353.136108f, 65.145752f, 327.294952f, Color.yellow);
        createStar();

        punta13 = punta1; punta1 = createPyramid("Start 2");
        configureObjectGlobal(punta1, 50.7999992f, -47.2999992f, -54f, 1f, 3f, 2f, 353.136108f, 65.145752f, 327.294952f, Color.yellow);
        createStar();
        punta12 = punta1;


        punta1 = createPyramid("Start 3");
        configureObjectGlobal(punta1, 58.0999985f, -2.5f, -82.5f, 1f, 3f, 2f, 353.136108f, 65.145752f, 327.294952f, Color.yellow);
        createStar();
        punta13 = punta1;



    }
    void createStar(){
        //Children
        punta2= createPyramid("Punta 2");
        configureObjectLocal(punta2, punta1,0f, 0f, 0f, 0.3333333f, 3f, 1f, 0f, 0f, -90f,Color.yellow );

        punta3= createPyramid("Punta 3");
        configureObjectLocal(punta3, punta1,0f, 0f, 0f, 0.3333333f, 3f, 1f, 0f, 0f, 90f,Color.yellow );

        punta4= createPyramid("Punta 4");
        configureObjectLocal(punta4, punta1,0f, 0f, 0f, 1f, 1f, 1f, 0f, 0f, 180f,Color.yellow );
    }

    // Update is called once per frame
    void Update()
    {
        punta13.gameObject.transform.Rotate(0.15f, 0,0);
        punta12.gameObject.transform.Rotate(0.15f, 0,0);
    }

    //Auxiliary Methods

    void configureObjectGlobal(GameObject obj, float posx,float posy, float posz,float scalex,float  scaley,float  scalez,float  rotx,float  roty,float rotz,Color color){
        
        obj.transform.localPosition= new Vector3(posx, posy, posz);
        obj.gameObject.transform.localEulerAngles = new Vector3(rotx, roty, rotz);
        obj.gameObject.transform.localScale= new Vector3(scalex, scaley, scalez);
        obj.GetComponent<Renderer>().material.SetColor("_Color", color);

    }
    void configureObjectLocal(GameObject obj, GameObject parent, float posx,float posy, float posz,float scalex,float  scaley,float  scalez,float  rotx,float  roty,float rotz,Color color){
        
        obj.transform.parent = parent.transform;
        obj.transform.localPosition= new Vector3(posx, posy, posz);
        obj.gameObject.transform.localEulerAngles = new Vector3(rotx, roty, rotz);
        obj.gameObject.transform.localScale= new Vector3(scalex, scaley, scalez);
        obj.GetComponent<Renderer>().material.SetColor("_Color", color);

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

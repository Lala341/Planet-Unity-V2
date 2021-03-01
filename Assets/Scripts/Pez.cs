using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pez : MonoBehaviour
{
    GameObject aleta1;
    GameObject aleta2;
    GameObject cabeza;
    GameObject cuerpo;
    GameObject cuerpo2;
    GameObject cuerpo3;
    GameObject cola;
    GameObject gota1;
    GameObject gota2;
    GameObject gota3;
    GameObject gota4;
    GameObject gota5;
    GameObject gota6;
    GameObject gota7;
    GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        parent= GameObject.Find("PlanetSphere");

        //Parent-vela1
        createPez(-0.0399999991f, -0.333000004f, -0.379999995f, 90f, 90f, 0f);


    }

    // Update is called once per frame
    void Update()
    {
       cuerpo.gameObject.transform.Rotate(0.4f,0.4f,0f);
    }

    //Auxiliary Methods
    void createPez(float x, float y,float z,float rotx, float roty,float rotz){
        
//Parent-vela1
        cuerpo= createPyramid("Cuerpo");
        cuerpo.transform.parent = parent.transform;
        configureObjectGlobal(cuerpo,x,y,z, 0.00948818028f, 0.0266037751f, -0.00909025967f, rotx,roty, rotz, new  Color(145f/255f, 9f/255f, 30f/255f));

        //Children
        aleta1= createPyramid("Aleta 1");
        configureObjectLocal(aleta1, cuerpo,0.5963315f, 0.4212693f, -0.05923701f, 0.7735963f, 0.4513018f, 0.2855039f, 0f, 0f, -180f,new Color(145f/255f, 9f/255f, 30f/255f) );

        aleta2= createPyramid("Aleta 2");
        configureObjectLocal(aleta2, cuerpo,-0.7137989f, 0.2709467f, -0.09648391f, 0.7735963f, 0.4513018f, 0.2855039f, 0f, 0f, -180f,new Color(145f/255f, 9f/255f, 30f/255f) );

        cabeza= createPyramid("Cabeza");
        configureObjectLocal(cabeza, cuerpo,0f, -0.0003667882f, 0f, 1f, 0.7625f, 1f, 0f, 0f, -180f,new  Color(145f/255f, 9f/255f, 30f/255f) );

        cola= createPyramid("Cola");
        configureObjectLocal(cola, cuerpo,0f, 1.114219f, -0.2297527f, 0.8941346f, 0.8228865f, 0.6931894f, 0f, 0f, -180f,new Color(145f/255f, 9f/255f, 30f/255f) );

        gota1= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota1, cuerpo,-0.3201394f, 1.796169f, 1.324456f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f, new Color(0f/255f,  158f/255f, 148f/255f) );

        gota2= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota2, cuerpo,0.2254388f, 1.455194f, -0.6245536f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f,new Color(0f/255f,  158f/255f, 148f/255f) );

        gota3= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota3, cuerpo,-0.4189023f, 1.312204f, 1.339122f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f,new Color(0f/255f,  158f/255f, 148f/255f) );

        gota4= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota4, cuerpo,-2.10446f, 1.271874f, 1.589417f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f,new Color(0f/255f,  158f/255f, 148f/255f) );

        gota5= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota5, cuerpo,-1.518466f, 136217f, 1.5024f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f,new Color(0f/255f,  158f/255f, 148f/255f) );

        gota6= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota6, cuerpo,-0.84687f, -0.6603188f, 0.332325f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f,new Color(0f/255f,  158f/255f, 148f/255f) );

        gota7= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota7, cuerpo,-1.406534f, 1.78517f, 1.485779f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f,new Color(0f/255f,  158f/255f, 148f/255f) );

    }
    void createPezc2(float x, float y,float z,float rotx, float roty,float rotz){
        
//Parent-vela1
        cuerpo2= createPyramid("Cuerpo");
        cuerpo2.transform.parent = parent.transform;
        configureObjectGlobal(cuerpo2,x,y,z, 0.00948818f, 0.03352079f, -0.00909026f, rotx,roty, rotz, new  Color(145f/255f, 9f/255f, 30f/255f));

        //Children
        aleta1= createPyramid("Aleta 1");
        configureObjectLocal(aleta1, cuerpo2,0.5963315f, 0.4212693f, -0.05923701f, 0.7735963f, 0.4513018f, 0.2855039f, 0f, 0f, -180f,new Color(145f/255f, 9f/255f, 30f/255f) );

        aleta2= createPyramid("Aleta 2");
        configureObjectLocal(aleta2, cuerpo2,-0.7137989f, 0.2709467f, -0.09648391f, 0.7735963f, 0.4513018f, 0.2855039f, 0f, 0f, -180f,new Color(145f/255f, 9f/255f, 30f/255f) );

        cabeza= createPyramid("Cabeza");
        configureObjectLocal(cabeza, cuerpo2,0f, -0.0003667882f, 0f, 1f, 0.7625f, 1f, 0f, 0f, -180f,new  Color(145f/255f, 9f/255f, 30f/255f) );

        cola= createPyramid("Cola");
        configureObjectLocal(cola, cuerpo2,0f, 1.114219f, -0.2297527f, 0.8941346f, 0.8228865f, 0.6931894f, 0f, 0f, -180f,new Color(145f/255f, 9f/255f, 30f/255f) );

        gota1= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota1, cuerpo2,-0.3201394f, 1.796169f, 1.324456f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f, new Color(0f/255f,  158f/255f, 148f/255f) );

        gota2= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota2, cuerpo2,0.2254388f, 1.455194f, -0.6245536f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f,new Color(0f/255f,  158f/255f, 148f/255f) );

        gota3= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota3, cuerpo2,-0.4189023f, 1.312204f, 1.339122f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f,new Color(0f/255f,  158f/255f, 148f/255f) );

        gota4= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota4, cuerpo2,-2.10446f, 1.271874f, 1.589417f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f,new Color(0f/255f,  158f/255f, 148f/255f) );

        gota5= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota5, cuerpo2,-1.518466f, 136217f, 1.5024f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f,new Color(0f/255f,  158f/255f, 148f/255f) );

        gota6= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota6, cuerpo2,-0.84687f, -0.6603188f, 0.332325f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f,new Color(0f/255f,  158f/255f, 148f/255f) );

        gota7= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota7, cuerpo2,-1.406534f, 1.78517f, 1.485779f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f,new Color(0f/255f,  158f/255f, 148f/255f) );

    }
    void createPezc3(float x, float y,float z,float rotx, float roty,float rotz){
        
//Parent-vela1
        cuerpo3= createPyramid("Cuerpo");
        cuerpo3.transform.parent = parent.transform;
        configureObjectGlobal(cuerpo3,x,y,z, 0.00948818f, 0.03352079f, -0.00909026f, rotx,roty, rotz, new  Color(145f/255f, 9f/255f, 30f/255f));

        //Children
        aleta1= createPyramid("Aleta 1");
        configureObjectLocal(aleta1, cuerpo3,0.5963315f, 0.4212693f, -0.05923701f, 0.7735963f, 0.4513018f, 0.2855039f, 0f, 0f, -180f,new Color(145f/255f, 9f/255f, 30f/255f) );

        aleta2= createPyramid("Aleta 2");
        configureObjectLocal(aleta2, cuerpo3,-0.7137989f, 0.2709467f, -0.09648391f, 0.7735963f, 0.4513018f, 0.2855039f, 0f, 0f, -180f,new Color(145f/255f, 9f/255f, 30f/255f) );

        cabeza= createPyramid("Cabeza");
        configureObjectLocal(cabeza, cuerpo3,0f, -0.0003667882f, 0f, 1f, 0.7625f, 1f, 0f, 0f, -180f,new  Color(145f/255f, 9f/255f, 30f/255f) );

        cola= createPyramid("Cola");
        configureObjectLocal(cola, cuerpo3,0f, 1.114219f, -0.2297527f, 0.8941346f, 0.8228865f, 0.6931894f, 0f, 0f, -180f,new Color(145f/255f, 9f/255f, 30f/255f) );

        gota1= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota1, cuerpo3,-0.3201394f, 1.796169f, 1.324456f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f, new Color(0f/255f,  158f/255f, 148f/255f) );

        gota2= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota2, cuerpo3,0.2254388f, 1.455194f, -0.6245536f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f,new Color(0f/255f,  158f/255f, 148f/255f) );

        gota3= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota3, cuerpo3,-0.4189023f, 1.312204f, 1.339122f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f,new Color(0f/255f,  158f/255f, 148f/255f) );

        gota4= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota4, cuerpo3,-2.10446f, 1.271874f, 1.589417f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f,new Color(0f/255f,  158f/255f, 148f/255f) );

        gota5= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota5, cuerpo3,-1.518466f, 136217f, 1.5024f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f,new Color(0f/255f,  158f/255f, 148f/255f) );

        gota6= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota6, cuerpo3,-0.84687f, -0.6603188f, 0.332325f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f,new Color(0f/255f,  158f/255f, 148f/255f) );

        gota7= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(gota7, cuerpo3,-1.406534f, 1.78517f, 1.485779f,0.2212415f, 0.4016652f, -0.4069269f, 0f, 8.334f,-90f,new Color(0f/255f,  158f/255f, 148f/255f) );

    }
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

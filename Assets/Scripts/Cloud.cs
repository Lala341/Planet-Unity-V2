using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    GameObject cloud1;
    GameObject cloud2;
    GameObject cloud3;
    GameObject cloud4;
    GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        parent= GameObject.Find("PlanetSphere");

        
        
        //Parent-vela1
        cloud1= GameObject.CreatePrimitive(PrimitiveType.Capsule);
        cloud1.transform.parent = parent.transform;
        configureObjectGlobal(cloud1, -0.781000018f, 0.603999972f, -0.321999997f, 0.065431f, 0.065431f, 0.065431f, 2.3662641f, 73.684227f, 181.384933f, new Color(1,1,1 ));

        //Children
        cloud2= GameObject.CreatePrimitive(PrimitiveType.Capsule);
        configureObjectLocal(cloud2, cloud1,-0.47f, -0.38f, -0.38f, 1f, 1f, 1f, 0f, -1.44f, -0.69f,new Color(1,1,1) );

        cloud3= GameObject.CreatePrimitive(PrimitiveType.Capsule);
        configureObjectLocal(cloud3, cloud1,-0.25f,-0.870000005f,-0.870000005f, 1f, 1f, 1f, 0.429998398f,359.5f,359.279999f,new Color(1,1,1) );


cloud4= GameObject.CreatePrimitive(PrimitiveType.Capsule);
        configureObjectLocal(cloud4, cloud1,-0.25999999f,-0.879999995f,0.0799999982f, 1f, 1f, 1f, 0.429998398f,359.5f,359.279999f,new Color(1,1,1) );


       



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
}

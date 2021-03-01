using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetSphere : MonoBehaviour
{
    GameObject planet;
    GameObject camera;
    GameObject terrain;
    GameObject person;

    public Slider mainSlider;
    public Slider slider2;
    public Slider slider3;
    public Slider slider4;
    public float advance;

    public float advanceI;

    //Invoked when a submit button is clicked.
    public void SubmitSliderSetting()
    {
        //Displays the value of the slider in the console.
        //Debug.Log(mainSlider.value);
        planet.transform.position = new Vector3(planet.transform.position.x, mainSlider.value * 3, planet.transform.position.z);
        planet.GetComponent<Renderer>().material.SetColor("_Color", new Color(slider2.value, slider3.value, slider4.value));



    }



    // Start is called before the first frame update
    void Start()
    {
        //mainSlider = GameObject.Find("Slider").GetComponent<Slider>();
        //slider2 = GameObject.Find("Slider2").GetComponent<Slider>();
        //slider3 = GameObject.Find("Slider3").GetComponent<Slider>();
        //slider4 = GameObject.Find("Slider4").GetComponent<Slider>();


        //Parent-vela1
        //Se llama el objeto global para asociar a los hijos.
        planet = GameObject.Find("PlanetSphere");
        planet.transform.Rotate(0f, 35.8909874f, 347.497009f);

        person = GameObject.Find("nina");



        //Se crean los objetos.
        configureObjectGlobal(planet,32.64943f, -0.7301698f, -6.200824f, 50.96099f, 50.96099f, 50.96099f, 247.725f, 31.808f, 13.845f, new Color(0f/255f,  158f/255f, 148f/255f) );
        camera= GameObject.Find("Main Camera");
        camera.transform.position= new Vector3(111f,76.7999992f,98.5999985f);
        camera.gameObject.transform.localEulerAngles = new Vector3(22.245f, -142.898f,0f);

        terrain= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        configureObjectLocal(terrain,planet,0f, 0.02f,0f, 1f, 1.001f, 1f, 0f, 0f, 0f, Color.green );



        advance = 0;
        advanceI = 0;
      
    }
    Vector3 convertcilindricas(float r, float y, float z)
    {
        return new Vector3(r * Mathf.Sin(y) * Mathf.Cos(z), r * Mathf.Sin(y) * Mathf.Sin(z), r * Mathf.Cos(y));
    }
    // Update is called once per frame
    void Update()
    {
        advanceI = advanceI + 0.0001f;
        if (advance < 245) { 
        if (advance  < 100f)
        {
            if (advanceI <= 50f)
            {
                camera.transform.position = new Vector3(camera.transform.position.x - advanceI, camera.transform.position.y - advanceI, camera.transform.position.z-advanceI);

            }
        }
        if (advance  >= 100f && advance<155f)
        {
            camera.transform.position = new Vector3(41f, 20.7999992f, 20.6000004f);
            camera.gameObject.transform.localEulerAngles = new Vector3(-12.245f, -162.898f, 0.1f);
        }
        if (advance >= 155f )
        {
            camera.transform.position = new Vector3(28.9000015f, 26.7000008f, -9.5999992f);
            camera.gameObject.transform.localEulerAngles = new Vector3(8.6546726f, 40f, 355.492676f);
        }
        advance = advance + 0.1f;
        planet.gameObject.transform.Rotate(0.1f, 0, 0);

            //person.transform.position = convertcilindricas(0.0256725736f, 0f, advanceI);

             }

        //SubmitSliderSetting();
    }

    //Auxiliary Methods

    void configureObjectGlobal(GameObject obj, float posx,float posy, float posz,float scalex,float  scaley,float  scalez,float  rotx,float  roty,float rotz,Color color){
        
        obj.transform.position= new Vector3(posx, posy, posz);
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
}

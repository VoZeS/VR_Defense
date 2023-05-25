using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRealease;
    //GameObject presser;
    //AudioSource sound;
    bool isPressed;

    // Start is called before the first frame update
    void Start()
    {
        //sound = GetComponent<AudioSource>();
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!isPressed)
        {
            gameObject.transform.localPosition = new Vector3(1.304f, 1.4f, 0.647f);
            onPress.Invoke();
            //sound.Play();
            isPressed = true;
            Debug.Log("Touched");
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
        
    //        gameObject.transform.localPosition = new Vector3(1.304f, 1.441f, 0.647f);
    //        onRealease.Invoke();
    //        isPressed = false;
    //}

    public void SpawnSphere()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(1.8f, 1.8f, 1.8f);
        sphere.transform.localPosition = new Vector3(1.8f, 1.8f, 1.8f);
        sphere.AddComponent<Rigidbody>();
    }
}

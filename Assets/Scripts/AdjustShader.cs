using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustShader : MonoBehaviour
{
    public Slider slider;

    public GameObject testShader;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        testShader = GameObject.FindWithTag("TestTag");
        
        // Sets the Diffuse Transition value in the transition shader to the slider's value
        testShader.GetComponent<MeshRenderer>().material.SetFloat("Vector1_7C3BE659", slider.value);
        
        Debug.Log(slider.value);
    }
}

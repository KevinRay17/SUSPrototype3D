using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
/// </summary>
public class MaterialManager : MonoBehaviour
{
    public GameObject heldMaterial;

    public Material defaultMat;

    private Material oldMat;

    private Renderer heldMaterialRenderer;

    private Renderer thisRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        // Gets the MeshRenderer from the heldMaterial gameObject
        heldMaterialRenderer = heldMaterial.GetComponent<MeshRenderer>();

        thisRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Q))
        {
            heldMaterialRenderer.material = oldMat;
        }
        */
    }
    
    void OnMouseOver()
    {
        // Deals with taking materials from an object, makes sure that the object doesn't
        // have a blank material
        if (Input.GetMouseButtonDown(0))
        {
            if (tag != "Blank")
            {
                // Sets heldMaterial to the material of the gameObject
                heldMaterialRenderer.material = thisRenderer.material;

                // GameObject's material is stored in oldMat
                oldMat = thisRenderer.material;
                
                // Sets the gameObject's material to the default material
                thisRenderer.material = defaultMat;
               
                // Sets heldMaterial tag to the current object's tag
                heldMaterial.tag = this.tag;

                // Current object's tag is set to blank
                this.tag = "Blank";
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            // Opposite of GetMouseButtonDown(0) sets the gameObject's material to the heldMaterial's material
            thisRenderer.material = heldMaterialRenderer.material;
            
            // Sets heldMaterial to the default material
            heldMaterialRenderer.material = defaultMat;

            this.tag = heldMaterial.tag;

            heldMaterial.tag = "Blank";
        }
    }
}

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

    private Renderer heldMaterialRenderer;

    private Renderer thisRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        // Gets the MeshRenderer from the heldMaterial gameObject
        heldMaterialRenderer = heldMaterial.GetComponent<MeshRenderer>();

        thisRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (tag != "Blank")
            {
                heldMaterialRenderer.material = thisRenderer.material;

                thisRenderer.material = defaultMat;

                // Sets heldMaterial tag to the current object's tag
                heldMaterial.tag = this.tag;

                // Current object's tag is set to blank
                this.tag = "Blank";
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            thisRenderer.material = heldMaterialRenderer.material;
            
            heldMaterialRenderer.material = defaultMat;

            this.tag = heldMaterial.tag;

            heldMaterial.tag = "Blank";
        }
    }
}

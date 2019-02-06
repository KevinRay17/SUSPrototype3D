using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
/// </summary>
public class Material : MonoBehaviour
{
    public GameObject heldMaterial;

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
            heldMaterialRenderer.material = thisRenderer.material;
        }

        if (Input.GetMouseButtonDown(1))
        {
            thisRenderer.material = heldMaterialRenderer.material;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Description manager script, attached to any gameObject that needs a descriptive tag for the player.
/// GameObjects are assigned in the inspector (temp), will be automatic eventually
/// </summary>
public class Description : MonoBehaviour
{
    // Description prefab, contains UI image and UI text objects
    public GameObject descriptorPrefab;

    // Main camera in the scene
    public Transform camera;

    public Canvas canvas;
    
    // Offset so the descriptor appears above the gameObject, editable in the inspector
    public float yOffset;

    // The instantiated descriptor, NOT the prefab
    // Declared private for accessibility
    private GameObject descriptor;
    
    // The UI text, child to the descriptor prefab
    private Text name;

    private void OnMouseEnter()
    {
        // Instantiates the descriptor prefab
        descriptor = Instantiate(descriptorPrefab);

        // Sets its parent to the canvas so it can be displayed correctly (since it's a UI object)
        descriptor.transform.parent = canvas.transform;
        
        // Transform.position equal to the current gameObject's position
        descriptor.transform.position = new Vector3(transform.position.x, transform.position.y + yOffset, transform.position.z);
        
        // Looks at the main camera (Smile!)
        descriptor.transform.LookAt(camera);

        EditName();
    }

    private void OnMouseExit()
    {
        Destroy(descriptor);
    }

    // Sets the UI text of the descriptor to the tag of the gameObject this script is attached to
    void EditName()
    {
        name = descriptor.GetComponentInChildren<Text>();

        name.text = tag;
    }
}

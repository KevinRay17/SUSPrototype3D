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
    
    // The UI 
    private Text name;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        descriptor = Instantiate(descriptorPrefab);

        descriptor.transform.parent = canvas.transform;
        
        descriptor.transform.position = new Vector3(transform.position.x, transform.position.y + yOffset, transform.position.z);
        
        descriptor.transform.LookAt(camera);

        EditName();
    }

    private void OnMouseExit()
    {
        Destroy(descriptor);
    }

    void EditName()
    {
        name = descriptor.GetComponentInChildren<Text>();

        name.text = tag;
    }
}

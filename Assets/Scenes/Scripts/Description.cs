using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Description : MonoBehaviour
{
    public GameObject descriptorPrefab;

    public Transform camera;

    public Canvas canvas;
    
    public float yOffset;

    private GameObject descriptor;
    
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

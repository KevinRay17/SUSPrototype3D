using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MaterialProperties : MonoBehaviour
{
    //Put this script on every interactable object in the game.
    //Get the rigidbody of the object
    private Rigidbody ObjRB;

    //List of strings that tell us what tags to access
    private List<string> AcceptableMats = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        //Get reference to rigidbody
        ObjRB = GetComponent<Rigidbody>();

        //Make new line when adding new material
        AcceptableMats.Add("Metal");
        AcceptableMats.Add("Wood");
    }

    // Update is called once per frame
    void Update()
    {
        //Check if the object has a material
        if (gameObject.CompareTag("AcceptableMats"))
        {
            //Unlock constraints on object
            ObjRB.constraints = RigidbodyConstraints.None;
            
            //Check each tag and change the properties of the object accordingly
            if (gameObject.CompareTag("Wood"))
            {
                ObjRB.mass = .25f;
            }
            else if(gameObject.CompareTag("Metal"))
            {
                ObjRB.mass = 100f;
            }
        }
        else
        {
            //If the object has no material, freeze the position and rotation
            ObjRB.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}

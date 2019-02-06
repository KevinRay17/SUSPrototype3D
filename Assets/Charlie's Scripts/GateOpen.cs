using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpen : MonoBehaviour
{
    // its currently class number 4, connor has given me a severe amount of fug and shid
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if you press the space bar, the "gate" object will delete itself
        //The last thing you want to find in your code is poor commenting, but sometimes what you want is not always what you get
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}

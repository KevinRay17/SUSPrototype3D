using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadDescription()
    {
        SceneManager.LoadScene(1);
    }
    
    public void LoadMaterial()
    {
        SceneManager.LoadScene(0);
    }
}

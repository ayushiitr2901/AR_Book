using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_scene_load : MonoBehaviour
{
    // Start is called before the first frame update
    public void Load_Scene(string Scene_name)
    {
        SceneManager.LoadScene(Scene_name);
    }

    // Update is called once per frame
    
}

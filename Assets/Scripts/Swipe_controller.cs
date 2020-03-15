using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Swipe_controller : MonoBehaviour
{
    public string Scene_after_left_swipe;
    public string Scene_after_right_swipe;
    float touchStart = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            touchStart = Input.mousePosition.x;
        }

        if(Input.GetMouseButtonUp(0))
        {
            float Delta = Input.mousePosition.x - touchStart;
            if(Delta < -100f)
            {
                SceneManager.LoadScene(Scene_after_left_swipe);
            }

            if(Delta > 100f)
            {
                SceneManager.LoadScene(Scene_after_right_swipe);
            }
        }
    }
}

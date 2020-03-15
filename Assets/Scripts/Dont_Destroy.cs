using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Dont_Destroy : MonoBehaviour
{


    public float Scene_at_destroying;
    public float Scene_lowerlimit;
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Back_music");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);



        GameObject[] obj = GameObject.FindGameObjectsWithTag("Game_Back_Music");
        if (obj.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);



    }
    void Update()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Back_music");
        if (SceneManager.GetActiveScene().buildIndex > Scene_at_destroying || SceneManager.GetActiveScene().buildIndex < Scene_lowerlimit)
        {
            Destroy(this.gameObject);
        }




        GameObject[] obj = GameObject.FindGameObjectsWithTag("Game_Back_Music");
        if (SceneManager.GetActiveScene().buildIndex > Scene_at_destroying || SceneManager.GetActiveScene().buildIndex < Scene_lowerlimit)
        {
            Destroy(this.gameObject);
        }
    }

   
}

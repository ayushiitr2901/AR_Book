using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Scene_after_loading : MonoBehaviour
{
    public float delay;
    public int Scene_number;
    // Start is called before the first frame update
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        StartCoroutine(Load_next_scene(delay));
    }

   
    IEnumerator Load_next_scene(float delayed)
    {

        yield return new WaitForSeconds(delayed);
        SceneManager.LoadScene(Scene_number);
    }
}

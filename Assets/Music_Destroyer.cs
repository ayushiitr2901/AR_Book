using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Back_music");

        Destroy(this.gameObject);


    }
}

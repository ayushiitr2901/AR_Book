using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WritingSound_Destroyer : MonoBehaviour
{
    public float writing_time;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroySound());
    }

    IEnumerator DestroySound()
    {
        
        yield return new WaitForSeconds(writing_time);
        Destroy(this.gameObject);
    }
}

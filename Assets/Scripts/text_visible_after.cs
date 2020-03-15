using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_visible_after : MonoBehaviour
{
    // Start is called before the first frame update

    public float delay;
    public float AlphaLevel = 0f;

    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        StartCoroutine(ShowText(delay));
    }
    private void Update()
    {
        if (gameObject.GetComponent<MeshRenderer>().enabled && AlphaLevel<=5f)
            AlphaLevel += 0.05f;


            GetComponent<TextMesh>().color = new Color(0, 0, 0, AlphaLevel);
    }


    // Update is called once per frame
    IEnumerator ShowText(float delayed)
    {

        yield return new WaitForSeconds(delayed);
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }
}

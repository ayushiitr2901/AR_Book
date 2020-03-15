using UnityEngine;
using UnityEngine.SceneManagement;
public class Changer : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;

    private int nextpage;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fade_to_next_page();
        }
    }

    public void fade_to_next_page()
    {
        fade_to_page(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void fade_to_page(int pageno)
    {
        nextpage = pageno;
        animator.SetTrigger("FadeOut");
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(nextpage);
    }
}

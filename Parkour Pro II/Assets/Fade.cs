using UnityEngine;

public class Fade : MonoBehaviour
{
    public Animator anim;

    // Update is called once per frame
    public void FadeOut()
    {
        anim.SetTrigger("FadeOut");
    }
}

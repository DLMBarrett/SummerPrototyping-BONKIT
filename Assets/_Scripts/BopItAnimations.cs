using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BopItAnimations : MonoBehaviour
{

    private Animator bAnimator;
    private bool Pulled;
    private bool Twisted;

    // Start is called before the first frame update
    void Start()
    {
        bAnimator = GetComponent<Animator>();
        bAnimator.SetBool("Pulled", false);
        bAnimator.SetBool("Twisted", false);
    }

    public void playPullAnimation()
    {
        bAnimator.SetBool("Pulled", true);
    }

    public void stopPullAnimation()
    {
        bAnimator.SetBool("Pulled", false);
    }

    public void playTwistAnimation()
    {
        bAnimator.SetBool("Twisted", true);
    }

    public void stopTwistAnimation()
    {
        bAnimator.SetBool("Twisted", false);
    }

}

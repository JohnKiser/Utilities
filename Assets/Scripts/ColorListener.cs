using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorListener : MonoBehaviour {

    Animator anim;

    // Use this for initialization
    void Start()
    {

        anim = GetComponent<Animator>();

        ListenForButton.delegateMethodToBeDefined += MagicAnimation;
    }

    public void MagicAnimation()
    {
        anim.SetBool("MAGIC", true);
        ListenForButton.delegateMethodToBeDefined -= MagicAnimation;
        ListenForButton.delegateMethodToBeDefined += StopMagicAnimation;
    }

    public void StopMagicAnimation()
    {
        anim.SetBool("MAGIC", false);
        ListenForButton.delegateMethodToBeDefined -= StopMagicAnimation;
        ListenForButton.delegateMethodToBeDefined += MagicAnimation;
    }

}

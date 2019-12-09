using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateListener : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();

        ListenForButton.delegateMethodToBeDefined += DoRiseAnimation;
	}
	
	public void DoRiseAnimation()
    {
        anim.SetBool("IsFalling", false);
        ListenForButton.delegateMethodToBeDefined -= DoRiseAnimation;
        ListenForButton.delegateMethodToBeDefined += StopRiseAnimation;
    }

    public void StopRiseAnimation()
    {
        anim.SetBool("IsFalling", true);
        ListenForButton.delegateMethodToBeDefined += DoRiseAnimation;
        ListenForButton.delegateMethodToBeDefined -= StopRiseAnimation;
    }
}


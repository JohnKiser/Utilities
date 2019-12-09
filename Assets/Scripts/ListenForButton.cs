using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenForButton : MonoBehaviour {

    public delegate void ButtonWasPressed();
    public static event ButtonWasPressed delegateMethodToBeDefined;

    public void SendDelegateToBeDefined()
    {
        delegateMethodToBeDefined();
    }
}

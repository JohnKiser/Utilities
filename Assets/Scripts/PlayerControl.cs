using UnityEngine;
using UnityEngine.Networking;

public class PlayerControl : NetworkBehaviour
{
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        float x = .15f;

        if (Input.GetKey("d"))
        {
            transform.Translate(x, 0, 0);

            transform.rotation = Quaternion.Euler(0, 0, 0);
            
        }

        else if (Input.GetKey("a"))
        {
            transform.Translate(x, 0, 0);

            transform.rotation = Quaternion.Euler(0, 180, 0);          

        }

        else if (Input.GetKey("w"))
        {
            transform.Translate(x, 0, 0);

            transform.rotation = Quaternion.Euler(0, -90, 0);            

        }

        else if (Input.GetKey("s"))
        {
            transform.Translate(x, 0, 0);

            transform.rotation = Quaternion.Euler(0, 90, 0);
            
        }        

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.GetComponent<PlayerControl>() != null)
        {

        }
    }

}
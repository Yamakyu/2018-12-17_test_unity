using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contact : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        AkSoundEngine.PostEvent("tatoe", gameObject);
        Debug.Log("event envoyé");
    }
}

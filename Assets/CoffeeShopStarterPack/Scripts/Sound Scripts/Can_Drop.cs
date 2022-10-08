using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Can_Drop : MonoBehaviour
{
    AudioSource can_sound;

    // Start is called before the first frame update
    void Start()
    {
        can_sound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // foreach (ContactPoint contact in collision.contacts)
        // {
        //     Debug.DrawRay(contact.point, contact.normal, Color.white);
        // }
        // if (collision.relativeVelocity.magnitude > 2) can_sound.Play();
        can_sound.Play();
    }
}

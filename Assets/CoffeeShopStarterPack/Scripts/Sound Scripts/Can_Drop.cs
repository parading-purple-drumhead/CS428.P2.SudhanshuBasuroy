// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Can_Drop : MonoBehaviour
// {
//     public AudioSource can_sound;

//     // Start is called before the first frame update
//     void Start()
//     {
//         can_sound = GetComponent<AudioSource>();
//     }

//     void OnCollisionEnter(Collision collision)
//     {
//         // foreach (ContactPoint contact in collision.contacts)
//         // {
//         //     Debug.DrawRay(contact.point, contact.normal, Color.white);
//         // }
//         // if (collision.relativeVelocity.magnitude > 2) can_sound.Play();
//         Debug.Log($"{gameObject.name} is colliding with {collision.collider.name}");
//         if(!can_sound.isPlaying){
//             can_sound.Play();
//         }
//     }
// }

using UnityEngine;
using Zinnia.Tracking.Collision;

public class Can_Drop : MonoBehaviour
{
    public AudioSource can_sound;
    void Start()
    {
        can_sound = GetComponent<AudioSource>(); 
    }
    public void Bounce(CollisionNotifier.EventData data)
    {
        Debug.Log("Colllision Detected");
        if(!can_sound.isPlaying)
        {
            can_sound.Play();
        }
    }
}
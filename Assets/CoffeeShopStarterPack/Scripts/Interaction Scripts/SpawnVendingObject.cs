using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Tracking.Collision;

public class SpawnVendingObject : MonoBehaviour
{
    public AudioSource vending_sound;
    public GameObject prefab;
    public Vector3 spawnPosition;
    void Start()
    {
        // Debug.Log("Item Touched!!!!");s
    }

    public void button_pressed(CollisionNotifier.EventData data)
    {
        
        if(!vending_sound.isPlaying)
        {
            vending_sound.Play ();
            StartCoroutine(process_item());
            // Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
        
    }
    public IEnumerator process_item()
    {
        yield return new WaitWhile (()=> vending_sound.isPlaying);
        Instantiate(prefab, spawnPosition, Quaternion.identity);
        
     }

}

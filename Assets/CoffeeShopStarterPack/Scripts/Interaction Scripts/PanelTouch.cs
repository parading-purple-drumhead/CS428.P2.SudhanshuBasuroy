using UnityEngine;
using Zinnia.Tracking.Collision;

public class PanelTouch : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource panel_sound;
    public bool generating_bill;
    void Start()
    {
        // Debug.Log("Item Touched!!!!");s
    }

    // Update is called once per frame
    public void panel_collision(CollisionNotifier.EventData data)
    {
        Debug.Log("Panel Touched!!!!");
        if(!panel_sound.isPlaying)
        {
            panel_sound.Play();
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    private AudioSource audio;
    public AudioClip music;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.clip = this.music;

        if(collision.collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("music");
            //this.audio.Play();
        }
    }
}

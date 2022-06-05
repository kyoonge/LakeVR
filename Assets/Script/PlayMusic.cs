using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class PlayMusic : MonoBehaviour

{

    public AudioSource sound;

    public AudioClip music, check;



    private void Start()

    {

        sound = this.GetComponent<AudioSource>();

    }



    private void OnTriggerEnter(Collider collision)

    {

        if (collision.gameObject.CompareTag("Player"))

        {





            if (sound.isPlaying)

            {

                sound.Stop();

                Debug.Log("stop");

                sound.clip = check;

                sound.Play();

            }

            else

            {

                sound.clip = music;

                sound.Play();

                Debug.Log("music");



            }



        }

    }





}
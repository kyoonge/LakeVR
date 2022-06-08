using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;



public class PlayMusic : MonoBehaviour

{

    public AudioSource sound;

    public AudioClip music, check;
    public bool playing;
    public Text textState;


    private void Start()

    {

        sound = this.GetComponent<AudioSource>();
        textState = GameObject.Find("Text").GetComponent<Text>();


    }



    private void OnTriggerEnter(Collider collision)

    {

        InputDevice deviceRight = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
        InputDevice deviceLeft = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        HapticCapabilities capabilities;


        if (collision.gameObject.CompareTag("Right"))

        {

            if (deviceRight.TryGetHapticCapabilities(out capabilities))
            {
                if(capabilities.supportsImpulse)
                {
                    deviceRight.SendHapticImpulse(0, 0.5f, 0.3f);
                }
            }


            PlayRadio();
        }


        if (collision.gameObject.CompareTag("Left"))

        {

            if (deviceLeft.TryGetHapticCapabilities(out capabilities))
            {
                if (capabilities.supportsImpulse)
                {
                    deviceLeft.SendHapticImpulse(0, 0.5f, 0.3f);
                }
            }

            PlayRadio();

        }



    }

    void PlayRadio()
    {
        if (sound.isPlaying && !playing)
        {
            sound.Stop();
            Debug.Log("stop");
            sound.clip = check;
            sound.Play();
            //textState.text = collision.gameObject.name;
        }
        else
        {
            playing = true;
            sound.clip = music;
            sound.Play();
            Invoke("ChangeState", 1f);
            Debug.Log("music");
            //textState.text = collision.gameObject.name;
        }
    }


    void ChangeState()
    {
        playing = false;

    }

}
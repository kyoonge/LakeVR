using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;

public class BroomManager : MonoBehaviour
{
    public AudioSource getTrashSound;
    public bool right;
    public Text textState;

    // Start is called before the first frame update
    void Start()
    {
        getTrashSound = this.GetComponent<AudioSource>();
        textState = GameObject.Find("Text").GetComponent<Text>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //        this.audio = this.gameObject.AddComponent<AudioSource>();
        //        this.audio.clip = this.music;
        InputDevice deviceRight = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
        InputDevice deviceLeft = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        HapticCapabilities capabilities;

        if (collision.collider.gameObject.CompareTag("Trash"))
        {
            //canSound.Play();
            Destroy(collision.collider.gameObject, 1f);
            getTrashSound.Play();
            Debug.Log(collision.collider.gameObject.name);
            //textState.text = collision.gameObject.tag;


            if (GameObject.Find("CustomHandRight").GetComponent<RightHand>().check)
            {
                if (deviceRight.TryGetHapticCapabilities(out capabilities))
                {
                    if (capabilities.supportsImpulse)
                    {
                        deviceRight.SendHapticImpulse(0, 0.5f, 0.3f);
                    }
                }
            }

            if (GameObject.Find("CustomHandLeft").GetComponent<LeftHand>().check)
            {
                if (deviceLeft.TryGetHapticCapabilities(out capabilities))
                {
                    if (capabilities.supportsImpulse)
                    {
                        deviceLeft.SendHapticImpulse(0, 0.5f, 0.3f);
                    }
                }

            }

        }

       
    }

}
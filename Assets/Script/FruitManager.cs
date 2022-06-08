using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class FruitManager : MonoBehaviour
{
    public AudioSource GetFruit;
    public bool Get;

    private void Start()
    {
        GetFruit = this.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        InputDevice deviceRight = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
        InputDevice deviceLeft = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        HapticCapabilities capabilities;

        if (collision.gameObject.CompareTag("Right"))

        {
            if (!Get)
            {
                GetFruit.Play();
                Get = true;
                if (deviceRight.TryGetHapticCapabilities(out capabilities))
                {
                    if (capabilities.supportsImpulse)
                    {
                        deviceRight.SendHapticImpulse(0, 0.5f, 0.6f);
                    }
                }
            }


        }

        if (collision.gameObject.CompareTag("Left"))

        {
            if (!Get)
            {
                GetFruit.Play();
                Get = true;
                if (deviceLeft.TryGetHapticCapabilities(out capabilities))
                {
                    if (capabilities.supportsImpulse)
                    {
                        deviceLeft.SendHapticImpulse(0, 0.5f, 0.6f);
                    }
                }
            }


        }

    }


}

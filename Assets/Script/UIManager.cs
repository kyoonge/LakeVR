using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //InputDevice deviceRight = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
    //InputDevice deviceLeft = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
    public Text UIText;
    public GameObject Image;

    public bool show = false; // used to display button state in the Unity Inspector window

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One) )
        {
            
            if (!show)
            {
                Image.SetActive(true);
                show = true;
            }
            else
            {

                Image.SetActive(false);
                show = false;
                
            }
        }

       
    }
}

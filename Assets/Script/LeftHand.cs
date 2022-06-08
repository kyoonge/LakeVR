using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHand : MonoBehaviour
{
    public bool check;

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Broom"))
        {
            check = true;
        }
    }
    private void OnTriggerExit(Collider collision)
    {

        if (collision.gameObject.CompareTag("Broom"))
        {
            check = false;
        }
    }
}

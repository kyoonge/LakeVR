using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        if (collision.gameObject.CompareTag("Player"))

        {
            if (!Get)
            {
                GetFruit.Play();
                Get = true;
            }


        }

    }


}

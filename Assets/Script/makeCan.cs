using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeCan : MonoBehaviour
{
    public GameObject applecan, avocadocan;
    public GameObject effect;
    public AudioSource canSound;
    public bool fruit;

    // Start is called before the first frame update
    void Start()
    {
        canSound = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        //        this.audio = this.gameObject.AddComponent<AudioSource>();
        //        this.audio.clip = this.music;

        if (collision.collider.gameObject.CompareTag("Apple") && fruit )
        {
            fruit = false;
            //gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            Debug.Log("music");
            canSound.Play();
            Destroy(collision.collider.gameObject,1f);


            Invoke("InvokeInstantiateApple", 1.5f);
            //gameObject.GetComponent<Renderer>().material.color = Color.white;
            fruit = true;
        }

        if (collision.collider.gameObject.CompareTag("Avocado") && fruit)
        {
            fruit = false;
            //gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            Debug.Log("music");
            canSound.Play();
            Destroy(collision.collider.gameObject, 1f);


            Invoke("InvokeInstantiateAvocado", 1.5f);
            //gameObject.GetComponent<Renderer>().material.color = Color.white;
            fruit = true;
        }

    }

    void InvokeInstantiateApple()
    {
        canSound.Play();
        Instantiate(effect, transform.position, transform.rotation);
        GameObject instance = Instantiate(applecan, transform.position, transform.rotation) as GameObject;

    }
    void InvokeInstantiateAvocado()
    {
        canSound.Play();
        Instantiate(effect, transform.position, transform.rotation);
        GameObject instance = Instantiate(avocadocan, transform.position, transform.rotation) as GameObject;

    }

}


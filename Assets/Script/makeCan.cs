using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeCan : MonoBehaviour
{
    public GameObject applecan;
    public GameObject effect;

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
        //        this.audio = this.gameObject.AddComponent<AudioSource>();
        //        this.audio.clip = this.music;

        if (collision.collider.gameObject.CompareTag("Apple"))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            Debug.Log("music");
            Destroy(collision.collider.gameObject,1f);


            Invoke("InvokeInstantiate", 1.5f);
            gameObject.GetComponent<Renderer>().material.color = Color.white;

        }

    }

    void InvokeInstantiate()
    {
        Instantiate(effect, transform.position, transform.rotation);
        GameObject instance = Instantiate(applecan, transform.position, transform.rotation) as GameObject;

    }
}


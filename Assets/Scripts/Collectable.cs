using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public GameObject coinVisual;
    AudioSource audioS;


    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        coinVisual.transform.Rotate(0.0f, 3.0f, 0.0f, Space.Self);


    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(" a collision has happened in the trigger");

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("  it was the player after all");
            audioS.Play();

            other.gameObject.GetComponent<PlayerController>().coins += 1;
            Destroy(gameObject, 0.60f);
        }
    }
}

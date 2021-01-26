using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchScript : MonoBehaviour
{

    public Light l;
    float timer = 0.0f;

    // Use this for initialization
    void Start()
    {
        l = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer >= 0.2)
        {
            l.intensity = Random.Range(0.1f, 1.0f);
            timer = 0.0f;
        }




    }
}

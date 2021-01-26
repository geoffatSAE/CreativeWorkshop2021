using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public float timer;
    public bool goalReached;
    public Text uiText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!goalReached)
        {
            timer += Time.deltaTime;
            uiText.text = timer.ToString("F0");
        } else
        {
            //GAME OVER
            Debug.Log("GAME OVER MAN, GAME OVER");
        }
        



    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            goalReached = true;
        }
    }
}

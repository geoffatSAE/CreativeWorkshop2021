using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;
    public GameObject characterVisual;
    public int coins;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quitting");
            Application.Quit();
        }

        if(coins >= 2)
        {
            //GAME OVER
            Debug.Log("Game over, collected all the coins");

            //now extend this to play gameover sound, and update the UI with GameOVer
        }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Debug.Log(horizontal + " and " + vertical);

        transform.Translate(new Vector3(horizontal, 0.0f, vertical) * Time.deltaTime * speed);
        //transform.Rotate(0.0f, horizontal, 0.0f, Space.Self);

        if(horizontal > 0)
        {
            //facing right, 90deg
            characterVisual.transform.localRotation = Quaternion.Euler(0, 90, 0);
        }
        if(horizontal < 0)
        {
            //facing left, 270
            characterVisual.transform.localRotation = Quaternion.Euler(0, 270, 0);
        }
        if (vertical > 0)
        {
            //facing up, 90deg
            characterVisual.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (vertical < 0)
        {
            //facing down, 270
            characterVisual.transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }
}

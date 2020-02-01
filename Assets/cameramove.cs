using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //WASDQE Controls

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0.5f, 0, 0));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-0.5f, 0, 0));
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0.5f, 0));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -0.5f, 0));
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(new Vector3(0, 0, 0.5f));
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(new Vector3(0, 0, -0.5f));
        }

        //Arrow Camera Controls


        //Analyse components
        Vector3 transDir = new Vector3(0, 0, 0);

        if(Input.GetKey(KeyCode.DownArrow))
        {
            transDir.x = 1;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transDir.x = -1;
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transDir.y = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transDir.y = 1;
        }

        transform.Rotate(transDir);

    }
}

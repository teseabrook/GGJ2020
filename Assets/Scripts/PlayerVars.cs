using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVars : MonoBehaviour
{
    int currentRoom;
    Vector2 currentTile, currentPosition;
    RoomBase roomScript;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("dab");
        roomScript = GameObject.Find("room").GetComponent<RoomBase>();
        player = GameObject.Find("player");
        currentRoom = 0;
        currentTile = new Vector2(0, 0);
        currentPosition = roomScript.getActualPos();
    }

    // Update is called once per frame
    void Update()
    {
        //If a relevant key is pressed do something
        //otherwise just vibe
        if(Input.GetKeyDown(KeyCode.W))
        {
            //Debug.Log("debug: " + (currentTile.x - 1) + "hi" +  currentTile.y);
            int res = roomScript.checkTile((int)currentTile.x - 1, (int)currentTile.y);
            if(res == 2)
            {
                //Warp Code
            }
            else if (res == 0)
            {
                Debug.Log("dabbing to " + (currentTile.x - 1) + ", " + currentTile.y);
                currentTile.x--;

                currentPosition.x--;

                player.transform.Translate(new Vector3(-1, 0, 0));
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            int res = roomScript.checkTile((int)currentTile.x, (int)currentTile.y - 1);
            if (res == 2)
            {
                //Warp Code
            }
            else if (res == 0)
            {
                Debug.Log("dabbing to " + currentTile.x + ", " + (currentTile.y - 1));
                currentTile.y--;

                currentPosition.y--;

                player.transform.Translate(new Vector3(0, 0, -1));
            }
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            int res = roomScript.checkTile((int)currentTile.x + 1, (int)currentTile.y);
            if (res == 2)
            {
                //Warp Code
            }
            else if (res == 0)
            {
                Debug.Log("dabbing to " + (currentTile.x + 1) + ", " + currentTile.y);
                currentTile.x++;

                currentPosition.x++;

                player.transform.Translate(new Vector3(1, 0, 0));
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            int res = roomScript.checkTile((int)currentTile.x, (int)currentTile.y + 1);
            if (res == 2)
            {
                //Warp Code
            }
            else if (res == 0)
            {
                Debug.Log("dabbing to " + currentTile.x + ", " + (currentTile.y + 1));
                currentTile.y++;

                currentPosition.y++;

                player.transform.Translate(new Vector3(0, 0, 1));
            }
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            //Interact
        }
    }
}

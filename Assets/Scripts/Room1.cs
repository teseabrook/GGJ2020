using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1 : MonoBehaviour
{
    RoomBase roomScript;
    // Start is called before the first frame update
    void Start()
    {
        roomScript = GameObject.Find("room").GetComponent<RoomBase>();
        //Set the variables for the room
        roomScript.setActualPos(new Vector2(9, 9));
        roomScript.setXMax(20);
        roomScript.setYMax(12);
        //roomScript.setIllegalRoom(new Vector2(5, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

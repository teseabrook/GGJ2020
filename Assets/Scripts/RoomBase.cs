using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using 

public class RoomBase : MonoBehaviour
{
    //Stores information about the room and any illegal tiles, as well as tile pairs that would take you to a new scene
    //For funny shaped rooms, treat them as a big square and make things illegal is probably best practice


    //Warp tiles take you to other rooms
    //They should be one tile out from the normal room, which is fine as theyre checked before the illegal tiles
    //Warp rooms are the rooms that the warp tiles correspond to
    //Make sure theyre in the same order and the same size otherwise you'll have a bad time
    public List<Vector2> illegalTiles;
    public List<Vector2> warpTiles;
    List<int> warpRooms;

    //The tile's maximum values (ie in a 10x8 room, xMax is 9 and yMax is 7)
    int xMax, yMax;

    //The unity position of the player if they were in the top left tile of the room. Note it's an x/z position as y doesnt matter
    Vector2 actualPos;

    // Start is called before the first frame update
    void Start()
    {
        //Initialise all the variables. In theory, they should be set to the correct values by the room scrips
       // xMax = 0;
        //yMax = 0;
        //actualPos = new Vector2(0, 0);
       // warpTiles.Add(new Vector2(0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        //No actual updating needed per frame
    }

    //Getters & Setters
    int getXMax()
    {
        
        return xMax;
    }

    int getYMax()
    {
        return yMax;
    }

    public void setXMax(int arg)
    {
        Debug.Log("default dance");
        xMax = arg;
    }

    public void setYMax(int arg)
    {
        yMax = arg;
    }

    public void setActualPos(Vector2 pos)
    {
        actualPos = pos;
    }

    public void setWarpTile(Vector2 arg)
    {
        warpTiles.Add(arg);
    }

    public void setWarpRoom(int arg)
    {
        warpRooms.Add(arg);
    }

    public void setIllegalRoom(Vector2 arg)
    {
        illegalTiles.Add(arg);
    }

    public Vector2 getActualPos()
    {
        return actualPos;
    }


    //Checks the specified tile to see what it is
    // 0 is good to go
    // 1 is an illegal tile
    // 2 is a warp tile
    public int checkTile(int x, int y)
    {
        Debug.Log("Vibe check on " + x + ", " +  y);
        //Check warp tiles
        //Debug.Log(x + ", " + y);
        if (warpTiles.Count > 0)
        {
            for (int i = 0; i < warpTiles.Count; i++)
            {
                //Debug.Log("Vibe filed");
                if (x == warpTiles[i].x && y == warpTiles[i].y)
                {
                    Debug.Log("Vibe failed 1");
                    return 2;
                }
            }
        }

        if (illegalTiles.Count > 0)
        {
            //Check illegal tiles
            for (int i = 0; i < illegalTiles.Count; i++)
            {
                if (x == illegalTiles[i].x && y == illegalTiles[i].y)
                {
                    Debug.Log("Vibe failed 2");
                    return 1;
                }
            }

            

        }

        if (x > xMax || y > yMax || x < 0 || y < 0)
        {
            Debug.Log("vibing " + xMax + ", " + yMax);
            Debug.Log("Vibe failed 3");
            return 1;
        }
        //If its not a warp tile and not illegal its probably good
        Debug.Log("Vibe passed");
        return 0;
    }

    //Overload in case of sleep deprivation/whatever
    int checkTile(Vector2 tile)
    {
        return checkTile((int)tile.x, (int)tile.y);
    }
}

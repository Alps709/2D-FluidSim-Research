using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 newPos = player.transform.position;
            player.transform.SetPositionAndRotation(new Vector3(newPos.x, newPos.y + 1f, newPos.z), new Quaternion());
            print("Moved up");
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 newPos = player.transform.position;
            player.transform.SetPositionAndRotation(new Vector3(newPos.x, newPos.y - 1f, newPos.z), new Quaternion());
            print("Moved down");
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 newPos = player.transform.position;
            player.transform.SetPositionAndRotation(new Vector3(newPos.x - 1f, newPos.y, newPos.z), new Quaternion());
            print("Moved left");
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 newPos = player.transform.position;
            player.transform.SetPositionAndRotation(new Vector3(newPos.x + 1f, newPos.y, newPos.z), new Quaternion());
            print("Moved right");
        }
    }
}

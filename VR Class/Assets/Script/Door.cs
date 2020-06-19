using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool a = false;

    private void Update()
    {
        if(a == true)
        {
            if (transform.eulerAngles.y < 90)
            {
                transform.Rotate(0, 1, 0);
            }
        }

        if (a == false && transform.eulerAngles.y > 0)
        {
           transform.Rotate(0, -1, 0);
            if (transform.eulerAngles.y > 358)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
        }

    }

    public void OpenDoor()
    {
        a = !a;

    }



}

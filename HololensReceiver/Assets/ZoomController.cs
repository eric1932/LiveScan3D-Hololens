//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CubeInteractive : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}

using NRKernal;
using UnityEngine;

public class ZoomController : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        //get controller rotation, and set the value to the cube transform
        transform.rotation = NRInput.GetRotation();

        Vector2 vec = NRInput.GetDeltaTouch();
        //Debug.Log(vec.x);
        if (Mathf.Abs(vec.x) >= Mathf.Abs(vec.y))
        {
            // TODO Implement
        }
        else
        {
            // Swipe up/down => zoom in/out
            if (vec.y >= 0)
            {
                // swipe down => zoom out
                transform.localScale *= 0.975f;
            }
            else
            {
                // swipe up => zoom in
                transform.localScale *= 1.025f;
            }
        }
    }
}

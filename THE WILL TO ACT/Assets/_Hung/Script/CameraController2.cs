using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController2 : MonoBehaviour {

    //Movement
    public float panSpeed = 20f;
    public float panBorderThickness = 10f;
    public Vector2 panLimit;

    //Zoom In-Out
    public float scrollSpeed;
    public float minY = 20f;
    public float maxY = 100f;

    //Rotation (90 degree)
    private float rotateSpeed = 150f;
    private float rotated = 0f;

    //Set Camera position at Player Position
    public GameObject player;
    
    void Start()
    {
        Camera.main.transform.position = player.transform.position;
        rotated -= 90f;
    }

    void Update()
    {
        /// Movement
        Vector3 pos = transform.position;

        //if (rotated % -360 == 0)
        //{
        //    if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        //    {
        //        pos.z += panSpeed * Time.deltaTime;
        //    }

        //    if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        //    {
        //        pos.z -= panSpeed * Time.deltaTime;
        //    }

        //    if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        //    {
        //        pos.x += panSpeed * Time.deltaTime;
        //    }

        //    if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        //    {
        //        pos.x -= panSpeed * Time.deltaTime;
        //    }
        //}
        //else if (rotated % -270 == 0)
        //{
        //    if (Input.GetKey("d") || Input.mousePosition.y >= Screen.width - panBorderThickness)
        //    {
        //        pos.z += panSpeed * Time.deltaTime;
        //    }

        //    if (Input.GetKey("a") || Input.mousePosition.y <= panBorderThickness)
        //    {
        //        pos.z -= panSpeed * Time.deltaTime;
        //    }

        //    if (Input.GetKey("s") || Input.mousePosition.x <= panBorderThickness)
        //    {
        //        pos.x += panSpeed * Time.deltaTime;
        //    }

        //    if (Input.GetKey("w") || Input.mousePosition.x >= Screen.height - panBorderThickness)
        //    {
        //        pos.x -= panSpeed * Time.deltaTime;
        //    }
        //}
        //else if (rotated % -180 == 0)
        //{
        //    if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        //    {
        //        pos.z += panSpeed * Time.deltaTime;
        //    }

        //    if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        //    {
        //        pos.z -= panSpeed * Time.deltaTime;
        //    }

        //    if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        //    {
        //        pos.x += panSpeed * Time.deltaTime;
        //    }

        //    if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        //    {
        //        pos.x -= panSpeed * Time.deltaTime;
        //    }
        //}
        //else if (rotated % -90 == 0)
        //{
        //    if(rotated < 0)
        //    {
        //        if (Input.GetKey("d") || Input.mousePosition.y <= panBorderThickness)
        //        {
        //            pos.z += panSpeed * Time.deltaTime;
        //        }

        //        if (Input.GetKey("a") || Input.mousePosition.y >= Screen.width - panBorderThickness)
        //        {
        //            pos.z -= panSpeed * Time.deltaTime;
        //        }

        //        if (Input.GetKey("s") || Input.mousePosition.x <= panBorderThickness)
        //        {
        //            pos.x += panSpeed * Time.deltaTime;
        //        }

        //        if (Input.GetKey("w") || Input.mousePosition.x >= Screen.height - panBorderThickness)
        //        {
        //            pos.x -= panSpeed * Time.deltaTime;
        //        }
        //    }
        //    else
        //    {
        //        if (Input.GetKey("a") || Input.mousePosition.y >= Screen.width - panBorderThickness)
        //        {
        //            pos.z += panSpeed * Time.deltaTime;
        //        }

        //        if (Input.GetKey("d") || Input.mousePosition.y <= panBorderThickness)
        //        {
        //            pos.z -= panSpeed * Time.deltaTime;
        //        }

        //        if (Input.GetKey("w") || Input.mousePosition.x >= Screen.height - panBorderThickness)
        //        {
        //            pos.x += panSpeed * Time.deltaTime;
        //        }

        //        if (Input.GetKey("s") || Input.mousePosition.x <= panBorderThickness)
        //        {
        //            pos.x -= panSpeed * Time.deltaTime;
        //        }
        //    }
            
        //}

        if (rotated % 360 == 0)
        {
            if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
            {
                pos.z += panSpeed * Time.deltaTime;
            }

            if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
            {
                pos.z -= panSpeed * Time.deltaTime;
            }

            if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
            {
                pos.x += panSpeed * Time.deltaTime;
            }

            if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
            {
                pos.x -= panSpeed * Time.deltaTime;
            }
        }
        else if (rotated % 270 == 0)
        {
            if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
            {
                pos.x -= panSpeed * Time.deltaTime;
            }

            if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
            {
                pos.x += panSpeed * Time.deltaTime;
            }

            if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
            {
                pos.z += panSpeed * Time.deltaTime;
            }

            if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
            {
                pos.z -= panSpeed * Time.deltaTime;
            }
        }
        else if (rotated % 180 == 0)
        {
            if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
            {
                pos.z += panSpeed * Time.deltaTime;
            }

            if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
            {
                pos.z -= panSpeed * Time.deltaTime;
            }

            if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
            {
                pos.x += panSpeed * Time.deltaTime;
            }

            if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
            {
                pos.x -= panSpeed * Time.deltaTime;
            }
        }
        else if (rotated % 90 == 0)
        {
            if (rotated >0)
            {
                if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
                {
                    //pos.z += panSpeed * Time.deltaTime;
                    pos.x += panSpeed * Time.deltaTime;
                }

                if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
                {
                    //pos.z -= panSpeed * Time.deltaTime;
                    pos.x -= panSpeed * Time.deltaTime;
                }

                if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
                {
                    pos.z -= panSpeed * Time.deltaTime;
                    //pos.x += panSpeed * Time.deltaTime;
                }

                if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
                {
                    pos.z += panSpeed * Time.deltaTime;
                    //pos.x -= panSpeed * Time.deltaTime;
                }
            }
            else
            {
                if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
                {
                    pos.x -= panSpeed * Time.deltaTime;
                }

                if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
                {
                    pos.x += panSpeed * Time.deltaTime;
                }

                if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
                {
                    pos.z += panSpeed * Time.deltaTime;
                }

                if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
                {
                    pos.z -= panSpeed * Time.deltaTime;
                }
            }
        }
        /// End movement

        /// Rotation (update movement key after rotated)
        if (Input.GetKeyDown("q"))
        {
            rotated -= 90f;            
        }

        if (Input.GetKeyDown("e"))
        {
            rotated += 90f;            
        }

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(60, rotated, 0), rotateSpeed * Time.deltaTime);
        /// End Rotation
        
        ///Zoom
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollSpeed * 100f * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        pos.z = Mathf.Clamp(pos.z, -panLimit.y, panLimit.y);

        transform.position = pos;
        ///End Zoom        
    }
}

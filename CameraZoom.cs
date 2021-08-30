using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    //2D
    public int zoomSpeed2D, minZoom2D, maxZoom2D;

    //3D
    public int zoomSpeed3D, minZoom3D, maxZoom3D;

    // Update is called once per frame
    void Update()
    {
        //2D Camera
        if (Camera.main.orthographic)
        {
            //When we scrolling our mouse upwards the value will be greater than zero
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                //Zoom In
                Camera.main.orthographicSize -= zoomSpeed2D * Time.deltaTime;
            }

            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                //Zoom Out
                Camera.main.orthographicSize += zoomSpeed2D * Time.deltaTime;
            }

            //Restrict the value for 2D Camera
            Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, minZoom2D, maxZoom2D);
        }
        else
        {
            //if we dont have orthographic camera we will have perspective aka 3D Camera
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                //Zoom In
                Camera.main.fieldOfView -= zoomSpeed3D * Time.deltaTime;
            }

            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                //Zoom Out
                Camera.main.fieldOfView += zoomSpeed3D * Time.deltaTime;
            }

            //Restrict the value for 3D Camera
            Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, minZoom3D, maxZoom3D);
        }
    }
}


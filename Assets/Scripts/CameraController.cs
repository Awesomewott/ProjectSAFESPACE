using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float minimumX = -60f;
    public float maximumX = 60f;
    public float minimumY = -360;
    public float maximumY = 360;

    public float sensitivityX = 15f;
    public float sensitivityY = 15f;

    public Camera cam;

    private float rotationY = 0f;
    private float rotationX = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivityX;
        rotationX += Input.GetAxis("Mouse Y") * sensitivityY;

        rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);

        transform.localEulerAngles = new Vector3(0, rotationY, 0);
        cam.transform.localEulerAngles = new Vector3(-rotationX, rotationY, 0);
    }
}

using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float mouseSensitivity = 500f;

    float xRotation = 0f;
    float yRotation = 0f;

    public float TopClamp = -90f;
    public float BottomClamp = 90f;
    void Start()
    {
        //Locks Cursor and Hides
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Gets Mouse Input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        // Rotation around X axis
        xRotation -= mouseY;
        //Clamps
        xRotation = Mathf.Clamp(xRotation, TopClamp, BottomClamp);
        //Same but for Y
        yRotation += mouseX;

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}

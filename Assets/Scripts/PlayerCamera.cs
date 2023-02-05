using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float mouseSensitivityX;
    public float mouseSensitivityY;

    public Transform playerOrientation;

    private float rotationX;
    private float rotationY;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * mouseSensitivityX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * mouseSensitivityY;

        // GameObject.Find("Cursor").transform.position = new Vector3(mouseX, mouseY, 0f);

        rotationY += mouseX;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        // Rotate camera and player orientation
        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
        playerOrientation.rotation = Quaternion.Euler(0, rotationY, 0);

        // Set camera position to player position
        transform.position = playerOrientation.position;
    }
}

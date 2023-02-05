using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    public Texture2D mouseCursorTexture;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X");
        float mouseY = Input.GetAxisRaw("Mouse Y");

        Vector3 mousePosition = new Vector3(mouseX, mouseY, 0f);

        // Set custom cursor texture
        // Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        // transform.position = cursorPosition;
    }
}

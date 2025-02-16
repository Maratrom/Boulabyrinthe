using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed = 30f;

    void Update()
    {
        float rotationX = 0f;
        float rotationY = 0f;

        if (Input.GetKey(KeyCode.Keypad5)) rotationX = -rotationSpeed;
        if (Input.GetKey(KeyCode.Keypad2)) rotationX = rotationSpeed;
        if (Input.GetKey(KeyCode.Keypad6)) rotationY = rotationSpeed;
        if (Input.GetKey(KeyCode.Keypad4)) rotationY = -rotationSpeed;

        transform.Rotate(rotationX * Time.deltaTime, rotationY * Time.deltaTime, 0);
    }

    public void ResetRotation()
    {
        transform.rotation = Quaternion.Euler(90, 0, 0);
    }

}
using UnityEngine;

public class RotateCamereFollowMouse : MonoBehaviour
{
    [SerializeField] private float speedH = 2f;
    [SerializeField] private float speedV = 2f;
    private float yaw = 0f;
    private float pitch = 0f;
    private void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0);
    }
}

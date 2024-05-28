using UnityEngine;

public class MoveCameraFollowMouse : MonoBehaviour
{
    private float speed = 10f;
    private void Update()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, 0f,
            Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
    }
}

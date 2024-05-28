using UnityEngine;

public class RotateObj : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(Vector3.up * 50f * Time.deltaTime);
    }
}

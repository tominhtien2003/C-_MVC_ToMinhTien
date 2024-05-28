using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.transform.position);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }
    private void OnEnable()
    {
        Debug.Log("Enable");
    }
    private void OnDisable()
    {
        Debug.Log("Disable");
    }
}

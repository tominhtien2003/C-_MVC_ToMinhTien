using UnityEngine;

public class Plant : MonoBehaviour
{
    private float gravity = -12f;
    public void Attract(Transform playerTransform)
    {
        Vector3 gravityUp = (playerTransform.position - transform.position).normalized;

        Vector3 localUp = playerTransform.up;

        playerTransform.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);

        Quaternion targetRotation = Quaternion.FromToRotation(localUp, gravityUp) * playerTransform.rotation;

        playerTransform.rotation = Quaternion.Slerp(playerTransform.rotation,targetRotation,50f*Time.deltaTime);
    }
}

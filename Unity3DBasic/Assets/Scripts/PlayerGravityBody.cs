using UnityEngine;

public class PlayerGravityBody : MonoBehaviour
{
    [SerializeField] private Plant attractorPlant;
    private Transform playerTransform;
    private void Start()
    {
        playerTransform = transform;
    }
    private void FixedUpdate()
    {
        if (attractorPlant)
        {
            attractorPlant.Attract(playerTransform);
        }
    }
}

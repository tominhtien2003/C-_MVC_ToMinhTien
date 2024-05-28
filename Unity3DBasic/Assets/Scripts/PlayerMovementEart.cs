using UnityEngine;

public class PlayerMovementEart : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 moveDirec;
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody> ();
    }

    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirec = new Vector3(moveX, 0f, moveY).normalized;
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + transform.TransformDirection(moveDirec) * speed * Time.fixedDeltaTime);
    }
}

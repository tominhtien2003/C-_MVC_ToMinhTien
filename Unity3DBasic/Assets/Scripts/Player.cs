using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;

    private Rigidbody rb;

    private const string WALK = "Walk";

    private float cameraSmoothnessSpeed = .1f;

    private bool isWalking;

    [SerializeField] private Vector3 offsetCamera;

    [SerializeField] private float moveSpeed;

    [SerializeField] private float forceMove;

    public Vector3 moveDir;
    private void Awake()
    {
        animator = GetComponent<Animator>();

        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
    }
    private void Update()
    {
        HandleMovement();
    }
    private void FixedUpdate()
    {
    }
    /// <summary>
    /// Handle movement of player
    /// </summary>
    private void HandleMovement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");

        float moveY = Input.GetAxisRaw("Vertical");

        Vector3 moveDirec = new Vector3(moveX, 0f, moveY).normalized;

        isWalking = moveDirec != Vector3.zero;

        if (isWalking)
        {
            moveDir = moveDirec;

            animator.SetBool(WALK, true);

            transform.Translate(moveDirec * moveSpeed * Time.deltaTime, Space.World);
        }
        else
        {
            animator.SetBool(WALK, false);
        }

        if (isWalking)
        {
            float rotateSpeed = 10f;

            Quaternion newRotation = Quaternion.LookRotation(moveDirec, transform.up);

            transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotateSpeed * Time.deltaTime);
        }
        //CameraFollowPlayer();
    }
    /// <summary>
    /// Camera Follow Position Player
    /// </summary>
    private void CameraFollowPlayer()
    {
        Vector3 destinationCamera = transform.position + offsetCamera;

        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, destinationCamera, cameraSmoothnessSpeed);
    }
}

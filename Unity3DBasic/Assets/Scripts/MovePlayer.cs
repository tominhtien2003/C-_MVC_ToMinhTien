using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private float gravity = 20f;
    private void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        Vector3 moveDirec = Vector3.zero;
        if (controller.isGrounded)
        {
            float moveX = Input.GetAxisRaw("Horizontal");
            float moveY = Input.GetAxisRaw("Vertical");
            moveDirec = new Vector3(moveX, 0f, moveY).normalized;
            moveDirec = transform.TransformDirection(moveDirec);
            moveDirec *= 6f;
            if (Input.GetKey(KeyCode.Space))
            {
                moveDirec.y = 10f;
            }
        }
        moveDirec.y -= gravity * Time.deltaTime;
        controller.Move(moveDirec * Time.deltaTime);
    }
}

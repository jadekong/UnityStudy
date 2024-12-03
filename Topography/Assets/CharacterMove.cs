using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
  public float speed = 6.0F;
  public float jumpSpeed = 8.0F;
  public float gravity = 20.0F;
  private Vector3 moveDirection = Vector3.zero; //(0,0,0)
  void Update()
  {
    CharacterController controller = GetComponent<CharacterController>();
    if (controller.isGrounded) //바닥에 붙어있는지 여부 확인
    {
      moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
      moveDirection = transform.TransformDirection(moveDirection);
      moveDirection *= speed;
      if (Input.GetButton("Jump"))
        moveDirection.y = jumpSpeed;

    }
    moveDirection.y -= gravity * Time.deltaTime;
    controller.Move(moveDirection * Time.deltaTime);
  }
}

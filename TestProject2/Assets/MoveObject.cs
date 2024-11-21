using UnityEngine;

public class MoveObject : MonoBehaviour
{
    float speed = 10.0f;

    // Update is called once per frame
    void Update()
    {
      float position = Input.GetAxis("Vertical");
      position = position * speed * Time.deltaTime;
    transform.Translate(Vector3.forward * position);

    float position2 = Input.GetAxis("Horizontal");
    position2 = position2 * speed * Time.deltaTime;
    transform.Translate(Vector3.right * position2);
  }
}

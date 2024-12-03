using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
  Vector3 forward = new Vector3(0, 0, 1);
  Vector3 up =  new Vector3(0, 1, 0);

    void Update()
    {
      float v = Input.GetAxis("Vertical");
      float h = Input.GetAxis("Horizontal");

      v = v * Time.deltaTime;
      h = h * Time.deltaTime;
    transform.Translate(v * forward * 20);
    transform.Rotate(h * up * 100);

    if (Input.GetButton("Jump"))
    {
      GetComponent<Rigidbody>().AddForce(new Vector3(0, 20, 0));
    }
    }
}

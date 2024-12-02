using UnityEngine;

public class CollisionTest : MonoBehaviour
{
  public AudioSource collisionSound;
    void Start()
    {
        collisionSound = GetComponent<AudioSource>(); 
    }

  private void OnCollisionEnter(Collision collision)
  {
    collisionSound.Play();
    print("OnCollisionEnter");
  }
}

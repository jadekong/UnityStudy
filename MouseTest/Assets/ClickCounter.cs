using UnityEngine;

public class ClickCounter : MonoBehaviour
{
  int count = 0;

  private void OnMouseDown()
  {
    count += 1;
    print(count); 
  }
}

using UnityEngine;

public class MouseEvent : MonoBehaviour
{
  private void OnMouseEnter()
  {
    print("마우스 커서가 나타납니다.");
  }

  private void OnMouseExit()
  {
    print("마우스 커서가 빠져나갑니다.");
  }

  private void OnMouseDown()
  {
    print("마우스 왼쪽 버튼을 클릭합니다.");
  }

  private void OnMouseUp()
  {
    print("마우스 왼쪽 버튼을 놓았습니다.");
  }
}

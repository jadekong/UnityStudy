using UnityEngine;

public class MouseEvent : MonoBehaviour
{
  private void OnMouseEnter()
  {
    print("���콺 Ŀ���� ��Ÿ���ϴ�.");
  }

  private void OnMouseExit()
  {
    print("���콺 Ŀ���� ���������ϴ�.");
  }

  private void OnMouseDown()
  {
    print("���콺 ���� ��ư�� Ŭ���մϴ�.");
  }

  private void OnMouseUp()
  {
    print("���콺 ���� ��ư�� ���ҽ��ϴ�.");
  }
}

using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public static Color selectedColor = Color.white; // ���������� ��������� ���� �� ���������

    public void SetSelectedColor(Color newColor)
    {
        selectedColor = newColor; // ������ ����� ��������� ����
        Debug.Log("Selected color: " + selectedColor);
    }
}

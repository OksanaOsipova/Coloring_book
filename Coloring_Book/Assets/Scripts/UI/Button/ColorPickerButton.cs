using UnityEngine;
using UnityEngine.UI;

public class ColorPickerButton : MonoBehaviour
{
    public Color color; // ���� ������

    private ColorManager colorManager;

    void Start()
    {
        colorManager = FindObjectOfType<ColorManager>(); // ������� ������ ColorManager � �����
        GetComponent<Button>().onClick.AddListener(OnClick); // ��������� ��������� ������� �� ������
    }

    void OnClick()
    {
        colorManager.SetSelectedColor(color); // �������� ��������� ���� � ������ ColorManager
    }
}

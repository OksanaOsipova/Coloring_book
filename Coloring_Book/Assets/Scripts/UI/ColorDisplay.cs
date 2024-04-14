using UnityEngine;
using UnityEngine.UI;

public class ColorDisplay : MonoBehaviour
{
    private Image colorImage;
    private ColorManager colorManager;

    void Start()
    {
        colorImage = GetComponent<Image>(); // �������� ��������� Image �� �������
        colorManager = FindObjectOfType<ColorManager>(); // ������� ������ ColorManager � �����
    }

    void Update()
    {
        colorImage.color = ColorManager.selectedColor; // ��������� ���� Image � ������������ � ������� ��������� ������
    }
}

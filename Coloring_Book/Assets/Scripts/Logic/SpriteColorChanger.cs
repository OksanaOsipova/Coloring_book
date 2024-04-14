using UnityEngine;

public class SpriteColorChanger : MonoBehaviour
{
    private ColorManager colorManager;

    void Start()
    {
        colorManager = FindObjectOfType<ColorManager>(); // ������� ������ ColorManager � �����
    }

    void OnMouseDown()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>(); // �������� ��������� SpriteRenderer �������
        if (spriteRenderer != null)
        {
            spriteRenderer.color = ColorManager.selectedColor; // ������������� ��������� ���� �������
        }
    }
}


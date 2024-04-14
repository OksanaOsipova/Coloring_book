using UnityEngine;

public class SpriteColorChanger : MonoBehaviour
{
    private ColorManager colorManager;

    void Start()
    {
        colorManager = FindObjectOfType<ColorManager>(); // Находим объект ColorManager в сцене
    }

    void OnMouseDown()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>(); // Получаем компонент SpriteRenderer спрайта
        if (spriteRenderer != null)
        {
            spriteRenderer.color = ColorManager.selectedColor; // Устанавливаем выбранный цвет спрайта
        }
    }
}


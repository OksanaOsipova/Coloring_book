using UnityEngine;
using UnityEngine.UI;

public class ColorDisplay : MonoBehaviour
{
    private Image colorImage;
    private ColorManager colorManager;

    void Start()
    {
        colorImage = GetComponent<Image>(); // Получаем компонент Image на объекте
        colorManager = FindObjectOfType<ColorManager>(); // Находим объект ColorManager в сцене
    }

    void Update()
    {
        colorImage.color = ColorManager.selectedColor; // Обновляем цвет Image в соответствии с текущим выбранным цветом
    }
}

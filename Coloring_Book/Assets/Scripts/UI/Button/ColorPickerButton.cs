using UnityEngine;
using UnityEngine.UI;

public class ColorPickerButton : MonoBehaviour
{
    public Color color; // Цвет кнопки

    private ColorManager colorManager;

    void Start()
    {
        colorManager = FindObjectOfType<ColorManager>(); // Находим объект ColorManager в сцене
        GetComponent<Button>().onClick.AddListener(OnClick); // Добавляем слушателя нажатия на кнопку
    }

    void OnClick()
    {
        colorManager.SetSelectedColor(color); // Передаем выбранный цвет в объект ColorManager
    }
}

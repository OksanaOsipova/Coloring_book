using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public static Color selectedColor = Color.white; // Запоминаем выбранный цвет по умолчанию

    public void SetSelectedColor(Color newColor)
    {
        selectedColor = newColor; // Задаем новый выбранный цвет
        Debug.Log("Selected color: " + selectedColor);
    }
}

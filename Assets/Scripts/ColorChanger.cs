using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Image image;

public void ChangeColor()
{
    Color randomColor = new Color(Random.value, Random.value, Random.value);

    image.color = randomColor;
}

}

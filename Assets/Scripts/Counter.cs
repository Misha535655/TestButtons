using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreUI;
    private int count = 0;

    public void Increment()
    {
        count++;
        scoreUI.text = "Score " + count;
    }
}

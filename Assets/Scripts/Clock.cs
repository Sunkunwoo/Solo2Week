using UnityEngine;
using TMPro;
using System;

public class Clock : MonoBehaviour
{
    private TextMeshProUGUI timeTxt;
    private void Start()
    {
        timeTxt = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        DateTime currentTime = DateTime.Now;
        timeTxt.text = currentTime.ToString("HH: mm:ss");
    }
}

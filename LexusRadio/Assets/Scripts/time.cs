using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class time : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI dateText;

    void Start()
    {
        if (timeText == null)
        {
            Debug.LogError("timeText is not assigned!");
            return;
        }
        if (dateText == null)
        {
            Debug.LogError("dateText is not assigned!");
            return;
        }

        UpdateTime();
    }

    void UpdateTime()
    {
        // Get the current time from the system
        System.DateTime now = System.DateTime.Now;

        //Full Time Format ( "MM/dd/yyyy HH:mm:ss")
        string formattedTime = now.ToString("HH:mm");
        string formattedDate = now.ToString("yyyy/MM/dd/ddd");

        // Display it on the UI
        timeText.text = $"{formattedTime}";
        dateText.text = $"{formattedDate}";
    }

    void Update()
    {
        UpdateTime();
    }
}
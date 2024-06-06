using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MaintenanceValue : MonoBehaviour
{
    private int Mileage;

    private int TimingReplaceIn = 150000;
    private int TimingCurrent;
    public int TimingReplaced;

    public TextMeshProUGUI TimingValue;
    //public TextMeshProUGUI Timing;
    public TextMeshProUGUI CarHealth;

    void Start()
    {
        if (CarHealth == null)
        {
            Debug.LogError("CarHealth is not assigned!");
            return;
        }

        UpdateCarHealth();

    }

    void Timing()
    {
        //Get information from Maintenance.xml file
        //Get mileage
        //Get info when replaced
        TimingCurrent = Mileage - TimingReplaced;
    }
    void UpdateCarHealth()
    {
        //Get information from Maintenance.xml file

        // Display it on the UI
        CarHealth.text = $"Car Health: ";
    }
    void Update()
    {
        UpdateCarHealth();
        Timing();
    }
}
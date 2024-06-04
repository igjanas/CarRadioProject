using System.Collections;
using System.Xml;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OBDValue : MonoBehaviour
{
    public TextMeshProUGUI AFR;
    public TextMeshProUGUI coolantTemp;
    public TextMeshProUGUI OilPress;
    public TextMeshProUGUI intakeTemp;
    public XmlTextReader obd;

    void Start()
    {
        if (coolantTemp == null)
        {
            Debug.LogError("coolantTemp is not assigned!");
            return;
        }

            UpdateCoolantTemp();

        if (OilPress == null)
        {
            Debug.LogError("OilPress is not assigned!");
            return;
        }

            UpdateoilPress();

        if (intakeTemp == null)
        {
            Debug.LogError("intakeTemp is not assigned!");
            return;
        }

            UpdateintakeTemp();

        if (AFR == null)
        {
            Debug.LogError("AFR is not assigned!");
            return;
        }

            UpdateAFR();

    }

    void UpdateCoolantTemp()
    {
        //Get information from OBDII .xml file

        // Display it on the UI
        coolantTemp.text = $"Coolant Temperature: data °C";
    }
    void UpdateoilPress()
    {
        //Get information from OBDII .xml file

        // Display it on the UI
        OilPress.text = $"Oil Pressure: data psi";
    }
    void UpdateintakeTemp()
    {
        //Get information from OBDII .xml file

        // Display it on the UI
        intakeTemp.text = $"Intake Temperature: DATA °C";
    }
    void UpdateAFR()
    {
        //Get information from OBDII .xml file

        // Display it on the UI
        AFR.text = $"AFR: data";
    }

    void Update()
    {
        UpdateAFR();
        UpdateintakeTemp();
        UpdateCoolantTemp();
        UpdateoilPress();
    }
}
using System.Collections;
using System.Xml;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DTCValue : MonoBehaviour
{
    private int DTCAmount;

    public TextMeshProUGUI DTCCode;
    public XmlTextReader obd;

    void Start()
    {
        if (DTCCode == null)
        {
            Debug.LogError("DTCCode is not assigned!");
            return;
        }

        UpdateDTCCode();

    }

    void UpdateDTCCode()
    {
        //Get information from DTC_info.xml file

        // Display it on the UI
        DTCCode.text = $"P05420";
    }
    void errorAmount()
    {
        //Get amount of error codes from DTC_info.xml

        for (int i=0; i < 0; i++)
        { 
            DTCAmount = DTCAmount + 1;
        }
    }
    void Update()
    {
        UpdateDTCCode();
    }
}
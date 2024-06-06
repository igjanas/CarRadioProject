using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readFile : MonoBehaviour
{
    //public TextAsset carInfo;
    //public TextAsset DTCInfo;
    //public TextAsset OBDInfo;
    void Start()
    {
        //find files
        string carInfo = Path.Combine(Application.dataPath, "OBDII Information/carInfo.txt");
        string OBDInfo = Path.Combine(Application.dataPath, "OBDII Information/DTCInfo.txt");
        string DTCInfo = Path.Combine(Application.dataPath, "OBDII Information/OBDInfo.txt");
        //find files

        //check for files
        if (File.Exists(carInfo))
        {
            using (StreamReader reader = new StreamReader(carInfo))
            {
                string fileContents = reader.ReadToEnd();
                Debug.Log("Contents: " + fileContents);
            }
        }
        else
            Debug.LogError("File not at" + carInfo);

        if (File.Exists(DTCInfo))
        {
            using (StreamReader reader = new StreamReader(DTCInfo))
            {
                string fileContents = reader.ReadToEnd();
                Debug.Log("Contents: " + fileContents);
            }
        }
        else
            Debug.LogError("File not at" + DTCInfo);

        if (File.Exists(OBDInfo))
        {
            using (StreamReader reader = new StreamReader(OBDInfo))
            {
                string fileContents = reader.ReadToEnd();
                Debug.Log("Contents: " + fileContents);
            }
        }
        else
            Debug.LogError("File not at" + OBDInfo);

    }
    //check for files

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QFSW.PL;

public class Example : MonoBehaviour
{
    [SerializeField] private Text LoggerText;

    public void ExampleButtonDown()
    {
        if (PerformanceLogger.CurrentState == PerformanceLogger.LoggerState.Logging)
        {
            LoggerText.text = "Dumping logfile...";
            PerformanceLogger.EndLogger(Application.persistentDataPath + "/PerformanceLogs/" + SystemInfo.deviceName + " - Example.log", null, true, () => LoggerText.gameObject.SetActive(false));
        }
        else if (PerformanceLogger.CurrentState == PerformanceLogger.LoggerState.None)
        {
            LoggerText.text = "Logging...";
            LoggerText.gameObject.SetActive(true);
            PerformanceLogger.StartLogger();
        }
    }
}

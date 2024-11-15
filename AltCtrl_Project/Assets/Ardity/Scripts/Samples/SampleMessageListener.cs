/**
 * Ardity (Serial Communication for Arduino + Unity)
 * Author: Daniel Wilches <dwilches@gmail.com>
 *
 * This work is released under the Creative Commons Attributions license.
 * https://creativecommons.org/licenses/by/2.0/
 */

using UnityEngine;
using System.Collections;

/**
 * When creating your message listeners you need to implement these two methods:
 *  - OnMessageArrived
 *  - OnConnectionEvent
 */
public class SampleMessageListener : MonoBehaviour
{
    public GameObject EyeCircle;
    public GameObject CutOpenCircle;
    public GameObject StitchUpCircle;
    public GameObject HeartListenCircle;
    public GameObject KidneyStoneCircle;
    public GameObject WeldOrgansCircle;
    public GameObject BandagesCircle;
    // Invoked when a line of data is received from the serial device.
    void OnMessageArrived(string msg)
    {
        Debug.Log("Message arrived: " + msg);
        if (msg == "Sensor_Covered")
        {
            EyeCircle.SetActive(false);
            GameManager.instance.SetMinigameComplete("EyeReplacement");
        }
        if (msg == "Sensor_Covered2")
        {
            KidneyStoneCircle.SetActive(false);
            GameManager.instance.SetMinigameComplete("KidneyStoneRemoval");
        }
        if (msg == "Sensor_Covered3")
        {
            WeldOrgansCircle.SetActive(false);
            GameManager.instance.SetMinigameComplete("WeldingOrgans");
        }
        if (msg == "Light_Uncovered")
        {
            CutOpenCircle.SetActive(false);
            GameManager.instance.SetMinigameComplete("CuttingOpen");
        }
        if (msg == "Light_Uncovered2")
        {
            StitchUpCircle.SetActive(false);
            GameManager.instance.SetMinigameComplete("StitchUp");
        }
        if (msg == "Light_Uncovered3")
        {
            HeartListenCircle.SetActive(false);
            GameManager.instance.SetMinigameComplete("HeartListening");
        }
        if (msg == "Light_Uncovered4")
        {
            BandagesCircle.SetActive(false);
            GameManager.instance.SetMinigameComplete("Bandages");
        }
        if (msg == "Light_Uncovered5")
        {
            BandagesCircle.SetActive(false);
            GameManager.instance.SetMinigameComplete("Bandages");
        }
    }

    // Invoked when a connect/disconnect event occurs. The parameter 'success'
    // will be 'true' upon connection, and 'false' upon disconnection or
    // failure to connect.
    void OnConnectionEvent(bool success)
    {
        if (success)
            Debug.Log("Connection established");
        else
            Debug.Log("Connection attempt failed or disconnection detected");
    }
}

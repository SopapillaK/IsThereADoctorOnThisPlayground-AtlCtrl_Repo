using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScreen : MonoBehaviour
{
    public GameObject eyeReplacement;
    public GameObject bandages;
    public GameObject stitchUp;
    public GameObject arteryBypass;
    public GameObject heartListening;
    public GameObject kidneyStone;
    public GameObject cutOpen;
    public GameObject weldOrgans;
    public void EyeReplacementButton()
    {
        eyeReplacement.SetActive(true);
        bandages.SetActive(false);
        stitchUp.SetActive(false);
        arteryBypass.SetActive(false);
        heartListening.SetActive(false);
        kidneyStone.SetActive(false);
        cutOpen.SetActive(false);
        weldOrgans.SetActive(false);
    }

    public void BandagesButton()
    {
        eyeReplacement.SetActive(false);
        bandages.SetActive(true);
        stitchUp.SetActive(false);
        arteryBypass.SetActive(false);
        heartListening.SetActive(false);
        kidneyStone.SetActive(false);
        cutOpen.SetActive(false);
        weldOrgans.SetActive(false);
    }

    public void StitchUpButton()
    {
        eyeReplacement.SetActive(false);
        bandages.SetActive(false);
        stitchUp.SetActive(true);
        arteryBypass.SetActive(false);
        heartListening.SetActive(false);
        kidneyStone.SetActive(false);
        cutOpen.SetActive(false);
        weldOrgans.SetActive(false);
    }

    public void ArteryBypassButton()
    {
        eyeReplacement.SetActive(false);
        bandages.SetActive(false);
        stitchUp.SetActive(false);
        arteryBypass.SetActive(true);
        heartListening.SetActive(false);
        kidneyStone.SetActive(false);
        cutOpen.SetActive(false);
        weldOrgans.SetActive(false);
    }

    public void HeartListenButton()
    {
        eyeReplacement.SetActive(false);
        bandages.SetActive(false);
        stitchUp.SetActive(false);
        arteryBypass.SetActive(false);
        heartListening.SetActive(true);
        kidneyStone.SetActive(false);
        cutOpen.SetActive(false);
        weldOrgans.SetActive(false);
    }

    public void KidneyStoneButton()
    {
        eyeReplacement.SetActive(false);
        bandages.SetActive(false);
        stitchUp.SetActive(false);
        arteryBypass.SetActive(false);
        heartListening.SetActive(false);
        kidneyStone.SetActive(true);
        cutOpen.SetActive(false);
        weldOrgans.SetActive(false);
    }

    public void CutOpenButton()
    {
        eyeReplacement.SetActive(false);
        bandages.SetActive(false);
        stitchUp.SetActive(false);
        arteryBypass.SetActive(false);
        heartListening.SetActive(false);
        kidneyStone.SetActive(false);
        cutOpen.SetActive(true);
        weldOrgans.SetActive(false);
    }

    public void WeldOrgansButton()
    {
        eyeReplacement.SetActive(false);
        bandages.SetActive(false);
        stitchUp.SetActive(false);
        arteryBypass.SetActive(false);
        heartListening.SetActive(false);
        kidneyStone.SetActive(false);
        cutOpen.SetActive(false);
        weldOrgans.SetActive(true);
    }
}

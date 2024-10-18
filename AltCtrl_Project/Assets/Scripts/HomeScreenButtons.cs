using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class HomeScreenButtons : MonoBehaviour
{
    public GameObject creditsScreen;

    public void StartButton()
    {
        SceneManager.LoadScene("How2Screen");
    }

    public void CreditsButton()
    {
        //SceneManager.LoadScene("Credits");
        creditsScreen.SetActive(true);
    }

    public void QuitButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitButton()
    {
        creditsScreen.SetActive(false);
    }
}

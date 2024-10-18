using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToScreen : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("GameScreen");
    }
}

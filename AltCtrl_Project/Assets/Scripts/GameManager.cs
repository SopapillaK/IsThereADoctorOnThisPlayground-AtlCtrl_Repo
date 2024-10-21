using UnityEngine;
using System.Linq;
using UnityEngine.Serialization;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] public MiniGameStruct[] miniGameStructs;
    private float overallTimer = 300f;
    public float timeRemaining;

    public ReprintList reprintList;
    public bool GameEnding;

    public enum miniGameCheck
    {
        EyeReplacement, Bandages, StitchUp, ArteryBypass, HeartListening, KidneyStoneRemoval, CuttingOpen, WeldingOrgans
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }

        timeRemaining = overallTimer;
    }

    void FixedUpdate()
    {
        timeRemaining -= Time.deltaTime;

        if (!GameEnding)
        {
            GameEnding = reprintList.CheckForWin();
        }
    }

    void Start()
    {

    }


    public void SetMinigameComplete(string name)
    {
        MiniGameStruct game = miniGameStructs.First(q => q.gameTitle == name);
        game.complete = true;
    }

    [Serializable]
    public class MiniGameStruct
    {
        [SerializeField] public string gameTitle;
        [SerializeField] public bool complete;

        public override string ToString()
        {
            string newGame = gameTitle;
            if (complete)
                newGame = "<s>" + gameTitle + "</s>";
            return newGame;
        }
    }
}

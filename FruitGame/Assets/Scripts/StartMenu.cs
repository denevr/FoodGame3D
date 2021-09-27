using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public Button startButton;

    void Start()
    {
        startButton.onClick.AddListener(OnStartButtonClick);
    }

    void Update()
    {
        
    }

    void OnStartButtonClick()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
}

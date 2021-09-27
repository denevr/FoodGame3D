using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level2GameManager : MonoBehaviour
{
    private Vector3 center = Vector3.zero;
    private GameObject olive;
    public GameObject olivePrefab;
    public Image levelBar;
    public Button restartButton;
    public static Transform fruits;

    void Start()
    {
        levelBar.fillAmount = 0;
        fruits = GameObject.FindWithTag("Fruits").transform;
        SpawnOlives(32);
        restartButton.onClick.AddListener(OnRestartButtonClick);
    }

    void Update()
    {
        levelBar.fillAmount = (float)(32 - fruits.childCount) / 32;

        if (fruits.childCount == 0)
        {
            Debug.Log("level 2 ends");
            SceneManager.LoadScene("Level3", LoadSceneMode.Single);
        }
    }

    public void SpawnOlives(int amount)
    {
        System.Random random = new System.Random();

        for (int i = 0; i < amount; i++)
        {
            Vector3 position = center + new Vector3(GetRandomNumberBetween(random, -4, 4), 0.0f, GetRandomNumberBetween(random, -6.5, 6.5));
            //Instantiate(olivePrefab, position, Quaternion.identity);
            //olivePrefab.SetActive(true);

            //GameObject oliveToSpawn = BuildManager.instance.GetNewOlive();
            olive = (GameObject)Instantiate(olivePrefab, position, Quaternion.identity, fruits.transform);
        }
    }

    public float GetRandomNumberBetween(System.Random random, double minimum, double maximum)
    {
        double randValue = random.NextDouble() * (maximum - minimum) + minimum;
        return (float)randValue;
    }

    void OnRestartButtonClick()
    {
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);
    }
}

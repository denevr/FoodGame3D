using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnimationController : MonoBehaviour
{
    //public Button nextButton;
    public Transform foodBasket;
    public float delay = 5;

    void Start()
    {
        GetRandomPrize();
        StartCoroutine(LoadLevelAfterDelay(delay));
        //nextButton.onClick.AddListener(OnNextButtonClick);
    }

    void Update()
    {
        
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        //SceneManager.LoadScene("Level2");
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);
    }

    public void GetRandomPrize()
    {
        System.Random random = new System.Random();
        int randFruitIndex = GetRandomIntBetween(random, 0, foodBasket.childCount);
        Instantiate(foodBasket.GetChild(randFruitIndex).gameObject);
        foodBasket.GetChild(randFruitIndex).gameObject.SetActive(true);
    }

    public int GetRandomIntBetween(System.Random random, double minimum, double maximum)
    {
        double randValue = random.NextDouble() * (maximum - minimum) + minimum;
        return (int)randValue;
    }

    //void OnNextButtonClick()
    //{
    //    SceneManager.LoadScene("Level2", LoadSceneMode.Single);
    //}
}

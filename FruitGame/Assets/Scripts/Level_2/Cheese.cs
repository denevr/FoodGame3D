using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cheese : MonoBehaviour
{
    private GameObject cheese;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Cheese"))
        {
            Destroy(gameObject);
            Destroy(collision.collider.gameObject);
            Debug.Log("level 2 ends");
            SceneManager.LoadScene("Level3", LoadSceneMode.Single);
        }
    }
}

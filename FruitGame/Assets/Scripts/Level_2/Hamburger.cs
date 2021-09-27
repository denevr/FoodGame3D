using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hamburger : MonoBehaviour
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
        if (collision.collider.gameObject.CompareTag("Hamburger"))
        {
            if (collision.collider.gameObject.GetInstanceID() < gameObject.GetInstanceID())
            {
                GameObject cheeseToSpawn = BuildManager.instance.GetNewCheese();
                cheese = (GameObject)Instantiate(cheeseToSpawn, transform.position, Quaternion.identity, Level2GameManager.fruits.transform);
            }
            Destroy(gameObject);
            Destroy(collision.collider.gameObject);
        }
    }
}

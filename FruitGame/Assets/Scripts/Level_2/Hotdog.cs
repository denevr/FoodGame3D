using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hotdog : MonoBehaviour
{
    private GameObject hamburger;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Hotdog"))
        {
            if (collision.collider.gameObject.GetInstanceID() < gameObject.GetInstanceID())
            {
                GameObject hamburgerToSpawn = BuildManager.instance.GetNewHamburger();
                hamburger = (GameObject)Instantiate(hamburgerToSpawn, transform.position, Quaternion.identity, Level2GameManager.fruits.transform);
            }
            Destroy(gameObject);
            Destroy(collision.collider.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : MonoBehaviour
{
    private GameObject hotdog;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Banana"))
        {
            if (collision.collider.gameObject.GetInstanceID() < gameObject.GetInstanceID())
            {
                GameObject hotdogToSpawn = BuildManager.instance.GetNewHotdog();
                hotdog = (GameObject)Instantiate(hotdogToSpawn, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
            Destroy(collision.collider.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherry : MonoBehaviour
{
    private GameObject banana;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Cherry"))
        {
            if (collision.collider.gameObject.GetInstanceID() < gameObject.GetInstanceID())
            {
                GameObject bananaToSpawn = BuildManager.instance.GetNewBanana();
                banana = (GameObject)Instantiate(bananaToSpawn, transform.position, Quaternion.identity, Level2GameManager.fruits.transform);
            }
            Destroy(gameObject);
            Destroy(collision.collider.gameObject);
        }
    }
}

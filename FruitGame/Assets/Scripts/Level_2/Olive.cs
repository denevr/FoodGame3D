using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Level_2
{
    class Olive : MonoBehaviour
    {
        private GameObject cherry;

        void Start()
        {

        }

        void Update()
        {

        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.gameObject.CompareTag("Olive"))
            {
                if (collision.collider.gameObject.GetInstanceID() < gameObject.GetInstanceID())
                {
                    GameObject cherryToSpawn = BuildManager.instance.GetNewCherry();
                    cherry = (GameObject)Instantiate(cherryToSpawn, transform.position, Quaternion.identity, Level2GameManager.fruits.transform);
                }
                Destroy(gameObject);
                Destroy(collision.collider.gameObject);
            }
        }
    }
}

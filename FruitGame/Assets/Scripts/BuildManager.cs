using UnityEngine;

public class BuildManager : MonoBehaviour
{
    private GameObject cherryToSpawn;
    public GameObject defaultCherryPrefab;
    private GameObject oliveToSpawn;
    public GameObject defaultOlivePrefab;
    private GameObject bananaToSpawn;
    public GameObject defaultBananaPrefab;
    private GameObject hotdogToSpawn;
    public GameObject defaultHotdogPrefab;
    private GameObject hamburgerToSpawn;
    public GameObject defaultHamburgerPrefab;
    private GameObject cheeseToSpawn;
    public GameObject defaultCheesePrefab;

    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            return;
        }

        instance = this;
    }

    void Start()
    {
        cherryToSpawn = defaultCherryPrefab;
        oliveToSpawn = defaultOlivePrefab;
        bananaToSpawn = defaultBananaPrefab;
        hotdogToSpawn = defaultHotdogPrefab;
        hamburgerToSpawn = defaultHamburgerPrefab;
        cheeseToSpawn = defaultCheesePrefab;
    }

    public GameObject GetNewOlive()
    {
        return oliveToSpawn;
    }

    public GameObject GetNewCherry()
    {
        return cherryToSpawn;
    }

    public GameObject GetNewBanana()
    {
        return bananaToSpawn;
    }
    
    public GameObject GetNewHotdog()
    {
        return hotdogToSpawn;
    }
    public GameObject GetNewHamburger()
    {
        return hamburgerToSpawn;
    }
    public GameObject GetNewCheese()
    {
        return cheeseToSpawn;
    }
}


using UnityEngine;

public class BuildManager : MonoBehaviour
{
    //-------------------------------------- Sistema de seguridad para que no tengamos mas de un build Manager
    public static BuildManager instance;

    public Node nodeScript;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Tienes mas de un BuildManager");
            return;
        }

        instance = this; 
    }
    //---------------------------------------------------------

    public GameObject bombTorretPrefab;
    public GameObject arrowLauncherPrefab;

    private void Start()
    {
        turretToBuild = bombTorretPrefab;
    }

    public void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    BuyArrowTower();

        //}

        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    BuyBombTower();
        //}

        switch (Node.torretType)
        {
            case false: 
                turretToBuild = bombTorretPrefab;
                break;

            case true:
                turretToBuild = arrowLauncherPrefab;
                break;

        }
    }

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void BuyArrowTower()
    {
        Node.torretType = true;
    }

    public void BuyBombTower()
    {
        Node.torretType = false;
    }

    public void BuildTower()
    {
        nodeScript.CreateTower();
    }
}

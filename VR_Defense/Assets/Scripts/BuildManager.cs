
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    //-------------------------------------- Sistema de seguridad para que no tengamos mas de un build Manager
    public static BuildManager instance;

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

    public GameObject arrowTorretPrefab;
    public GameObject bombLauncherPrefab;

    private void Start()
    {
        turretToBuild = arrowTorretPrefab;
    }

    public void Update()
    {
        switch (Node.torretType)
        {
            case false: 
                turretToBuild = arrowTorretPrefab;
                break;

            case true:
                turretToBuild = bombLauncherPrefab;
                break;

        }
    }

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
}

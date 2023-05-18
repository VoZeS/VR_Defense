
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

    private void Start()
    {
        turretToBuild = arrowTorretPrefab;

    }

    private GameObject turretToBuild;

    public GameObject getTurretToBuild()
    {
        return turretToBuild;
    }


}

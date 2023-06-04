using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Node : MonoBehaviour
{
    //public Color hoverColor;
    public Color noBuildColor;
    public Vector3 positionOffset;

    private GameObject turret;

    public static int arrowTowerPrice = 200;
    public static int bombTowerPrice = 400;


    private Renderer rend;
    private Color starColor;

    public static bool torretType = true;

    private void Start()
    {

        rend = GetComponent<Renderer>();
        starColor = rend.material.color;

        //grabIntArrow = arrow.GetComponent<XRGrabInteractable>();

    }


    public void OnMouseDown()
    {
        CreateTower();
    }

    public void Update()
    {


        if (ChangeMode.buildMode == false)
        {
            noBuildMode();
        }

        //if (WaveSpawner.enemyalive <= 0)
        //{
          
        //    HoverExit();
        //}

    }

    public void CreateTower()
    {
        if (turret != null)
        {
            Debug.Log("No puedes construir aqui");
            return;
        }

        if (WaveSpawner.enemyalive<=0)
        {
            if (torretType == false && PlayerStats.Money >= bombTowerPrice) //Construye torreta de flechas
            {
                GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
                turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
                PlayerStats.Money -= bombTowerPrice;
            }

            if (torretType == true && PlayerStats.Money >= arrowTowerPrice) //Construye torreta de bombas
            {
                GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
                turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
                PlayerStats.Money -= arrowTowerPrice;
            }
        }
       
    }


    //public void OnMouseEnter()
    //{
    //    rend.material.color = hoverColor; //Cambia el color del tile si pasas el raton por encima
    //}
    //public void OnMouseExit()
    //{
    //    rend.material.color = starColor;
    //}

   public void noBuildMode()
    {
        rend.material.color = noBuildColor;
     
    }
    
}

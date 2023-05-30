using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;

    private GameObject turret;


    private Renderer rend;
    private Color starColor;

    public static bool torretType = true;

    public GameObject crossbow;
    public GameObject quiver;
    //public GameObject arrow;
    //private XRGrabInteractable grabIntArrow;


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
        if(Input.GetKeyDown(KeyCode.A))
        {
            BuyArrowTower();
            
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            BuyBombTower();
        }


    }


    public void CreateTower()
    {
        if (turret != null)
        {
            Debug.Log("No puedes construir aqui");
            return;
        }

        if (torretType == false && PlayerStats.Money>=200) //Construye torreta de flechas
        {
            GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
            PlayerStats.Money -= 200;
        }

        if (torretType == true && PlayerStats.Money >=400) //Construye torreta de bombas
        {
            GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
            Instantiate(crossbow, transform.position + positionOffset + new Vector3(0, 5, 0), crossbow.transform.rotation);
            quiver.transform.position = transform.position + positionOffset + new Vector3(0, 5, 0);
            PlayerStats.Money -= 400;
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

   
     

    public void HoverEnter()
    {
        rend.material.color = hoverColor; //Cambia el color del tile si pasas el raton por encima
    }


    public void HoverExit()
    {
        rend.material.color = starColor;
    }

    public void BuyArrowTower()
    {
        torretType = true;
    }

    public void BuyBombTower()
    {
        torretType = false;
    }
}

using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;

    private GameObject turret;


    private Renderer rend;
    private Color starColor;


    private void Start()
    {

        rend = GetComponent<Renderer>();
        starColor = rend.material.color;

    }
    public void CreateArrowTower()
    {
        if (turret != null)
        {
            Debug.Log("No puedes construir aqui");
            return;
        }

        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
        PlayerStats.Money -= 100;
    }

    public void OnMouseDown()
    {
        CreateArrowTower();
    }

    public void OnMouseEnter()
    {
        rend.material.color = hoverColor; //Cambia el color del tile si pasas el raton por encima
    }
    public void OnMouseExit()
    {
        rend.material.color = starColor;
    }

    /*
     
    public void HoverEnter()
    {
        rend.material.color = hoverColor; //Cambia el color del tile si pasas el raton por encima
    }


    public void HoverExit()
    {
        rend.material.color = starColor;
    }
    */


}

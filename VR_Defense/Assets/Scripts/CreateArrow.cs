using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class CreateArrow : MonoBehaviour
{
    private GameObject arrowGO;
    public GameObject arrowPrefab;
    private Transform quiverTrans;
    //public XRDirectInteractor rHand;
    //public XRDirectInteractor lHand;

    private void Start()
    {
        quiverTrans = GetComponent<Transform>();
        arrowGO = null;
    }
    public void NewArrow()
    {
        //if(arrowGO != null)
        {
            //Destroy(arrowGO);
            ArrowShoot.arrowShooted = false;
            arrowGO = Instantiate(arrowPrefab, quiverTrans.position, quiverTrans.rotation);

        }
        //else if( arrowGO == null)
        {
            //ArrowShoot.arrowShooted = false;
            //arrowGO = Instantiate(arrowPrefab, quiverTrans.position, quiverTrans.rotation);
        }

    }
}

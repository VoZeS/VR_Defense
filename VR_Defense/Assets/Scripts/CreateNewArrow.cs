using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class CreateNewArrow : MonoBehaviour
{
    public GameObject[] arrowGO;
    public GameObject arrowPrefab;
    private Transform quiverTrans;
    public XRDirectInteractor rHand;
    public XRDirectInteractor lHand;

    
    private void Start()
    {
        quiverTrans = GetComponent<Transform>();

        arrowGO = new GameObject[5];
        //for (int i = 0; i < 5; i++)
        //{
        //    arrowGO[i] = null;
        //}
    }

    public void NewArrow()
    {
        for (int i = 0; i < 5; i++)
        {
            //if (arrowGO[i] != null)
            {
                //Destroy(arrowGO[i]);
                ArrowShoot.arrowShooted = false;
                //arrowGO[i].SetActive(true);
                //return;
                //arrowGO[i] = Instantiate(arrowPrefab, quiverTrans.position, quiverTrans.rotation);


                //if(lHand.)
            }
            //else if (arrowGO[i] == null)
            //{
            //    //Destroy(arrowGO[i]);
            //    ArrowShoot.arrowShooted = false;
            //    arrowGO[i].SetActive(true);
            //    //arrowGO[i] = Instantiate(arrowPrefab, quiverTrans.position, quiverTrans.rotation);

            //}
        }

    }
}
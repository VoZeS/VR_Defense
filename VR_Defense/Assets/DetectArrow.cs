using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectArrow : MonoBehaviour
{
    public CreateArrow createArrowScript;
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Arrow")
        {
            Debug.Log("CreatedArrow");
            createArrowScript.NewArrow();
        }
    }
}

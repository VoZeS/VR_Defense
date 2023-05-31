using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions;

public class ArrowShoot : MonoBehaviour
{
    public XRSocketInteractor socket;

    public float timer = 0.0f;

    private void Update()
    {
        timer += Time.deltaTime;

        //Debug.Log(timer);

        if (timer >= 1.0f)
            socket.socketActive = true;

    }
    public void ShootArrow()
    {
        //Debug.Log(socket.GetOldestInteractableSelected().selectEntered.ToString());

        ArrowLogic.arrowShooted = true;
        socket.socketActive = false;
        timer = 0.0f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ArrowShoot : MonoBehaviour
{
    public string arrowTag = "Arrow";

    public XRSocketInteractor socket;

    private bool arrowInPosition = false;
    public static bool arrowShooted = false;

    public float timer = 0.0f;

    public void SetArrowInPosition(System.Boolean active)
    {
        arrowInPosition = active;
    }


    private void Update()
    {
        timer += Time.deltaTime;

        Debug.Log(timer);

        if (timer >= 2.0f)
            socket.socketActive = true;

    }
    public void ShootArrow()
    {
        arrowShooted = true;
        socket.socketActive = false;
        timer = 0.0f;
    }
}

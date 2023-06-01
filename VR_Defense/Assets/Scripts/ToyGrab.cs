using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ToyGrab : MonoBehaviour
{
    public XRDirectInteractor rHand;
    public XRDirectInteractor lHand;

    public XRRayInteractor rayRightHand;
    public XRRayInteractor rayLeftHand;

    public IXRSelectInteractable toyBombTower;
    public IXRSelectInteractable toyArrowTower;

    public ToggleRay rightRayScript;
    public ToggleRay leftRayScript;

    public XRInteractorLineVisual rightLineVisual;
    public XRInteractorLineVisual leftLineVisual;

    private bool toggleRayLeft = false;
    private bool toggleRayRight = false;

    // Start is called before the first frame update
    void Start()
    {
        toyBombTower = GameObject.FindGameObjectWithTag("ToyBombTower").GetComponent<XRGrabInteractable>();
        toyArrowTower = GameObject.FindGameObjectWithTag("ToyArrowTower").GetComponent<XRGrabInteractable>();



        toggleRayLeft = false;
        toggleRayRight = false;
    }

    void Update()
    {

        if (rHand.IsSelecting(toyBombTower) || rHand.IsSelecting(toyArrowTower))
        {
            if (rHand.IsSelecting(toyBombTower))
            {
                rightLineVisual.invalidColorGradient = bomb_InvalidColorGradient;

            }
            else if (rHand.IsSelecting(toyArrowTower))
            {
                rightLineVisual.invalidColorGradient = arrow_InvalidColorGradient;

            }

            //rightRayScript.directInteractor = rHand;
            rayRightHand.interactionLayers = InteractionLayerMask.GetMask("Node");
            rightRayScript.ActivateRay();
            toggleRayRight = true;

        }
        else if (!rHand.isSelectActive && toggleRayRight)
        {
            rightRayScript.DeactivateRay();
            rayRightHand.interactionLayers = InteractionLayerMask.GetMask("TP");
            rightLineVisual.invalidColorGradient = TP_InvalidColorGradient;
            toggleRayRight = false;
        }


        if (lHand.IsSelecting(toyBombTower) || lHand.IsSelecting(toyArrowTower))
        {
            if (lHand.IsSelecting(toyBombTower))
            {
                leftLineVisual.invalidColorGradient = bomb_InvalidColorGradient;

            }
            else if (lHand.IsSelecting(toyArrowTower))
            {
                leftLineVisual.invalidColorGradient = arrow_InvalidColorGradient;

            }

            //leftRayScript.directInteractor = lHand;
            rayLeftHand.interactionLayers = InteractionLayerMask.GetMask("Node");
            leftRayScript.ActivateRay();
            toggleRayLeft = true;

        }
        else if (!lHand.isSelectActive && toggleRayLeft)
        {
            leftRayScript.DeactivateRay();
            rayLeftHand.interactionLayers = InteractionLayerMask.GetMask("TP");
            leftLineVisual.invalidColorGradient = TP_InvalidColorGradient;
            toggleRayLeft = false;
        }

    }

    //-------------------------------------------------------- MAGENTA GRADIENT (BOMB)
    Gradient bomb_InvalidColorGradient = new Gradient
    {
        colorKeys = new[] { new GradientColorKey(Color.magenta, 0f), new GradientColorKey(Color.yellow, 1f) },
        alphaKeys = new[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(1f, 1f) },
    };
    public Gradient bomb_invalidColorGradient
    {
        get => bomb_InvalidColorGradient;
        set => bomb_InvalidColorGradient = value;
    }
    //--------------------------------------------------------

    //-------------------------------------------------------- RED GRADIENT (BOMB)
    Gradient TP_InvalidColorGradient = new Gradient
    {
        colorKeys = new[] { new GradientColorKey(Color.red, 0f), new GradientColorKey(Color.red, 1f) },
        alphaKeys = new[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(1f, 1f) },
    };
    public Gradient TP_invalidColorGradient
    {
        get => TP_InvalidColorGradient;
        set => TP_InvalidColorGradient = value;
    }
    //--------------------------------------------------------

    //-------------------------------------------------------- BLUE GRADIENT (ARROW)
    Gradient arrow_InvalidColorGradient = new Gradient
    {
        colorKeys = new[] { new GradientColorKey(Color.blue, 0f), new GradientColorKey(Color.yellow, 1f) },
        alphaKeys = new[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(1f, 1f) },
    };
    public Gradient arrow_invalidColorGradient
    {
        get => arrow_InvalidColorGradient;
        set => arrow_InvalidColorGradient = value;
    }
    //--------------------------------------------------------
}

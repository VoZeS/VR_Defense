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

    public XRGrabInteractable toyBombTower;
    public XRGrabInteractable toyArrowTower;

    public ToggleRay rightRayScript;
    public ToggleRay leftRayScript;

    public XRInteractorLineVisual rightLineVisual;
    public XRInteractorLineVisual leftLineVisual;

    public XRSocketInteractor socketTower1;
    public XRSocketInteractor socketTower2;

    private bool toggleRayLeft = false;
    private bool toggleRayRight = false;

    public bool hasBombTower_Right = false;
    public bool hasArrowTower_Right = false;
    public bool hasBombTower_Left = false;
    public bool hasArrowTower_Left = false;

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
                rayRightHand.interactionLayers = InteractionLayerMask.GetMask("ToyTowerBomb");
                hasBombTower_Right = true;
                hasArrowTower_Right = false;
            }
            else if (rHand.IsSelecting(toyArrowTower))
            {
                rightLineVisual.invalidColorGradient = arrow_InvalidColorGradient;
                rayRightHand.interactionLayers = InteractionLayerMask.GetMask("ToyTowerArrow");
                hasBombTower_Right = false;
                hasArrowTower_Right = true;
            }

            //rightRayScript.directInteractor = rHand;
            rightRayScript.ActivateRay();
            toggleRayRight = true;

        }
        else if (!rHand.isSelectActive && toggleRayRight)
        {
            rightRayScript.DeactivateRay();
            rayRightHand.interactionLayers = InteractionLayerMask.GetMask("TP");
            rightLineVisual.invalidColorGradient = TP_InvalidColorGradient;
            toggleRayRight = false;
            hasBombTower_Right = false;
            hasArrowTower_Right = false;
        }
        else if (hasBombTower_Right)
        {
            toyBombTower.gameObject.transform.position = rayRightHand.transform.position;
            toyBombTower.gameObject.transform.rotation = rayRightHand.transform.rotation;

        }   
        else if (hasArrowTower_Right)
        {
            toyArrowTower.gameObject.transform.position = rayRightHand.transform.position;
            toyArrowTower.gameObject.transform.rotation = rayRightHand.transform.rotation;

        }

        if (lHand.IsSelecting(toyBombTower) || lHand.IsSelecting(toyArrowTower))
        {
            if (lHand.IsSelecting(toyBombTower))
            {
                leftLineVisual.invalidColorGradient = bomb_InvalidColorGradient;
                rayLeftHand.interactionLayers = InteractionLayerMask.GetMask("ToyTowerBomb");
                hasBombTower_Left = true;
                hasArrowTower_Left = false;
            }
            else if (lHand.IsSelecting(toyArrowTower))
            {
                leftLineVisual.invalidColorGradient = arrow_InvalidColorGradient;
                rayLeftHand.interactionLayers = InteractionLayerMask.GetMask("ToyTowerArrow");
                hasBombTower_Left = false;
                hasArrowTower_Left = true;
            }

            //leftRayScript.directInteractor = lHand;
            leftRayScript.ActivateRay();
            toggleRayLeft = true;

        }
        else if (!lHand.isSelectActive && toggleRayLeft)
        {
            leftRayScript.DeactivateRay();
            rayLeftHand.interactionLayers = InteractionLayerMask.GetMask("TP");
            leftLineVisual.invalidColorGradient = TP_InvalidColorGradient;
            toggleRayLeft = false;
            hasBombTower_Left = false;
            hasArrowTower_Left = false;
        }
        else if (hasBombTower_Left)
        {
            toyBombTower.gameObject.transform.position = rayLeftHand.transform.position;
            toyBombTower.gameObject.transform.rotation = rayLeftHand.transform.rotation;

        }
        else if (hasArrowTower_Left)
        {
            toyArrowTower.gameObject.transform.position = rayLeftHand.transform.position;
            toyArrowTower.gameObject.transform.rotation = rayLeftHand.transform.rotation;

        }

    }

    //-------------------------------------------------------- MAGENTA GRADIENT (BOMB)
    Gradient bomb_InvalidColorGradient = new Gradient
    {
        colorKeys = new[] { new GradientColorKey(Color.magenta, 0f), new GradientColorKey(Color.white, 1f) },
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
        colorKeys = new[] { new GradientColorKey(Color.blue, 0f), new GradientColorKey(Color.white, 1f) },
        alphaKeys = new[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(1f, 1f) },
    };
    public Gradient arrow_invalidColorGradient
    {
        get => arrow_InvalidColorGradient;
        set => arrow_InvalidColorGradient = value;
    }
    //--------------------------------------------------------
}

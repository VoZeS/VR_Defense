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

    public XRGrabInteractable[] toyBombTower;
    public XRGrabInteractable[] toyArrowTower;

    public ToggleRay rightRayScript;
    public ToggleRay leftRayScript;

    public XRInteractorLineVisual rightLineVisual;
    public XRInteractorLineVisual leftLineVisual;

    private bool toggleRayLeft = false;
    private bool toggleRayRight = false;

    public bool hasBombTower_Right = false;
    public bool hasArrowTower_Right = false;
    public bool hasBombTower_Left = false;
    public bool hasArrowTower_Left = false;

    // Start is called before the first frame update
    void Start()
    {
        toggleRayLeft = false;
        toggleRayRight = false;
    }

    void Update()
    {
        for(int i = 0; i < toyBombTower.Length; i++)
        {
            // Right Hand
            if (rHand.IsSelecting(toyBombTower[i]) || rHand.IsSelecting(toyArrowTower[i]))
            {
                if (rHand.IsSelecting(toyBombTower[i]))
                {
                    rightLineVisual.invalidColorGradient = bomb_InvalidColorGradient;
                    rayRightHand.interactionLayers = InteractionLayerMask.GetMask("ToyTowerBomb");
                    hasBombTower_Right = true;
                    hasArrowTower_Right = false;
                }
                else if (rHand.IsSelecting(toyArrowTower[i]))
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

                toyBombTower[i].gameObject.transform.position = rayRightHand.transform.position;
                toyBombTower[i].gameObject.transform.rotation = rayRightHand.transform.rotation;

            }
            else if (hasArrowTower_Right)
            {
                toyArrowTower[i].gameObject.transform.position = rayRightHand.transform.position;
                toyArrowTower[i].gameObject.transform.rotation = rayRightHand.transform.rotation;

            }

            // Left Hand
            if (lHand.IsSelecting(toyBombTower[i]) || lHand.IsSelecting(toyArrowTower[i]))
            {
                if (lHand.IsSelecting(toyBombTower[i]))
                {
                    leftLineVisual.invalidColorGradient = bomb_InvalidColorGradient;
                    rayLeftHand.interactionLayers = InteractionLayerMask.GetMask("ToyTowerBomb");
                    hasBombTower_Left = true;
                    hasArrowTower_Left = false;
                }
                else if (lHand.IsSelecting(toyArrowTower[i]))
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
                toyBombTower[i].gameObject.transform.position = rayLeftHand.transform.position;
                toyBombTower[i].gameObject.transform.rotation = rayLeftHand.transform.rotation;

            }
            else if (hasArrowTower_Left)
            {
                toyArrowTower[i].gameObject.transform.position = rayLeftHand.transform.position;
                toyArrowTower[i].gameObject.transform.rotation = rayLeftHand.transform.rotation;

            }
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

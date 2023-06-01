using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ToyGrab : MonoBehaviour
{
    public XRDirectInteractor rHand;
    public XRDirectInteractor lHand;

    public IXRSelectInteractable toyBombTower;
    public IXRSelectInteractable toyArrowTower;

    public ToggleRay rightRayScript;
    public ToggleRay leftRayScript;
    public XRInteractorLineVisual rightLineVisual;
    public XRInteractorLineVisual leftLineVisual;

    // Start is called before the first frame update
    void Start()
    {
        toyBombTower = GameObject.FindGameObjectWithTag("ToyBombTower").GetComponent<XRGrabInteractable>();
        toyArrowTower = GameObject.FindGameObjectWithTag("ToyArrowTower").GetComponent<XRGrabInteractable>();
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

            rightRayScript.directInteractor = rHand;
            rightRayScript.ActivateRay();

        }
        else if (!rHand.isSelectActive)
            rightRayScript.DeactivateRay();


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

            leftRayScript.directInteractor = lHand;
            leftRayScript.ActivateRay();

        }
        else if (!lHand.isSelectActive)
            leftRayScript.DeactivateRay();

    }

    //-------------------------------------------------------- RED GRADIENT (BOMB)
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

    //-------------------------------------------------------- GREEN GRADIENT (ARROW)
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

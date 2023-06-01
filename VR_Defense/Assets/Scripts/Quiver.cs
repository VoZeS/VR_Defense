using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions;

public class Quiver : XRSocketInteractor
{
    public GameObject arrowPrefab = null;
    private Vector3 attachedOffset = Vector3.zero;

    protected override void Awake()
    {
        base.Awake();
        CreateAndSelectArrow();
        SetAttachOffset();
    }

    protected override void OnSelectExited(XRBaseInteractable interactable)
    {
        base.OnSelectExited(interactable);
        CreateAndSelectArrow();
    }

    private void CreateAndSelectArrow()
    {
        Arrow arrow = CreateArrow();
        SelectArrow(arrow);
    }

    private Arrow CreateArrow()
    {
        GameObject arrowObject = Instantiate(arrowPrefab, transform.position - attachedOffset, transform.rotation);
        return arrowObject.GetComponent<Arrow>();
    }

    private void SelectArrow(Arrow arrow)
    {
        OnSelectEntered(arrow);
        arrow.OnSelectEntered(this);

    }

    private void SetAttachOffset()
    {
        if(selectTarget is XRGrabInteractable interactable)
        {
            attachedOffset = interactable.attachTransform.localPosition;
        }
    }
}

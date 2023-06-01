using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Arrow : XRGrabInteractable
{
    protected override void Awake()
    {
        base.Awake();
    }

    private void FixedUpdate()
    {
        
    }

    private void CheckForCollision()
    {

    }

    private void Stop()
    {
        
    }

    public void Release(float pullValue)
    {

    }

    public void SetPhysics(bool usePhysics)
    {

    }

    private void MaskAndFire(float power)
    {

    }

    private IEnumerator RotateWithVelocity()
    {
        yield return null;
    }

    public new void OnSelectEntered(XRBaseInteractor interactor)
    {
        base.OnSelectEntered(interactor);
    }

    public new void OnSelectExited(XRBaseInteractor interactor)
    {
        base.OnSelectExited(interactor);
    }
}

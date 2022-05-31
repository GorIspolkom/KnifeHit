using UnityEngine;

public sealed class Knife : MonoBehaviour, IInteractable, IObserver
{
    [SerializeField] private Rigidbody _rb;
    private bool _isUsable = true;
    private Transform _targetTransform;

    private void OnCollisionEnter(Collision collision)
    {
        if (!_isUsable && collision.transform.Equals(_targetTransform))
            Debug.Log("Knife in knife");
    }

    public void Throw(Vector3 throwVector, float throwVelocity)
    {
        _rb.AddForce(throwVector * throwVelocity, ForceMode.Impulse);
        Interact();
    }

    public void Interact()
    {
        _isUsable = false;
    }

    public void Notify(Transform transform)
    {
        _targetTransform = transform;
    }
}

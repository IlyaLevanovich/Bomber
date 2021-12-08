using UnityEngine;
using UnityEngine.EventSystems;

public class UIPressing : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] Movement _playerMovement;
    [SerializeField] private Vector3 _direction, _rotation;
    [SerializeField] private string _animationName;


    public void OnPointerDown(PointerEventData eventData)
    {
        _playerMovement.Move(_direction, _animationName);
        _playerMovement.transform.rotation = Quaternion.Euler(_rotation);
        transform.localScale *= 1.2f;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        transform.localScale /= 1.2f;
    }
}

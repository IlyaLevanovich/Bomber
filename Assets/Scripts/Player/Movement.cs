using UnityEngine;

[RequireComponent(typeof(AnimationSwitcher))]
public class Movement : MonoBehaviour
{
    [SerializeField] private Transform _movePoint;
    [SerializeField] private LayerMask _stopMovement;
    private float _moveSpeed = 3f;
    private AnimationSwitcher _switcher;
    

    private void Start()
    {
        _movePoint.parent = null;
        _switcher = GetComponent<AnimationSwitcher>();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _movePoint.position, _moveSpeed * Time.deltaTime);

        if (Vector2.Distance(transform.position, _movePoint.position) > 0.5f)
            return;
    }

    public void Move(Vector3 direction, string animationName)
    {
        if (!IsFreeWay(direction))
        {
            _movePoint.position += direction;
            _switcher.Move(animationName);
        }
    }

    private bool IsFreeWay(Vector3 direction)
    {
        return Physics2D.OverlapCircle(_movePoint.position + direction, 0.2f, _stopMovement);
    }

}

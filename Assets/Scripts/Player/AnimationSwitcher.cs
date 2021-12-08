using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationSwitcher : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    
    public void Move(string animationName) => SetTrigger(animationName);

    public void Hold() => SetTrigger("Hold");

    public void Dead() => SetTrigger("Dead");

    private void SetTrigger(string triggerName)
    {
        _animator.SetTrigger(triggerName);
    }
}

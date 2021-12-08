using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private Vector3 _direction;
    private SpriteRenderer _renderer;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
        StartCoroutine(SetDirection());
    }
    private void Update()
    {
        _rigidbody.MovePosition(transform.position + _direction * _speed * Time.deltaTime);
    }
    private IEnumerator SetDirection()
    {
        while(true)
        {
            yield return new WaitForSeconds(5);
            _direction = -_direction;
            _renderer.flipX =  !_renderer.flipX;
        }
    }

}

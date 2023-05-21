using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2D;
        private Animator _animator;
        private SpriteRenderer _spriteRenderer;
        
        [SerializeField] private float _speed;
        private Vector2 _force;

        private void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            var h = Input.GetAxisRaw("Horizontal");
            if (h == 0)
            {
                _animator.Play("Stand");
            }
            else
            {
                _spriteRenderer.flipX = h > 0;
                _animator.Play("Walk");
                _force.x = h * _speed;
                _rigidbody2D.AddForce(_force);
            }
        }
    }
}
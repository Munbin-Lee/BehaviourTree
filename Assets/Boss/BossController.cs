using UnityEngine;

namespace Boss
{
    public class BossController : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2D, _playerRigidbody2D;
        private Animator _animator;
        private SpriteRenderer _spriteRenderer;

        [SerializeField] private float _speed;
        private Vector2 _velocity = new(-1,0);
        private bool _isIdle;
        private const string _stand = "Stand";
        private const string _move = "Move";
        private const string _attack1 = "Attack1";
        private const string _attack2 = "Attack2";

        private void ChangeState(string state)
        {
            _animator.Play(state);
            _isIdle = state is _stand or _move;
        }
        
        private void Start()
        {
            var player = GameObject.FindWithTag("Player");
            _playerRigidbody2D = player.GetComponent<Rigidbody2D>();
            
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
            
            ChangeState(_stand);
        }

        public bool IsIdle()
        {
            return _isIdle;
        }

        public bool IsPlayerBehind()
        {
            return _spriteRenderer.flipX == _rigidbody2D.position.x > _playerRigidbody2D.position.x;
        }

        public void Flip()
        {
            _spriteRenderer.flipX ^= true;
            _velocity.x *= -1;
        }

        public bool IsPlayerNear(float allowDistance)
        {
            var dist = Mathf.Abs(_rigidbody2D.position.x - _playerRigidbody2D.position.x);
            return dist < allowDistance;
        }

        public void Move()
        {
            ChangeState(_move);
            _rigidbody2D.velocity = _velocity * _speed;
        }

        public void Attack1()
        {
            if (_animator.GetCurrentAnimatorClipInfo(0)[0].clip.name is _attack1 or _attack2) return;
            ChangeState(_attack1);
        }

        public void Attack2()
        {
            if (_animator.GetCurrentAnimatorClipInfo(0)[0].clip.name is _attack1 or _attack2) return;
            ChangeState(_attack2);
        }

        public void OnAttackFinished()
        {
            ChangeState(_stand);
        }
    }
}

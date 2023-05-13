using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody2D rb;
        private Animator anim;
        private SpriteRenderer sprite;
        
        private Vector2 movementDirection;
        private static readonly int IsStand = Animator.StringToHash("isStand");

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            anim = GetComponent<Animator>();
            sprite = GetComponent<SpriteRenderer>();
        }

        void Update()
        {
            var h = Input.GetAxisRaw("Horizontal");
            anim.SetBool(IsStand, h == 0);
            sprite.flipX = h switch
            {
                < 0 => false,
                > 0 => true,
                _ => sprite.flipX
            };
            movementDirection.x = h * 5;
            rb.velocity = movementDirection;
        }
    }
}
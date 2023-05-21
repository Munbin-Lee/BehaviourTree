using MBT;
using UnityEngine;

namespace Boss.Behaviour
{
    [AddComponentMenu("")]
    [MBTNode(name = "Boss/Move")]
    
    public class Move : Leaf
    {
        private BossController _bossController;

        private void Start()
        {
            _bossController = GetComponent<BossController>();
        }

        public override NodeResult Execute()
        {
            _bossController.Move();
            return NodeResult.success;
        }
    }
}
using MBT;
using UnityEngine;

namespace Boss.Behaviour
{
    [AddComponentMenu("")]
    [MBTNode(name = "Boss/Attack2")]
    
    public class Attack2 : Leaf
    {
        private BossController _bossController;

        private void Start()
        {
            _bossController = GetComponent<BossController>();
        }

        public override NodeResult Execute()
        {
            _bossController.Attack2();
            return NodeResult.success;
        }
    }
}
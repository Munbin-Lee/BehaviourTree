using MBT;
using UnityEngine;

namespace Boss.Behaviour
{
    [AddComponentMenu("")]
    [MBTNode(name = "Boss/Attack1")]
    
    public class Attack1 : Leaf
    {
        private BossController _bossController;

        private void Start()
        {
            _bossController = GetComponent<BossController>();
        }

        public override NodeResult Execute()
        {
            _bossController.Attack1();
            return NodeResult.success;
        }
    }
}
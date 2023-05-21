using MBT;
using UnityEngine;

namespace Boss.Behaviour
{
    [AddComponentMenu("")]
    [MBTNode(name = "Boss/IsIdle")]
    
    public class IsIdle : Leaf
    {
        private BossController _bossController;

        private void Start()
        {
            _bossController = GetComponent<BossController>();
        }

        public override NodeResult Execute()
        {
            return _bossController.IsIdle() ? NodeResult.success : NodeResult.failure;
        }
    }
}
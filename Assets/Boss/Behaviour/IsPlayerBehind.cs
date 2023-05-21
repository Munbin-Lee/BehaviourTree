using MBT;
using UnityEngine;

namespace Boss.Behaviour
{
    [AddComponentMenu("")]
    [MBTNode(name = "Boss/IsPlayerBehind")]
    
    public class IsPlayerBehind : Leaf
    {
        private BossController _bossController;
        
        private void Start()
        {
            _bossController = GetComponent<BossController>();
        }

        public override NodeResult Execute()
        {
            return _bossController.IsPlayerBehind() ? NodeResult.success : NodeResult.failure;
        }
    }
}
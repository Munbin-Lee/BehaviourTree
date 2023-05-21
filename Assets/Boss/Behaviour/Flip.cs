using MBT;
using UnityEngine;

namespace Boss.Behaviour
{
    [AddComponentMenu("")]
    [MBTNode(name = "Boss/Flip")]
    
    public class Flip : Leaf
    {
        private BossController _bossController;

        private void Start()
        {
            _bossController = GetComponent<BossController>();
        }

        public override NodeResult Execute()
        {
            _bossController.Flip();
            return NodeResult.success;
        }
    }
}
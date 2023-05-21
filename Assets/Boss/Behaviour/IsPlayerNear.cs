using MBT;
using UnityEngine;

namespace Boss.Behaviour
{
    [AddComponentMenu("")]
    [MBTNode(name = "Boss/IsPlayerNear")]
    
    public class IsPlayerNear : Leaf
    {
        private BossController _bossController;
        
        [SerializeField] private float _allowDistance;
        
        private void Start()
        {
            _bossController = GetComponent<BossController>();
        }

        public override NodeResult Execute()
        {
            return _bossController.IsPlayerNear(_allowDistance) ? NodeResult.success : NodeResult.failure;
        }
    }
}
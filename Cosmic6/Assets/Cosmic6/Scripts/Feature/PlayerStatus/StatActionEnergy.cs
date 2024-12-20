using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DevionGames.InventorySystem.ItemActions
{
    [Icon("Stat")]
    [ComponentMenu("Inventory System/Modify Energy")]
    [System.Serializable]
    public class StatActionEnergy : ItemAction
    {
        [SerializeField]
        private int m_Amount = 10; // 변경할 값: 양수 증가, 음수 감소

        public override ActionStatus OnUpdate()
        {
            var playerStatus = UnityEngine.Object.FindObjectOfType<PlayerStatusController>();
            if (playerStatus == null)
            {
                Debug.LogWarning("PlayerStatusController를 찾을 수 없습니다.");
                return ActionStatus.Failure;
            }

            playerStatus.UpdateEnergy(m_Amount, true);
            Debug.Log($"Energy를 {m_Amount}만큼 변경했습니다.");
            return ActionStatus.Success;
        }
    }
}

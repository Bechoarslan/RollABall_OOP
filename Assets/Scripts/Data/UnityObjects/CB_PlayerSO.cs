
using UnityEngine;

namespace Data.UnityObjects
{
    [CreateAssetMenu(fileName = "Data", menuName = "Test/PlayerData", order = 0)]
    public class CB_PlayerSO : ScriptableObject
    {
        public PlayerData Data;
    }
}
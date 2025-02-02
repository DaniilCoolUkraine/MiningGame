using MiningGame.GridSystem.Core.Interfaces;
using UnityEngine;

namespace MiningGame.GridSystem.Extendables
{
    public abstract class MonoBehaviourCell : MonoBehaviour, ICell
    {
        public abstract bool InitializeCell(int x, int y);
    }
}
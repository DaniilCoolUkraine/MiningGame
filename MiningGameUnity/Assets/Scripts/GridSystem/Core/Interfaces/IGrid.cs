using UnityEngine;

namespace MiningGame.GridSystem.Core.Interfaces
{
    public interface IGrid
    {
        public Vector2Int Size { get; }

        public void SetElement(int x, int y, ICell element);
        public ICell GetElement(int x, int y);
    }
}
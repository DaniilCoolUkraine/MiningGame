using System.Collections.Generic;
using System.Linq;
using MiningGame.GridSystem.Core.Interfaces;
using MiningGame.GridSystem.General;
using UnityEngine;

namespace MiningGame.GridSystem.Core
{
    public class Grid : IGrid
    {
        public Vector2Int Size { get; private set; }
        private ICell[] _cells;

        public Grid(int width, int height, IEnumerable<ICell> cells)
        {
            Size = new Vector2Int(width, height);
            _cells = cells.ToArray();
        }

        public void SetElement(int x, int y, ICell element)
        {
            _cells[Utils.GetIndex(x, y, Size.x)] = element;
        }

        public ICell GetElement(int x, int y)
        {
            return _cells[Utils.GetIndex(x, y, Size.x)];
        }
    }
}
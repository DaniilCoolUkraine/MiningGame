using System.Collections.Generic;
using MiningGame.GridSystem.Core.Interfaces;
using MiningGame.GridSystem.General;
using MiningGame.Infrastructure;
using UnityEngine;
using Zenject;
using Grid = MiningGame.GridSystem.Core.Grid;

namespace MiningGame.GridSystem
{
    public class GridManager : MonoBehaviour
    {
        [SerializeField] private Vector2Int _gridSize;

        [Inject] private IDataProvider _dataProvider;

        private IGrid _grid;

        public void Initialize()
        {
            _grid = new Grid(_gridSize.x, _gridSize.y, SetupCells());
        }

        private List<ICell> SetupCells()
        {
            List<ICell> cells = new List<ICell>();

            for (int x = 0; x < _gridSize.x; x++)
            {
                for (int y = 0; y < _gridSize.y; y++)
                {
                    var cell = Instantiate(_dataProvider.CellsDataTable.CellsPrefabs[0]);
                    cell.InitializeCell(x, y);

                    cell.transform.position = new Vector3(x * Constants.CELL_PER_UNIT, y * Constants.CELL_PER_UNIT, 0);

                    cells.Add(cell);
                }
            }

            return cells;
        }
    }
}

using System.Collections.Generic;
using MiningGame.GridSystem.Extendables;
using UnityEngine;

namespace MiningGame.GridSystem.Core
{
    [CreateAssetMenu(fileName = "CellsDataTable", menuName = "Grid/CellsDataTable", order = 0)]
    public class CellsDataTable : ScriptableObject
    {
        public List<MonoBehaviourCell> CellsPrefabs;
    }
}
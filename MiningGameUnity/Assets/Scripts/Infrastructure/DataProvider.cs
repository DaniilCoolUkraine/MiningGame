using MiningGame.GridSystem.Core;
using UnityEngine;

namespace MiningGame.Infrastructure
{
    public class DataProvider : MonoBehaviour, IDataProvider
    {
        [field:SerializeField] public CellsDataTable CellsDataTable { get; private set; }
    }
}
using MiningGame.GridSystem.Core;

namespace MiningGame.Infrastructure
{
    public interface IDataProvider
    {
        public CellsDataTable CellsDataTable { get; }
    }
}
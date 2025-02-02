using MiningGame.GridSystem;
using UnityEngine;

namespace MiningGame.Infrastructure
{
    public class AppLoader : MonoBehaviour
    {
        // TODO move to level scene specific boostraper 
        [SerializeField] private GridManager _gridManager;

        private void Awake()
        {
            _gridManager.Initialize();
        }
    }
}
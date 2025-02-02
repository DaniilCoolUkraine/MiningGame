using UnityEngine;
using Zenject;

namespace MiningGame.Infrastructure.Installers
{
    public class DataProviderInstaller : MonoInstaller
    {
        [SerializeField] private DataProvider _dataProvider;
        
        public override void InstallBindings()
        {
            Container.Bind<IDataProvider>().To<DataProvider>().FromInstance(_dataProvider).AsSingle();
        }
    }
}
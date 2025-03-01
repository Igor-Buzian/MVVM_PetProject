using Core.Interfaces.asmdef;
using Mvvm_Pet_Project.Score.Models;
using Mvvm_Pet_Project.Score.ViewModels;
using Mvvm_Pet_Project.ScoreViews;
using Zenject;

namespace Mvvm_Pet_Project.Score.Zenject

{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IModifiableValue>()
                .To<PlayerScoreModel>()
                .AsSingle();

            Container.Bind<PlayerScoreViewModel>()
                .AsSingle();
        }
    }
}

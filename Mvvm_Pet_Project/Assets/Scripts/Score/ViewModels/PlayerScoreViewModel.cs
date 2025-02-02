
using Mvvm_Pet_Project.Score.Models;

namespace Mvvm_Pet_Project.Score.ViewModels
{
    public class PlayerScoreViewModel
    {
        private readonly PlayerScoreModel _playerModel;

        public PlayerScoreViewModel(PlayerScoreModel playerModel)
        {
            _playerModel = playerModel;
        }

        public int Score => _playerModel.Score;

        public void AddScore(int points)
        {
            _playerModel.AddScore(points);
        }
    }
}

using System;
using Mvvm_Pet_Project.Score.Models;

namespace Mvvm_Pet_Project.Score.ViewModels
{
    public class PlayerScoreViewModel
    {

        private readonly PlayerScoreModel _scoreModel;

        // Событие для уведомления об изменении счета
        public event Action<int> OnScoreChanged;

        public PlayerScoreViewModel(PlayerScoreModel scoreModel)
        {
            _scoreModel = scoreModel;
        }

        public int CurrentScore => _scoreModel.Score;

        public void AddScore(int points)
        {
            _scoreModel.AddScore(points);
            // Вызываем событие при изменении счета
            OnScoreChanged?.Invoke(CurrentScore);
        }
    }
}
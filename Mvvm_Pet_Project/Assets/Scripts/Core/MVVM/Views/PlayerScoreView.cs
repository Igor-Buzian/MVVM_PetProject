using Mvvm_Pet_Project.Score.ViewModels; // Проверьте регистр в namespace!
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using System; 
namespace Mvvm_Pet_Project.ScoreViews
{
    public class PlayerScoreView : MonoBehaviour
    {
        [SerializeField] private Text _scoreText;
        private PlayerScoreViewModel _viewModel;

        [Inject]
        private void Construct(PlayerScoreViewModel viewModel)
        {
            _viewModel = viewModel;
            _viewModel.OnScoreChanged += UpdateScore; // Теперь событие распознаётся
            UpdateScore(_viewModel.CurrentValue);
        }

        public void OnAddScoreButtonClicked() => _viewModel.ChangeValue(10);

        private void UpdateScore(int score) => _scoreText.text = $"Score: {score}";

        private void OnDestroy()
        {
            if (_viewModel != null)
            {
                _viewModel.OnScoreChanged -= UpdateScore;
                (_viewModel as IDisposable)?.Dispose();
            }
        }
    }
}
using Mvvm_Pet_Project.Score.ViewModels;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using static UnityEditor.Profiling.HierarchyFrameDataView;

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
            // Подписываемся на событие
            _viewModel.OnScoreChanged += UpdateScore;
            UpdateScore(_viewModel.CurrentScore);
        }

        public void OnAddScoreButtonClicked()
        {
            _viewModel.AddScore(10);
        }

        private void UpdateScore(int score)
        {
            _scoreText.text = $"Score: {score}";
        }

        private void OnDestroy()
        {
            // Отписываемся при уничтожении объекта
            if (_viewModel != null)
            {
                _viewModel.OnScoreChanged -= UpdateScore;
            }
        }
    }
}
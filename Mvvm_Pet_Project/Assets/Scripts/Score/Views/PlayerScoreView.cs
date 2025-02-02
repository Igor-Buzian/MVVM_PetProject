using Mvvm_Pet_Project.Score.ViewModels;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Mvvm_Pet_Project.ScoreViews
{
    public class PlayerScoreView : MonoBehaviour
    {
        [SerializeField] private Text _scoreText;

        private PlayerScoreViewModel _viewModel;

        // �������� ����� Zenject
        [Inject]
        private void Construct(PlayerScoreViewModel viewModel)
        {
            _viewModel = viewModel;
            Initialize();
        }

        // ������������� UI
        private void Initialize()
        {
            UpdateScore();
        }

        // ���������� ������� ������
        public void OnAddScoreButtonClicked()
        {
            _viewModel.AddScore(10);
            UpdateScore();
        }

        // ���������� ����������� �����
        private void UpdateScore()
        {
            _scoreText.text = $"Score: {_viewModel.Score}";
        }
    }
}
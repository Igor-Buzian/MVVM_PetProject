using System; // Добавляем этот using для IDisposable
using Core.Interfaces.asmdef;

namespace Mvvm_Pet_Project.Score.ViewModels
{
    public class PlayerScoreViewModel : IDisposable // Теперь с использованием System
    {
        private readonly IModifiableValue _valueSource;
        public event Action<int> OnScoreChanged;

        public PlayerScoreViewModel(IModifiableValue valueSource)
        {
            _valueSource = valueSource;
            _valueSource.OnValueChanged += HandleValueChanged;
        }

        public int CurrentValue => _valueSource.Current;
        public void ChangeValue(int delta) => _valueSource.Modify(delta);

        private void HandleValueChanged(int newValue) => OnScoreChanged?.Invoke(newValue);

        // Реализация IDisposable
        public void Dispose()
        {
            _valueSource.OnValueChanged -= HandleValueChanged;
        }
    }
}
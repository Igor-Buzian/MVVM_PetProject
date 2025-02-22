
using System;
using Core.Interfaces.asmdef;
namespace Mvvm_Pet_Project.Score.Models
{
    public class PlayerScoreModel : IModifiableValue
    {
        public int Current { get; private set; }
        public event Action<int> OnValueChanged;

        public void Modify(int delta)
        {
            Current += delta;
            OnValueChanged?.Invoke(Current);
        }
    }
}
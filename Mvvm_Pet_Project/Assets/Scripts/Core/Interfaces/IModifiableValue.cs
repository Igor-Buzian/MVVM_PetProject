using System;
namespace Core.Interfaces.asmdef
{
    public interface IModifiableValue
    {
        int Current { get; }
        void Modify(int delta);
        event Action<int> OnValueChanged;
    }
}

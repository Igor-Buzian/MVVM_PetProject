using System;
namespace Core.Interfaces.asmdef
{
    public interface IInteractable
    {
        bool CanInteract { get; }
        void Interact();
        event Action OnInteraction;
    }
}

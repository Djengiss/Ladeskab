using static Ladeskab.lib.Interfaces.Door;

namespace Ladeskab.lib.Interfaces
{
    public interface IDoor
    {
        void LockDoor();
        void UnlockDoor();

        void OnDoorOpen();
        void OnDoorClose();

        event EventHandler<DoorEventArgs>? DoorEvent;
    }
}
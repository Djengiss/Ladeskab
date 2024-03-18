using static Ladeskab.lib.Interfaces.Door;

namespace Ladeskab.lib.Interfaces
{
    public interface IDoor
    {
        void LockDoor();
        void UnlockDoor();

        event EventHandler<DoorEventArgs>? DoorEvent;
    }
}
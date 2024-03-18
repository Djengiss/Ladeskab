using System;

namespace Ladeskab.lib.Interfaces
{
    public class Door : IDoor
    {
        private bool isOpen;
        private bool isLocked;

        public void LockDoor()
        {
            isLocked = true;
            OnDoorEvent(new DoorEventArgs(isLocked));
        }

        public void UnlockDoor()
        {
            isLocked = false;
            OnDoorEvent(new DoorEventArgs(isLocked));
        }

        protected virtual void OnDoorEvent(DoorEventArgs e)
        {
            DoorEvent?.Invoke(this, e);
        }

        public event EventHandler<DoorEventArgs>? DoorEvent;

        public class DoorEventArgs : EventArgs
        {
            public bool IsLocked { get; }

            public DoorEventArgs(bool isLocked)
            {
                IsLocked = isLocked;
            }
        }
    }
}
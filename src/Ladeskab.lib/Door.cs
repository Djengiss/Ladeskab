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
        }

        public void UnlockDoor()
        {
            isLocked = false;
        }

        public void OnDoorOpen()
        {
            isOpen = true;
            OnDoorEvent(new DoorEventArgs(isOpen));
        }

        public void OnDoorClose()
        {
            isOpen = false;
            OnDoorEvent(new DoorEventArgs(isOpen));
        }

        protected virtual void OnDoorEvent(DoorEventArgs e)
        {
            DoorEvent?.Invoke(this, e);
        }

        public event EventHandler<DoorEventArgs>? DoorEvent;

        public class DoorEventArgs : EventArgs
        {
            public bool IsOpen { get; }

            public DoorEventArgs(bool isOpen)
            {
                IsOpen = isOpen;
            }
        }
    }
}
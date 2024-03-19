using System;

namespace Ladeskab.lib.Interfaces
{
    public class Door : IDoor
    {
        public bool isOpen { get; private set; } = false;
        public bool isLocked { get; private set; } = false;

        public void LockDoor()
        {
            if (!isOpen)
            {
                isLocked = true;
            }
        }

        public void UnlockDoor()
        {
            isLocked = false;
        }

        public void OnDoorOpen()
        {
            if (!isLocked && !isOpen)
            {
                isOpen = true;
                OnDoorEvent(new DoorEventArgs(isOpen));
            }
        }

        public void OnDoorClose()
        {
            if (isOpen)
            { 
                isOpen = false;
                OnDoorEvent(new DoorEventArgs(isOpen));
            }
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
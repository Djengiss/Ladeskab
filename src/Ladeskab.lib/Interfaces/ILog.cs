namespace Ladeskab.lib.Interfaces
{
    public interface ILog
    {
        void LogDoorLocked();
        void LogDoorUnlocked();
        void ReadLog();
    }
}
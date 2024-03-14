namespace Ladeskab.lib
{
    public interface ILog
    {
        void LogDoorLocked();
        void LogDoorUnlocked();
        void ReadLog();
    }
}
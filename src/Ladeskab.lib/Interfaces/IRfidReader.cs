
namespace Ladeskab.lib.Interfaces
{
    public interface IRfidReader
    {
        string ReadRfid();
        void OnRfidRead(int id);
    }
}

namespace Ladeskab.lib.Interfaces
{
    public interface IRfidReader
    {
        event EventHandler<int> RfidChanged;
        void OnRfidRead(int id);
    }
}

namespace Ladeskab.lib.Interfaces
{
    public class RfidEventArgs : EventArgs
    {
        public int Rfid { get; private set; }

        public RfidEventArgs(int rfid)
        {
            Rfid = rfid;
        }
    }
    public interface IRfidReader
    {
        public event EventHandler<RfidEventArgs> RfidChanged;
        void OnRfidRead(int id);
    }
}
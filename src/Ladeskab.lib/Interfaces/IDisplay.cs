namespace Ladeskab.lib.Interfaces
{
    public interface IDisplay
    {
        void ClearDisplay();
        void FjernTlf();
        void IndlæsRFID();
        void Optaget();
        void RFIDfejl();
        void Tilslutningsfejl();
        void TilslutTlf();
        void IsCharging();
        void IsNotCharging();
    }
}
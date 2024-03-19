namespace Ladeskab.lib.Interfaces
{
    public interface IDisplay
    {
        public string displayText { get; }
        void ClearDisplay();
        void FjernTlf();
        void IndlæsRFID();
        void Optaget();
        void RFIDfejl();
        void Tilslutningsfejl();
        void TilslutTlf();
        void IsCharging();
        void IsNotCharging();
        void Overload();
    }
}
namespace Ladeskab.lib.Interfaces
{
    public interface IDisplay
    {
        void FjernTlf();
        void IndlæsRFID();
        void Optaget();
        void RFIDfejl();
        void Tilslutningsfejl();
        void TilslutTlf();
    }
}
namespace Ladeskab.lib
{
    public interface IDisplay
    {
        void UpdateCharge(int percentage);
        void UpdateDisplay(string newDisplayText);
    }
}
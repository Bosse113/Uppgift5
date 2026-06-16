namespace Uppgift5
{
    internal interface IUI
    {
        int GetIntInput(string message);
        string GetStringInput(string message);
        void ShowMainMenu();
        void ShowMessage(string message);
        public int GetVerifiedIntInput(string message);
        public string GetVerifiedStringInput(string message);
    }
}
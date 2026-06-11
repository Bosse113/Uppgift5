namespace Uppgift5
{
    internal interface IGarage<T> where T : Vehicle
    {
        int Capacity { get; }

        bool Add(T vehicle);
        T? Find(string registrationNumber);
        IEnumerator<T> GetEnumerator();
        bool Remove(string registrationNumber);
    }
}
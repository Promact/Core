namespace Promact.Core.Caching
{
    public interface ICachingService
    {
        void Set<T>(string key, T value);
        T Get<T>(string key);
        void Remove(string key);
    }
}

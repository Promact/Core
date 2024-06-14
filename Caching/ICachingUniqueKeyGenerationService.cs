namespace Promact.Core.Caching
{
    public interface ICachingUniqueKeyGenerationService
    {
        string GenerateUniqueKey(string key, string[] args);
    }
}

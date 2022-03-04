namespace Nuages.AWS.Secrets;

// ReSharper disable once InconsistentNaming
public interface IAWSSecretProvider 
{
    Task<T?> GetSecretAsync<T>(string secretArn) where T : class; 
    Task<string?> GetSecretStringAsync(string secretArn);
}

// ReSharper disable once InconsistentNaming
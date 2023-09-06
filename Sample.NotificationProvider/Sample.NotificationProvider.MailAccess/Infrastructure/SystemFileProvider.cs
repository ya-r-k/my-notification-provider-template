using Microsoft.Extensions.Options;
using Sample.NotificationProvider.Common.Settings;

namespace Sample.NotificationProvider.MailAccess.Infrastructure;

public class SystemFileProvider : IFileProvider
{
    private readonly FileStorageSettings options;

    public SystemFileProvider(IOptions<FileStorageSettings> options)
    {
        this.options = options.Value;
    }

    public async Task<byte[]> ReadAllBytesAsync(string filePath)
    {
        var fullPath = $"{options.FileStoragePath}/{filePath}";

        if (!File.Exists(fullPath))
        {
            return default;
        }

        return await File.ReadAllBytesAsync(fullPath);
    }

    public async Task<string> ReadAllTextAsync(string filePath)
    {
        var fullPath = $"{options.FileStoragePath}/{filePath}";

        if (!File.Exists(fullPath))
        {
            return default;
        }

        using var reader = new StreamReader(fullPath);

        return await reader.ReadToEndAsync();
    }

    public async Task WriteAllBytesAsync(string filePath, byte[] value)
    {
        var fullPath = $"{options.FileStoragePath}/{filePath}";

        await File.WriteAllBytesAsync(fullPath, value);
    }
}

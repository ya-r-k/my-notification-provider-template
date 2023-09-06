namespace Sample.NotificationProvider.MailAccess.Infrastructure;

public interface IFileProvider
{
    Task WriteAllBytesAsync(string filePath, byte[] value);

    Task<byte[]> ReadAllBytesAsync(string filePath);

    Task<string> ReadAllTextAsync(string filePath);
}

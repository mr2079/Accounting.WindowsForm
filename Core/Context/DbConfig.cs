namespace Core.Context;

public static class DbConfig
{
    public static string dbName = "accounting.db";
    public static string directoryName = @"Acconting\Database";
    public static string dbPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            directoryName,
            dbName
        );
    public static string dbDirectory = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    directoryName
                );
    public static bool Create()
    {
        try
        {
            if (!Directory.Exists(dbDirectory)) Directory.CreateDirectory(dbDirectory);
            if (!File.Exists(dbPath)) File.Create(dbPath);
            return true;
        }
        catch { return false; }
    }
}
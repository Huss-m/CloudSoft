namespace CloudSoft.Configurations;

public class AzureKeyVaultOptions
{
    public const string SectionName = "AzureKeyVault";
    public string? KeyVaultUri { get; set; }
}
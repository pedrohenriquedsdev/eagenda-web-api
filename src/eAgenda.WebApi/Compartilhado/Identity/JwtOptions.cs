namespace eAgenda.WebApi.Compartilhado.Identity;

public sealed class JwtOptions // CARREGADO PELAS SETTINGS
{
    public const string SectionName = "Jwt";

    public string Issuer { get; set; } = string.Empty;
    public string Audience { get; set; } = string.Empty;
    public string Key { get; set; } = string.Empty; // usada para criptografia
    public int AccessTokenMinutes { get; init; } = 60; // tempo de validade dos tokens
}

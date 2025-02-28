namespace ApiMangas.Entities;

public class UserToken

{
    public string? token { get; set; }
    public DateTime Expiration { get; set; }
}
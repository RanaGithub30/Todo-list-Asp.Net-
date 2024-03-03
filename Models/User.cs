public class User
{
    public int Id { get; set; }
    public string? Username { get; set; } // ? make the field nullable
    public string? Password { get; set; }
    public string? Email { get; set; }
}
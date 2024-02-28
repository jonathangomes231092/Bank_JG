namespace Sistem.Application.Models
{
    public class ClientDto
    {
        public Guid Id { get; set; }
        public string? User { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}

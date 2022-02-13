namespace Identity.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class User
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Fullname { get; set; }
    }
    public class UserLoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ReturnURL { get; set; }
        public bool RememberMe { get; set; }
    }
}
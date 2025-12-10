using JWT.Models;

namespace JWT.Interface
{
    public interface Itok
    {
        public string? CreateToken(User user);
        string GetUserName();
    }
}

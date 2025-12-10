using System.ComponentModel.DataAnnotations;

namespace JWT
{
    public class LoginRequest
    {
        public string Email {  get; set; }  
        public string Password { get; set; }    
    }
}

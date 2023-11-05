using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace testeDB4.Models;
    public class User
    {
        [Key]
        [JsonIgnore] // Ignore
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }

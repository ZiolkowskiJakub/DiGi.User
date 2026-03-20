using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.User.Classes
{
    public class User : Core.Classes.SerializableObject
    {
        public User(string? email)
            : base()
        {
            Email = email;
        }

        public User(User user)
            : base(user)
        {
            if (user is not null)
            {
                Email = user.Email;
                LastName = user.LastName;
                FirstName = user.FirstName;
            }
        }

        public User(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonInclude, JsonPropertyName("Email")]
        public string? Email { get; set; }

        [JsonInclude, JsonPropertyName("FirstName")]
        public string? FirstName { get; set; }

        [JsonInclude, JsonPropertyName("LastName")]
        public string? LastName { get; set; }
    }
}

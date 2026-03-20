using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.User.Classes
{
    public class UserLogin : Core.Classes.SerializableObject
    {
        public UserLogin(string? email)
            : base()
        {
            Email = email;
        }

        public UserLogin(UserLogin userLogin)
            : base(userLogin)
        {
            if (userLogin is not null)
            {
                Email = userLogin.Email;
                Password = userLogin.Password;
            }
        }

        public UserLogin(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonInclude, JsonPropertyName("Email")]
        public string? Email { get; private set; }

        [JsonInclude, JsonPropertyName("Password")]
        public string? Password { get; private set; }

    }
}

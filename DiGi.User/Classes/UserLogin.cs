using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.User.Classes
{
    public class UserLogin : Core.Classes.SerializableObject
    {
        /// <summary>
        /// Initializes a new instance of the UserLogin class with the specified email.
        /// </summary>
        /// <param name="email">The email address of the user.</param>
        public UserLogin(string? email)
            : base()
        {
            Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the UserLogin class by copying another UserLogin object.
        /// </summary>
        /// <param name="userLogin">The source UserLogin object to copy from.</param>
        public UserLogin(UserLogin userLogin)
            : base(userLogin)
        {
            if (userLogin is not null)
            {
                Email = userLogin.Email;
                Password = userLogin.Password;
            }
        }

        /// <summary>
        /// Initializes a new instance of the UserLogin class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing user login data.</param>
        public UserLogin(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        /// <summary>
        /// Gets the email address of the user.
        /// </summary>
        [JsonInclude, JsonPropertyName("Email")]
        public string? Email { get; private set; }

        /// <summary>
        /// Gets the password of the user.
        /// </summary>
        [JsonInclude, JsonPropertyName("Password")]
        public string? Password { get; private set; }

    }
}
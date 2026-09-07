using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.User.Classes
{
    /// <summary>
    /// Represents a user within the system, providing properties for identity and contact information and supporting serialization.
    /// </summary>
    public class User : Core.Classes.SerializableObject
    {
        /// <summary>
        /// Initializes a new instance of the User class with a specified email.
        /// </summary>
        /// <param name="email">The email address of the user.</param>
        public User(string? email)
            : base()
        {
            Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the User class by copying another User object.
        /// </summary>
        /// <param name="user">The source User object to copy from.</param>
        public User(User user)
            : base(user)
        {
            if (user is not null)
            {
                Email = user.Email;
                LastName = user.LastName;
                FirstName = user.FirstName;
                Level = user.Level;
            }
        }

        /// <summary>
        /// Initializes a new instance of the User class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing user data.</param>
        public User(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the email address of the user.
        /// </summary>
        [JsonInclude, JsonPropertyName("Email")]
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the first name of the user.
        /// </summary>
        [JsonInclude, JsonPropertyName("FirstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the user.
        /// </summary>
        [JsonInclude, JsonPropertyName("LastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// Gets or sets the permission level of the user.
        /// <para>The value uses a tiered gradient scale with one-order-of-magnitude gaps between tiers
        /// (Guest = 0, User = 10, Admin = 100, Owner = 1000), so intermediate levels
        /// can be inserted later without renumbering. Use <see cref="GetUserLevel"/> to resolve the
        /// integer to its <see cref="Enums.UserLevel"/> tier.</para>
        /// </summary>
        [JsonInclude, JsonPropertyName("Level")]
        public int Level { get; set; }

        /// <summary>
        /// Resolves the <see cref="Level"/> integer to the highest matching <see cref="Enums.UserLevel"/> tier.
        /// </summary>
        /// <returns>The corresponding <see cref="Enums.UserLevel"/> enum value.</returns>
        public Enums.UserLevel GetUserLevel()
        {
            return Level.UserLevel();
        }
    }
}
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.User.Classes
{
    /// <summary>
    /// Represents the stored password credential of a user, keyed by the same unique email as the <see cref="User"/> it belongs to.
    /// <para>The password itself is never stored. <see cref="PasswordHash"/> holds the Base64 encoded PBKDF2 derived key of the
    /// password, salted with <see cref="PasswordSalt"/> and stretched over <see cref="PasswordIterations"/> iterations. The
    /// iteration count is stored per credential so it can be raised later without invalidating the credentials already written.</para>
    /// <para>This type exists for storage and verification only. It carries the material an offline attack needs and MUST NEVER be
    /// returned from an endpoint, logged, or embedded in the <see cref="User"/> payload.</para>
    /// </summary>
    public class UserCredential : Core.Classes.SerializableObject
    {
        /// <summary>
        /// Initializes a new instance of the UserCredential class.
        /// </summary>
        /// <param name="email">The email address of the user the credential belongs to.</param>
        /// <param name="passwordHash">The Base64 encoded PBKDF2 derived key of the password.</param>
        /// <param name="passwordSalt">The Base64 encoded salt the derived key was produced with.</param>
        /// <param name="passwordIterations">The number of PBKDF2 iterations the derived key was produced with.</param>
        [JsonConstructor]
        public UserCredential(string? email, string? passwordHash, string? passwordSalt, int passwordIterations)
            : base()
        {
            Email = email;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            PasswordIterations = passwordIterations;
        }

        /// <summary>
        /// Initializes a new instance of the UserCredential class by copying another UserCredential object.
        /// </summary>
        /// <param name="userCredential">The source UserCredential object to copy from.</param>
        public UserCredential(UserCredential userCredential)
            : base(userCredential)
        {
            if (userCredential is not null)
            {
                Email = userCredential.Email;
                PasswordHash = userCredential.PasswordHash;
                PasswordSalt = userCredential.PasswordSalt;
                PasswordIterations = userCredential.PasswordIterations;
            }
        }

        /// <summary>
        /// Initializes a new instance of the UserCredential class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing user credential data.</param>
        public UserCredential(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the email address of the user the credential belongs to.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Email))]
        public string? Email { get; private set; }

        /// <summary>
        /// Gets the Base64 encoded PBKDF2 derived key of the password.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(PasswordHash))]
        public string? PasswordHash { get; private set; }

        /// <summary>
        /// Gets the Base64 encoded salt the derived key was produced with.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(PasswordSalt))]
        public string? PasswordSalt { get; private set; }

        /// <summary>
        /// Gets the number of PBKDF2 iterations the derived key was produced with.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(PasswordIterations))]
        public int PasswordIterations { get; private set; }
    }
}

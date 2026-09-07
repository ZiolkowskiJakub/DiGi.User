using DiGi.User.Enums;

namespace DiGi.User
{
    /// <summary>
    /// Provides static extension methods for resolving user permission levels.
    /// </summary>
    public static partial class Query
    {
        /// <summary>
        /// Resolves an integer level value to the highest matching <see cref="UserLevel"/> tier.
        /// </summary>
        /// <param name="level">The integer permission level to resolve.</param>
        /// <returns>The corresponding <see cref="UserLevel"/> enum value.</returns>
        public static UserLevel UserLevel(this int level)
        {
            if (level >= (int)Enums.UserLevel.Owner)
            {
                return Enums.UserLevel.Owner;
            }

            if (level >= (int)Enums.UserLevel.Admin)
            {
                return Enums.UserLevel.Admin;
            }

            if (level >= (int)Enums.UserLevel.User)
            {
                return Enums.UserLevel.User;
            }

            return Enums.UserLevel.Guest;
        }
    }
}
using System.ComponentModel;

namespace DiGi.User.Enums
{
    /// <summary>
    /// Represents the permission levels for user access control.
    /// Higher values grant more privileges. Gaps between values allow intermediate levels to be inserted without renumbering.
    /// </summary>
    [Description("User Permission Level")]
    public enum UserLevel
    {
        /// <summary>
        /// Guest — no account, zero access.
        /// </summary>
        [Description("Guest")] Guest = 0,

        /// <summary>
        /// User — authenticated, standard features.
        /// </summary>
        [Description("User")] User = 10,

        /// <summary>
        /// Admin — manage users, edit configuration, moderate content.
        /// </summary>
        [Description("Admin")] Admin = 100,

        /// <summary>
        /// Owner — full system control, destructive or irreversible operations.
        /// </summary>
        [Description("Owner")] Owner = 1000,
    }
}
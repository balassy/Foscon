using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// The result status of the operation.
	/// </summary>
	public enum CommandResult
	{
		/// <summary>
		/// The command completed successfully.
		/// </summary>
		[XmlEnum("0")]
		Success,

		/// <summary>
		/// The command execution failed because the CGI request string was in incorrect format.
		/// </summary>
		[XmlEnum( "-1" )]
		CgiRequestStringFormatError,

		/// <summary>
		/// The command execution failed because username or password was invalid.
		/// </summary>
		[XmlEnum( "-2" )]
		UserNameOrPasswordError,

		/// <summary>
		/// The command execution failed because the specified user does not have permission for this operation.
		/// </summary>
		[XmlEnum( "-3" )]
		AccessDeny,

		/// <summary>
		/// The command execution failed (no further information available about the reason).
		/// </summary>
		[XmlEnum( "-4" )]
		CgiExecuteFail,

		/// <summary>
		/// The command execution failed because of timeout.
		/// </summary>
		[XmlEnum( "-5" )]
		Timeout,

		/// <summary>
		/// The reserved for future use.
		/// </summary>
		[XmlEnum( "-6" )]
		Reserve6,

		/// <summary>
		/// The command execution failed because of an unknown error (no further information available about the exact reason).
		/// </summary>
		[XmlEnum( "-7" )]
		UnknownError,

		/// <summary>
		/// The reserved for future use.
		/// </summary>
		[XmlEnum( "-8" )]
		Reserve8
	}
}

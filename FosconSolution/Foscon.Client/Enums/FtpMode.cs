using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// The possible FTP server operation modes.
	/// </summary>
	public enum FtpMode
	{
		/// <summary>
		/// PASV mode.
		/// </summary>
		[XmlEnum( "0" )]
		Pasv = 0,

		/// <summary>
		/// PORT mode.
		/// </summary>
		[XmlEnum( "1" )]
		Port = 1
	}
}

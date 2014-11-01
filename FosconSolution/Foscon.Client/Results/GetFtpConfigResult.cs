using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents the result of the <c>getFtpConfig</c> method.
	/// </summary>
	[XmlRoot( "CGI_Result" )]
	public class GetFtpConfigResult : ResultBase
	{
		/// <summary>
		/// Gets or sets the target FTP server address optionally including the subfolder.
		/// </summary>
		[XmlElement( "ftpAddr" )]
		public string Address { get; set; }


		/// <summary>
		/// Gets or sets the target FTP server's port number.
		/// </summary>
		[XmlElement( "ftpPort" )]
		public int Port { get; set; }


		/// <summary>
		/// Gets or sets the operation mode of the target FTP server.
		/// </summary>
		[XmlElement( "mode" )]
		public FtpMode Mode { get; set; }



		/// <summary>
		/// Gets or sets the user name for accessing the FTP server.
		/// </summary>
		[XmlElement( "userName" )]
		public string UserName { get; set; }


		/// <summary>
		/// Gets or sets the password for accessing the FTP server.
		/// </summary>
		[XmlElement( "password" )]
		public string Password { get; set; }
	}
}

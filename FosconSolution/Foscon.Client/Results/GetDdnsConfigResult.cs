using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents the result of the <c>getDdnsConfig</c> method.
	/// </summary>
	[XmlRoot("CGI_Result")]
	public class GetDdnsConfigResult : ResultBase
	{
		/// <summary>
		/// Gets or sets a value indicating whether the Dynamic DNS configuration is enabled or not.
		/// </summary>
		[XmlElement( "isEnable" )]
		public bool IsEnabled { get; set; }


		/// <summary>
		/// Gets or sets the DDNS host name of the camera.
		/// </summary>
		[XmlElement( "hostName" )]
		public string HostName { get; set; }


		/// <summary>
		/// Gets or sets the type of the DDNS provider.
		/// </summary>
		[XmlElement( "ddnsServer" )]
		public DdnsProvider Provider { get; set; }


		/// <summary>
		/// Gets or sets the user name for accessing the DDNS service.
		/// </summary>
		[XmlElement( "user" )]
		public string UserName { get; set; }


		/// <summary>
		/// Gets or sets the password for accessing the DDNS service.
		/// </summary>
		[XmlElement( "password" )]
		public string Password { get; set; }


		/// <summary>
		/// Gets or sets the DDNS host name assigned by the manufacturer.
		/// </summary>
		[XmlElement( "factoryDDNS" )]
		public string FactoryHostName { get; set; }

	}
}

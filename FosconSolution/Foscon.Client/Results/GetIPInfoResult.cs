using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents the result of the <c>getIPInfo</c> method.
	/// </summary>
	[XmlRoot("CGI_Result")]
	public class GetIPInfoResult : ResultBase
	{
		/// <summary>
		/// Gets or sets a value indicating whether the camera obtains IP address from a DHCP server or not.
		/// </summary>
		[XmlElement("isDHCP")]
		public bool IsDhcp { get; set; }

		/// <summary>
		/// Gets or sets the IPv4 address of the camera.
		/// </summary>
		[XmlElement("ip")]
		public string IPAddress { get; set; }

		/// <summary>
		/// Gets or sets the gateway ("0.0.0.0" when DHCP is used).
		/// </summary>
		[XmlElement("gate")]
		public string Gateway { get; set; }

		/// <summary>
		/// Gets or sets the subnet mask.
		/// </summary>
		[XmlElement( "mask" )]
		public string SubnetMask { get; set; }

		/// <summary>
		/// Gets or sets the first DNS server ("0.0.0.0" when DHCP is used).
		/// </summary>
		[XmlElement( "dns1" )]
		public string DnsServer1 { get; set; }

		/// <summary>
		/// Gets or sets the second DNS server ("0.0.0.0" when DHCP is used).
		/// </summary>
		[XmlElement( "dns2" )]
		public string DnsServer2 { get; set; }
	}
}

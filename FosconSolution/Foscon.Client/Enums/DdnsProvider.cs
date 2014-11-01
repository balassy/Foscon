using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// The possible Dynamic DNS providers.
	/// </summary>
	public enum DdnsProvider
	{
		/// <summary>
		/// The DDNS service provided by the manufacturer.
		/// </summary>
		[XmlEnum( "0" )]
		Factory = 0,

		/// <summary>
		/// The oray.com DDNS provider.
		/// </summary>
		[XmlEnum( "1" )]
		Oray = 1,

		/// <summary>
		/// The 3322.org DDNS provider.
		/// </summary>
		[XmlEnum( "2" )]
		Ddns3322 = 2,

		/// <summary>
		/// The no-ip.com DDNS provider.
		/// </summary>
		[XmlEnum( "3" )]
		NoIp = 3,

		/// <summary>
		/// The dyndns.org DDNS provider.
		/// </summary>
		[XmlEnum( "4" )]
		DynDns = 4
	}
}

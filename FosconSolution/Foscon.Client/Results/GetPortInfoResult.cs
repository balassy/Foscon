using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents the result of the <c>GetPortInfo</c> method.
	/// </summary>
	[XmlRoot("CGI_Result")]
	public class GetPortInfoResult : ResultBase
	{
		/// <summary>
		/// Gets or sets the port number of the HTTP interface. The default is 80.
		/// </summary>
		[XmlElement("webPort")]
		public int HttpPort { get; set; }


		/// <summary>
		/// Gets or sets the port number of the HTTPS interface. The default is 443.
		/// </summary>
		[XmlElement( "httpsPort" )]
		public int HttpsPort { get; set; }


		/// <summary>
		/// Gets or sets the port number of the media interface. The default is 88.
		/// </summary>
		[XmlElement( "mediaPort" )]
		public int MediaPort { get; set; }


		/// <summary>
		/// Gets or sets the port number of the Onvif interface, if the camera supports Onvif. The default is 888.
		/// </summary>
		[XmlElement( "onvifPort" )]
		public int OnvifPort { get; set; }
	}
}

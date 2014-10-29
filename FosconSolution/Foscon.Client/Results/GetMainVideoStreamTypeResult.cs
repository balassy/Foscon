using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents the result of the <c>GetMainVideoStreamType</c> method.
	/// </summary>
	[XmlRoot("CGI_Result")]
	public class GetMainVideoStreamTypeResult : ResultBase
	{
		/// <summary>
		/// Gets or sets the stream type of the main stream.
		/// </summary>
		[XmlElement("streamType")]
		public byte StreamType { get; set; }
	}
}

using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents the result of the <c>getProductModel</c> method.
	/// </summary>
	[XmlRoot( "CGI_Result" )]
	public class GetProductModelResult : ResultBase
	{
		/// <summary>
		/// Gets or sets the camera model number.
		/// </summary>
		[XmlElement( "model" )]
		public int ModelNumber { get; set; }
	}
}

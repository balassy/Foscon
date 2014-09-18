using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents the result of the <c>GetProductModelName</c> method.
	/// </summary>
	[XmlRoot( "CGI_Result" )]
	public class GetProductModelNameResult : ResultBase
	{
		/// <summary>
		/// Gets or sets the camera model name.
		/// </summary>
		[XmlElement( "modelName" )]
		public string ModelName { get; set; }
	}
}

using System;
using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents the result of the <c>GetSnapshot</c> method.
	/// </summary>
	[XmlRoot( "CGI_Result" )]
	public class GetSnapshotResult : ResultBase
	{
		/// <summary>
		/// Gets or sets the content of the snapshot image if the command completed successfully or <c>null</c> if the command failed.
		/// </summary>
		public byte[] Image { get; set; }

		/// <summary>
		/// Gets or sets the MIME type of the image as it is returned in the <c>Content-Type</c> HTTP header if the command completed successfully or <c>null</c> if the command failed.
		/// </summary>
		public string MediaType { get; set; }
	}
}

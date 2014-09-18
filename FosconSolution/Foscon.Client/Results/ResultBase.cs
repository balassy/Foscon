using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// The common base class for all command results.
	/// </summary>
	[XmlRoot( "CGI_Result" )]
	public class ResultBase
	{
		/// <summary>
		/// Gets or sets the result of the command execution.
		/// </summary>
		[XmlElement( "result" )]
		public CommandResult Result { get; set; }
	}
}

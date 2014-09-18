using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents the result of the <c>GetPtzSpeed</c> method.
	/// </summary>
	[XmlRoot( "CGI_Result" )]
	public class GetPtzSpeedResult : ResultBase
	{
		/// <summary>
		/// Gets or sets the speed of the pan-til-zoom operations.
		/// </summary>
		[XmlElement( "speed" )]
		public PtzSpeed Speed { get; set; }
	}
}

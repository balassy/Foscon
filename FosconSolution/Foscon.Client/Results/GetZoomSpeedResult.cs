using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents the result of the <c>GetZoomSpeed</c> method.
	/// </summary>
	[XmlRoot( "CGI_Result" )]
	public class GetZoomSpeedResult : ResultBase
	{
		/// <summary>
		/// Gets or sets the speed of the zoom operations.
		/// </summary>
		[XmlElement( "speed" )]
		public ZoomSpeed Speed { get; set; }
	}
}

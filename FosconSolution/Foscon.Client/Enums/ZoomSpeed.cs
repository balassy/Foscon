using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// The possible zoom speed rates.
	/// </summary>
	public enum ZoomSpeed
	{
		/// <summary>
		/// The camera moves slowly.
		/// </summary>
		[XmlEnum( "0" )]
		Slow = 0,

		/// <summary>
		/// The camera moves at normal speed.
		/// </summary>
		[XmlEnum( "1" )]
		Normal = 1,

		/// <summary>
		/// The camera moves fast.
		/// </summary>
		[XmlEnum( "2" )]
		Fast = 2
	}
}

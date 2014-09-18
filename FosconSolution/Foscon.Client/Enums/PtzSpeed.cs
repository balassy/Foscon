using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// The possible pan-tilt-zoom speed rates.
	/// </summary>
	public enum PtzSpeed
	{
		/// <summary>
		/// The camera moves very slowly.
		/// </summary>
		[XmlEnum("0")]
		VerySlow = 0,

		/// <summary>
		/// The camera moves slowly.
		/// </summary>
		[XmlEnum( "1" )]
		Slow = 1,

		/// <summary>
		/// The camera moves at normal speed.
		/// </summary>
		[XmlEnum( "2" )]
		Normal = 2,

		/// <summary>
		/// The camera moves fast.
		/// </summary>
		[XmlEnum( "3" )]
		Fast = 3,

		/// <summary>
		/// The camera moves very fast.
		/// </summary>
		[XmlEnum( "4" )]
		VeryFast = 4
	}
}

using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// The possible SD card states.
	/// </summary>
	public enum SDCardState
	{
		/// <summary>
		/// No SD card is currently present in the camera.
		/// </summary>
		[XmlEnum( "0" )]
		Missing = 0,

		/// <summary>
		/// The SD card is functioning properly.
		/// </summary>
		[XmlEnum( "1" )]
		OK = 1,

		/// <summary>
		/// The SD card is in read-only mode.
		/// </summary>
		[XmlEnum( "2" )]
		ReadOnly = 2
	}
}

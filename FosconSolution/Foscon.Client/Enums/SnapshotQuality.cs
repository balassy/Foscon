using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// The possible quality settings for the snapshot picture.
	/// </summary>
	public enum SnapshotQuality
	{
		/// <summary>
		/// The snapshot picture is low quality.
		/// </summary>
		[XmlEnum( "0" )]
		Low = 0,

		/// <summary>
		/// The snapshot picture is medium quality.
		/// </summary>
		[XmlEnum( "1" )]
		Normal = 1,

		/// <summary>
		/// The snapshot picture is high quality.
		/// </summary>
		[XmlEnum( "2" )]
		High = 2
	}
}

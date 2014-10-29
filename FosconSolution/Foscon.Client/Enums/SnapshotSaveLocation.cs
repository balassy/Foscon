using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// The possible targets where the snapshot pictures can be saved.
	/// </summary>
	public enum SnapshotSaveLocation
	{
		/// <summary>
		/// The snapshot picture is saved to the SD card.
		/// </summary>
		[XmlEnum( "0" )]
		SDCard = 0,

		/// <summary>
		/// The snapshot picture is uploaded to an FTP server.
		/// </summary>
		[XmlEnum( "2" )]
		Ftp = 2
	}
}

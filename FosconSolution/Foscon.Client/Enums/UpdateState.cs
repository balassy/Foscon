using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// The possible states of the client of an updatable service in the camera.
	/// </summary>
	public enum UpdateState
	{
		/// <summary>
		/// The update is disabled.
		/// </summary>
		[XmlEnum( "0" )]
		Disabled = 0,

		/// <summary>
		/// The update is completed successfully.
		/// </summary>
		[XmlEnum( "1" )]
		UpdateSuccess = 1,

		/// <summary>
		/// The update is failed.
		/// </summary>
		[XmlEnum( "2" )]
		UpdateFailed = 2
	}
}

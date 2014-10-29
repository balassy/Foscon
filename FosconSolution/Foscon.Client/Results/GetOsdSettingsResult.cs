using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents the result of the <c>GetOsdSettings</c> method.
	/// </summary>
	[XmlRoot("CGI_Result")]
	public class GetOsdSettingsResult : ResultBase
	{
		/// <summary>
		/// Gets or sets a value indicating whether the timestamp will be displayed on the screen or not.
		/// </summary>
		[XmlElement( "isEnableTimeStamp" )]
		public bool IsTimestampDisplayed { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the camera name will be displayed on the screen or not.
		/// </summary>
		[XmlElement( "isEnableDevName" )]
		public bool IsCameraNameDisplayed { get; set; }

		/// <summary>
		/// Gets or sets the position of the OSD display. Currently can only be 0.
		/// </summary>
		[XmlElement( "dispPos" )]
		public string DisplayPosition { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the OSD mask is effective or not.
		/// </summary>
		[XmlElement( "isEnableOSDMask" )]
		public bool IsOsdMaskEffective { get; set; }
	}
}

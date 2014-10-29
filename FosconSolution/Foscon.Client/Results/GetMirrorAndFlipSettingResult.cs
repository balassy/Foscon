using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents the result of the <c>GetMirrorAndFlipSettings</c> method.
	/// </summary>
	[XmlRoot("CGI_Result")]
	public class GetMirrorAndFlipSettingsResult : ResultBase
	{
		/// <summary>
		/// Gets or sets a value indicating whether the video is mirrored or not.
		/// </summary>
		[XmlElement("isMirror")]
		public bool IsMirrored { get; set; }


		/// <summary>
		/// Gets or sets a value indicating whether the video is flipped or not.
		/// </summary>
		[XmlElement("isFlip")]
		public bool IsFlipped { get; set; }
	}
}

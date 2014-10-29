using System;
using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents the result of the <c>GetImageSetting</c> operation.
	/// </summary>
	[XmlRoot( "CGI_Result" )]
	public class GetImageSettingResult : ResultBase
	{
		/// <summary>
		/// Gets or sets the previously set brightness level (0-100).
		/// </summary>
		[XmlElement("brightness")]
		public byte Brightness { get; set; }


		/// <summary>
		/// Gets or sets the previously set contrast level (0-100).
		/// </summary>
		[XmlElement("contrast")]
		public byte Contrast { get; set; }


		/// <summary>
		/// Gets or sets the previously set hue level (0-100).
		/// </summary>
		[XmlElement("hue")]
		public byte Hue { get; set; }


		/// <summary>
		/// Gets or sets the previously set saturation level (0-100).
		/// </summary>
		[XmlElement("saturation")]
		public byte Saturation { get; set; }


		/// <summary>
		/// Gets or sets the previously set sharpness level (0-100).
		/// </summary>
		[XmlElement("sharpness")]
		public byte Sharpness { get; set; }


		/// <summary>
		/// Gets or sets the previously set denoise level.
		/// </summary>
		[XmlElement("denoiseLevel")]
		public byte Denoise { get; set; }
	}
}

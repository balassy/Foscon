using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents the result of the <c>GetVideoStreamParam</c> method.
	/// </summary>
	[XmlRoot("CGI_Result")]
	public class GetVideoStreamParamResult : ResultBase
	{
		/// <summary>
		/// Gets or sets the resolution of stream type 0.
		/// </summary>
		[XmlElement("resolution0")]
		public int Resolution1 { get; set; }


		/// <summary>
		/// Gets or sets the bit rate of stream type 0.
		/// </summary>
		[XmlElement("bitRate0")]
		public int BitRate1 { get; set; }


		/// <summary>
		/// Gets or sets the frame rate of stream type 0.
		/// </summary>
		[XmlElement("frameRate0")]
		public int FrameRate1 { get; set; }


		/// <summary>
		/// Gets or sets the number of P frames between I frames of stream type 0.
		/// </summary>
		[XmlElement("GOP0")]
		public int GOP1 { get; set; }



		/// <summary>
		/// Gets or sets the resolution of stream type 1.
		/// </summary>
		[XmlElement("resolution1")]
		public int Resolution2 { get; set; }


		/// <summary>
		/// Gets or sets the bit rate of stream type 1.
		/// </summary>
		[XmlElement("bitRate1")]
		public int BitRate2 { get; set; }


		/// <summary>
		/// Gets or sets the frame rate of stream type 1.
		/// </summary>
		[XmlElement("frameRate1")]
		public int FrameRate2 { get; set; }


		/// <summary>
		/// Gets or sets the number of P frames between I frames of stream type 1.
		/// </summary>
		[XmlElement("GOP1")]
		public int GOP2 { get; set; }



		/// <summary>
		/// Gets or sets the resolution of stream type 2.
		/// </summary>
		[XmlElement("resolution2")]
		public int Resolution3 { get; set; }


		/// <summary>
		/// Gets or sets the bit rate of stream type 2.
		/// </summary>
		[XmlElement("bitRate2")]
		public int BitRate3 { get; set; }


		/// <summary>
		/// Gets or sets the frame rate of stream type 2.
		/// </summary>
		[XmlElement("frameRate2")]
		public int FrameRate3 { get; set; }


		/// <summary>
		/// Gets or sets the number of P frames between I frames of stream type 2.
		/// </summary>
		[XmlElement("GOP2")]
		public int GOP3 { get; set; }



		/// <summary>
		/// Gets or sets the resolution of stream type 3.
		/// </summary>
		[XmlElement("resolution3")]
		public int Resolution4 { get; set; }


		/// <summary>
		/// Gets or sets the bit rate of stream type 3.
		/// </summary>
		[XmlElement("bitRate3")]
		public int BitRate4 { get; set; }


		/// <summary>
		/// Gets or sets the frame rate of stream type 3.
		/// </summary>
		[XmlElement("frameRate3")]
		public int FrameRate4 { get; set; }


		/// <summary>
		/// Gets or sets the number of P frames between I frames of stream type 3.
		/// </summary>
		[XmlElement("GOP3")]
		public int GOP4 { get; set; }

	}
}

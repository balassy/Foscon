using System;
using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents the result of the <c>getDevInfo</c> method.
	/// </summary>
	[XmlRoot("CGI_Result")]
	public class GetDeviceInfoResult : ResultBase
	{
		/// <summary>
		/// The model name of the camera.
		/// </summary>
		[XmlElement("productName")]
		public string ProductName { get; set; }

		/// <summary>
		/// The serial number of the camera.
		/// </summary>
		[XmlElement( "serialNo" )]
		public string SerialNumber { get; set; }

		/// <summary>
		/// The name of the camera.
		/// </summary>
		[XmlElement( "devName" )]
		public string DeviceName { get; set; }

		/// <summary>
		/// The physical address of the camera.
		/// </summary>
		[XmlElement( "mac" )]
		public string MacAddress { get; set; }

		/// <summary>
		/// The years part of the current date of the camera.
		/// </summary>
		[XmlElement( "year" )]
		public int Year { get; set; }

		/// <summary>
		/// The months part of the current date of the camera.
		/// </summary>
		[XmlElement( "mon" )]
		public int Month { get; set; }

		/// <summary>
		/// The days part of the current date of the camera.
		/// </summary>
		[XmlElement( "day" )]
		public int Day { get; set; }

		/// <summary>
		/// The hours part of the current date of the camera.
		/// </summary>
		[XmlElement( "hour" )]
		public int Hour { get; set; }

		/// <summary>
		/// The minutes part of the current date of the camera.
		/// </summary>
		[XmlElement( "min" )]
		public int Minute { get; set; }

		/// <summary>
		/// The seconds part of the current date of the camera.
		/// </summary>
		[XmlElement( "sec" )]
		public int Seconds { get; set; }

		/// <summary>
		/// The time zone for the current date of the camera.
		/// </summary>
		[XmlElement( "timeZone" )]
		public string TimeZone { get; set; }

		/// <summary>
		/// The version of the current firmware on the camera.
		/// </summary>
		[XmlElement( "firmwareVer" )]
		public string FirmwareVersion { get; set; }

		/// <summary>
		/// The version of the camera hardware.
		/// </summary>
		[XmlElement( "hardwareVer" )]
		public string HardwareVersion { get; set; }

		/// <summary>
		/// Returns the current date on the camera built from the <see cref="Year"/>, <see cref="Month"/>, <see cref="Day"/>, <see cref="Hour"/>, <see cref="Minute"/> and <see cref="Seconds"/> properties of this instance.
		/// </summary>
		public DateTime CurrentDate
		{
			get
			{
				return new DateTime(this.Year, this.Month, this.Day, this.Hour, this.Minute, this.Seconds);
			}
		}
	}
}

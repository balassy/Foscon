using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents the result of the <c>getDevState</c> method.
	/// </summary>
	[XmlRoot( "CGI_Result" )]
	public class GetDeviceStateResult : ResultBase
	{
		/// <summary>
		/// Gets or sets the current I/O alarm state.
		/// </summary>
		[XmlElement( "IOAlarm" )]
		public AlarmState IOAlarm { get; set; }


		/// <summary>
		/// Gets or sets the current motion detection alarm state.
		/// </summary>
		[XmlElement( "motionDetectAlarm" )]
		public AlarmState MotionDetectAlarm { get; set; }


		/// <summary>
		/// Gets or sets the current sound alarm state.
		/// </summary>
		[XmlElement( "soundAlarm" )]
		public AlarmState SoundAlarm { get; set; }


		/// <summary>
		/// Gets or sets a value indicating whether the camera is currently recording.
		/// </summary>
		[XmlElement( "record" )]
		public bool IsRecording { get; set; }


		/// <summary>
		/// Gets or sets the state of the SD card.
		/// </summary>
		[XmlElement( "sdState" )]
		public SDCardState SDCard { get; set; }


		/// <summary>
		/// Gets or sets the amount of current free space on the SD card in kilobytes (the value ends with a "k").
		/// </summary>
		[XmlElement( "sdFreeSpace" )]
		public string SDCardFreeSpace { get; set; }  // TODO: convert to int!


		/// <summary>
		/// Gets or sets the amount of total space on the SD card in kilobytes (the value ends with a "k").
		/// </summary>
		[XmlElement( "sdTotalSpace" )]
		public string SDCardTotalSpace { get; set; } // TODO: convert to int!


		/// <summary>
		/// Gets or sets the current update state of the Network Time Protocol client.
		/// </summary>
		[XmlElement( "ntpState" )]
		public UpdateState Ntp { get; set; }


		/// <summary>
		/// Gets or sets the current update state of the Dynamic DNS client.
		/// </summary>
		[XmlElement( "ddnsState" )]
		public UpdateState Ddns { get; set; }


		/// <summary>
		/// Gets or sets the current Dynamic DNS host name of the camera.
		/// </summary>
		[XmlElement( "url" )]
		public string DdnsHost { get; set; }


		/// <summary>
		/// Gets or sets the current update state of the Universal Plug-n-Play client.
		/// </summary>
		[XmlElement( "upnpState" )]
		public UpdateState UPnP { get; set; }


		/// <summary>
		/// Gets or sets a value indicating whether the camera is currently connected to a wireless network.
		/// </summary>
		[XmlElement( "isWifiConnected" )]
		public bool IsWifiConnected { get; set; }


		/// <summary>
		/// Gets or sets the identifier of the wireless network if the camera is currently connected to one.
		/// </summary>
		[XmlElement( "wifiConnectedAP" )]
		public string SSID { get; set; }


		/// <summary>
		/// Gets or sets a value indicating whether the infra LED is currently ON.
		/// </summary>
		[XmlElement( "infraLedState" )]
		public bool IsInfraLedOn { get; set; }
	}
}

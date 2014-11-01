using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// The possible alarm states.
	/// </summary>
	public enum AlarmState
	{
		/// <summary>
		/// The alarm is disabled.
		/// </summary>
		[XmlEnum( "0" )]
		Disabled = 0,

		/// <summary>
		/// No alarm detected.
		/// </summary>
		[XmlEnum( "1" )]
		NoAlarm = 1,

		/// <summary>
		/// Alarm detected.
		/// </summary>
		[XmlEnum( "2" )]
		DetectAlarm = 2
	}
}

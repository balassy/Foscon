using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents the result of the <c>GetSnapshotConfig</c> method.
	/// </summary>
	[XmlRoot( "CGI_Result" )]
	public class GetSnapshotConfigResult : ResultBase
	{
		/// <summary>
		/// Gets or sets the quality of the snapshot picture.
		/// </summary>
		[XmlElement( "snapPicQuality" )]
		public SnapshotQuality Quality { get; set; }


		/// <summary>
		/// Gets or sets the location where the snapshot pictures are saved.
		/// </summary>
		[XmlElement( "saveLocation" )]
		public SnapshotSaveLocation SaveLocation { get; set; }
	}
}

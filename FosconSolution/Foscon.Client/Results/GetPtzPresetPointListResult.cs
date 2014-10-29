using System;
using System.Xml.Serialization;

namespace Foscon.Client
{
    /// <summary>
    /// Represents the result of the <c>getPTZPresetPointList</c> method.
    /// </summary>
    [XmlRoot("CGI_Result")]
    public class GetPtzPresetPointListResult : ResultBase
    {
        /// <summary>
        /// The number of currently set preset points.
        /// </summary>
        [XmlElement("cnt")]
        public int Count { get; set; }

        /// <summary>
        /// The name of the present point #1.
        /// </summary>
        [XmlElement("point0")]
        public string Point01Name { get; set; }

        /// <summary>
        /// The name of the present point #2.
        /// </summary>
        [XmlElement("point1")]
        public string Point02Name { get; set; }

        /// <summary>
        /// The name of the present point #3.
        /// </summary>
        [XmlElement("point2")]
        public string Point03Name { get; set; }

        /// <summary>
        /// The name of the present point #4.
        /// </summary>
        [XmlElement("point3")]
        public string Point04Name { get; set; }

        /// <summary>
        /// The name of the present point #5.
        /// </summary>
        [XmlElement("point4")]
        public string Point05Name { get; set; }

        /// <summary>
        /// The name of the present point #6.
        /// </summary>
        [XmlElement("point5")]
        public string Point06Name { get; set; }

        /// <summary>
        /// The name of the present point #7.
        /// </summary>
        [XmlElement("point6")]
        public string Point07Name { get; set; }

        /// <summary>
        /// The name of the present point #8.
        /// </summary>
        [XmlElement("point7")]
        public string Point08Name { get; set; }

        /// <summary>
        /// The name of the present point #9.
        /// </summary>
        [XmlElement("point8")]
        public string Point09Name { get; set; }

        /// <summary>
        /// The name of the present point #10.
        /// </summary>
        [XmlElement("point9")]
        public string Point10Name { get; set; }

        /// <summary>
        /// The name of the present point #11.
        /// </summary>
        [XmlElement("point10")]
        public string Point11Name { get; set; }

        /// <summary>
        /// The name of the present point #12.
        /// </summary>
        [XmlElement("point11")]
        public string Point12Name { get; set; }

        /// <summary>
        /// The name of the present point #13.
        /// </summary>
        [XmlElement("point12")]
        public string Point13Name { get; set; }

        /// <summary>
        /// The name of the present point #14.
        /// </summary>
        [XmlElement("point13")]
        public string Point14Name { get; set; }

        /// <summary>
        /// The name of the present point #15.
        /// </summary>
        [XmlElement("point14")]
        public string Point15Name { get; set; }

        /// <summary>
        /// The name of the present point #16.
        /// </summary>
        [XmlElement("point15")]
        public string Point16Name { get; set; }

    }
}

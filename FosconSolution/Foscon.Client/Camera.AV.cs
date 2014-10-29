using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace Foscon.Client
{
	public partial class Camera
	{
		/// <summary>
		/// Returns the color attribute of the video.
		/// </summary>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The previously set video settings.</returns>
		public async Task<GetImageSettingResult> GetImageSettings()
		{
			return await this.Execute<GetImageSettingResult>( "getImageSetting" );
		}
	}
}

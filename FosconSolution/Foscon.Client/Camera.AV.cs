using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Foscon.Client
{
	public partial class Camera
	{
		/// <summary>
		/// Returns the color attribute of the video.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The previously set video settings.</returns>
		public Task<GetImageSettingResult> GetImageSettingsAsync( CancellationToken token )
		{
			return this.ExecuteAsync<GetImageSettingResult>( "getImageSetting", token );
		}


		/// <summary>
		/// Returns the image transformation attributes of the video.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param> 
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The previously set mirror and flip settings.</returns>
		public Task<GetMirrorAndFlipSettingsResult> GetMirrorAndFlipSettingsAsync( CancellationToken token )
		{
			return this.ExecuteAsync<GetMirrorAndFlipSettingsResult>( "getMirrorAndFlipSetting", token );
		}


		/// <summary>
		/// Returns the attributes of the video streams.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The previously set video stream parameters.</returns>
		public Task<GetVideoStreamParamResult> GetVideoStreamParamsAsync( CancellationToken token )
		{
			return this.ExecuteAsync<GetVideoStreamParamResult>( "getVideoStreamParam", token );
		}



		/// <summary>
		/// Returns the stream type of the main video stream.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The type of the main video stream.</returns>
		public Task<GetMainVideoStreamTypeResult> GetMainVideoStreamTypeAsync( CancellationToken token )
		{
			return this.ExecuteAsync<GetMainVideoStreamTypeResult>( "getMainVideoStreamType", token );
		}


		/// <summary>
		/// Returns the On-Screen Display configuration settings.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The current OSD configuration settings.</returns>
		public Task<GetOsdSettingsResult> GetOsdSettingsAsync( CancellationToken token )
		{
			return this.ExecuteAsync<GetOsdSettingsResult>( "getOSDSetting", token );
		}


		/// <summary>
		/// Returns the snapshot configuration settings.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The current snapshot configuration settings.</returns>
		public Task<GetSnapshotConfigResult> GetSnapshotConfig( CancellationToken token )
		{
			return this.ExecuteAsync<GetSnapshotConfigResult>( "getSnapConfig", token );
		}

	}
}

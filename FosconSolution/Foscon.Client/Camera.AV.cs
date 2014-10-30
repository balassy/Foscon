using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
		public Task<GetSnapshotConfigResult> GetSnapshotConfigAsync( CancellationToken token )
		{
			return this.ExecuteAsync<GetSnapshotConfigResult>( "getSnapConfig", token );
		}


		/// <summary>
		/// Takes a new snapshot image.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The current snapshot image.</returns>
		public async Task<GetSnapshotResult> GetSnapshotAsync( CancellationToken token )
		{
			// Input validation.
			Contract.Ensures( Contract.Result<GetSnapshotResult>() != null );
			
			const string commandName = "snapPicture2";
			GetSnapshotResult result;

			// Build the command URL.
			string url = this.BuildCommandUrl( commandName );

			// Execute the command and download the raw XML result string.
			using( HttpClient client = new HttpClient() )
			{
				// NOTE: ConfigureAwait is added to avoid blocking UI threads. See: http://blog.stephencleary.com/2012/07/dont-block-on-async-code.html
				HttpResponseMessage response = await client.GetAsync( url, token ).ConfigureAwait( false );

				string contentType = response.Content.Headers.ContentType.MediaType;

				// In case of error the standard XML result structure is returned, and the HTTP status code remains 200 OK.
				if( contentType.Equals( "text/plain", StringComparison.OrdinalIgnoreCase ) )
				{
					string content = await response.Content.ReadAsStringAsync().ConfigureAwait( false );

					// Convert the raw XML content string to the expected result type.
					TextReader reader = new StringReader( content );
					XmlSerializer serializer = new XmlSerializer( typeof( GetSnapshotResult ) );
					result = (GetSnapshotResult) serializer.Deserialize( reader );
				}
				else
				{
					// In case of success the body of the HTTP response contains the snapshot image.
					byte[] content = await response.Content.ReadAsByteArrayAsync().ConfigureAwait( false );

					result = new GetSnapshotResult
					{
						Result = CommandResult.Success,
						MediaType = contentType,
						Image = content
					};
				}

				return result;
			}
		}

	}
}

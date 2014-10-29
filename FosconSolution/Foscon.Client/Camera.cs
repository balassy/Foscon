using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents a Foscon camera.
	/// </summary>
	public partial class Camera
	{
		#region Private fields

		/// <summary>
		/// Stores the host name or IP network address of the camera.
		/// </summary>
		private readonly string hostName;

		/// <summary>
		/// Stores the port number of the camera.
		/// </summary>
		private readonly int port;

		/// <summary>
		/// Stores the login name of the user to use to connect to the camera.
		/// </summary>
		private readonly string userName;

		/// <summary>
		/// Stores the password of the user to use to connect to the camera.
		/// </summary>
		private readonly string password;

		#endregion


		#region Initialization

		/// <summary>
		/// Initializes a new instance of the <see cref="Camera"/> class.
		/// </summary>
		/// <param name="hostName">The name or IP network address of the camera (e.g. 192.168.1.12).</param>
		/// <param name="port">The IP port number where the camera is available (e.g. 88).</param>
		/// <param name="userName">The login name of the user to use to connect to the camera.</param>
		/// <param name="password">The password of the user to use to connect to the camera.</param>
		/// <exception cref="ArgumentNullException">If the specified <paramref name="hostName"/> or <paramref name="userName"/> is <c>null</c> or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException">If the specified <paramref name="port"/> number does not fall into the 0-65535 range.</exception>
		public Camera( string hostName, int port, string userName, string password )
		{
			Contract.Requires<ArgumentNullException>( !String.IsNullOrEmpty( hostName ) );
			Contract.Requires<ArgumentNullException>( !String.IsNullOrEmpty( userName ) );
			Contract.Requires<ArgumentOutOfRangeException>( port > 0 && port <= 65535 );

			this.hostName = hostName;
			this.port = port;
			this.userName = userName;
			this.password = password;
		}

		#endregion


		#region Private helper methods

		/// <summary>
		/// Executes the specified command and returns its result in the specified format.
		/// </summary>
		/// <typeparam name="TResult">The type which describes the command result.</typeparam>
		/// <param name="commandName">The internal name of the command to execute. Must not be <c>null</c> or empty.</param>
		/// <param name="token">The token that you can use to abort the operation.</param>
		/// <returns>The result of the command execution.</returns>
		/// <remarks>
		/// The <c>Result</c> property of the returned object must be checked to verify whether the command executed successfully or not.
		/// </remarks>
		private async Task<TResult> ExecuteAsync<TResult>( string commandName, CancellationToken token ) where TResult: ResultBase
		{
			// Input validation.
			Contract.Requires( !String.IsNullOrEmpty( commandName ) );
			Contract.Ensures( Contract.Result<TResult>() != null );

			// Build the command URL.
			string url = this.BuildCommandUrl( commandName );

			// Execute the command and download the raw XML result string.
			using( HttpClient client = new HttpClient() )
			{
				// NOTE: ConfigureAwait is added to avoid blocking UI threads. See: http://blog.stephencleary.com/2012/07/dont-block-on-async-code.html
				HttpResponseMessage response = await client.GetAsync( url, token ).ConfigureAwait( false );
				string result = await response.Content.ReadAsStringAsync().ConfigureAwait( false );

				// Convert the raw XML result string to the expected result type.
				TextReader reader = new StringReader( result );
				XmlSerializer serializer = new XmlSerializer( typeof( TResult ) );
				return (TResult) serializer.Deserialize( reader );				
			}
		}


		/// <summary>
		/// Builds the HTTP URL which is used to access the CGI interface of the camera.
		/// </summary>
		/// <param name="commandName">The internal name of the command as it should appear in the URL. Must not be <c>null</c> or empty.</param>
		/// <returns>The full, absolute URL of the command.</returns>
		private string BuildCommandUrl( string commandName )
		{
			// Input validation.
			Contract.Requires( !String.IsNullOrEmpty( commandName ) );
			Contract.Ensures( !String.IsNullOrEmpty( Contract.Result<string>() ) );

			// TODO: URL encoding!
			return String.Format( CultureInfo.InvariantCulture, @"http://{0}:{1}/cgi-bin/CGIProxy.fcgi?usr={2}&pwd={3}&cmd={4}", this.hostName, this.port, this.userName, this.password, commandName );
		}

		#endregion
	}
}

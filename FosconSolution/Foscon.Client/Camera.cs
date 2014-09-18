using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Foscon.Client
{
	/// <summary>
	/// Represents a Foscon camera.
	/// </summary>
	public class Camera
	{
		#region Private fields

		/// <summary>
		/// Stores the network address (IP address:port) of the camera.
		/// </summary>
		private readonly string address;

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
		/// <param name="address">The network address (IP address:port) of the camera.</param>
		/// <param name="userName">The login name of the user to use to connect to the camera.</param>
		/// <param name="password">The password of the user to use to connect to the camera.</param>
		/// <exception cref="ArgumentNullException">If the specified <paramref name="address"/> or <paramref name="userName"/> is <c>null</c> or empty.</exception>
		public Camera( string address, string userName, string password )
		{
			// Input validation.
			if( String.IsNullOrEmpty( address ) )
			{
				throw new ArgumentNullException( "address" );
			}
			if( String.IsNullOrEmpty( userName ) )
			{
				throw new ArgumentNullException( "userName" );
			}

			// TODO: Validate address format.

			this.address = address;
			this.userName = userName;
			this.password = password;
		}

		#endregion


		#region Pan-Tilt-Zoom commands

		/// <summary>
		/// Moves the camera up.
		/// </summary>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public async Task<ResultBase> MoveUp()
		{
			return await this.Execute<ResultBase>( "ptzMoveUp" );
		}


		/// <summary>
		/// Moves the camera down.
		/// </summary>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public async Task<ResultBase> MoveDown()
		{
			return await this.Execute<ResultBase>( "ptzMoveDown" );
		}


		/// <summary>
		/// Moves the camera left.
		/// </summary>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public async Task<ResultBase> MoveLeft()
		{
			return await this.Execute<ResultBase>( "ptzMoveLeft" );
		}


		/// <summary>
		/// Moves the camera right.
		/// </summary>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public async Task<ResultBase> MoveRight()
		{
			return await this.Execute<ResultBase>( "ptzMoveRight" );
		}


		/// <summary>
		/// Moves the camera to top-left direction.
		/// </summary>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public async Task<ResultBase> MoveTopLeft()
		{
			return await this.Execute<ResultBase>( "ptzMoveTopLeft" );
		}


		/// <summary>
		/// Moves the camera to top-right direction.
		/// </summary>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public async Task<ResultBase> MoveTopRight()
		{
			return await this.Execute<ResultBase>( "ptzMoveTopRight" );
		}


		/// <summary>
		/// Moves the camera to bottom-left direction.
		/// </summary>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public async Task<ResultBase> MoveBottomLeft()
		{
			return await this.Execute<ResultBase>( "ptzMoveBottomLeft" );
		}


		/// <summary>
		/// Moves the camera to bottom-right direction.
		/// </summary>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public async Task<ResultBase> MoveBottomRight()
		{
			return await this.Execute<ResultBase>( "ptzMoveBottomRight" );
		}


		/// <summary>
		/// Stops the current movement of the camera.
		/// </summary>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public async Task<ResultBase> StopMove()
		{
			return await this.Execute<ResultBase>( "ptzStopRun" );
		}


		/// <summary>
		/// Resets the camera to its default position.
		/// </summary>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public async Task<ResultBase> ResetPosition()
		{
			return await this.Execute<ResultBase>( "ptzReset" );
		}


		/// <summary>
		/// Returns the previously set speed for the pan-tilt-zoom operations.
		/// </summary>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The current pan-tilt-zoom speed setting.</returns>
		[SuppressMessage( "Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Conforms with the other control methods." )]
		public async Task<GetPtzSpeedResult> GetPtzSpeed()
		{
			return await this.Execute<GetPtzSpeedResult>( "getPTZSpeed" );
		}

		#endregion


		#region Network commands

		/// <summary>
		/// Gets the IP information of the camera.
		/// </summary>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The current IP configuration of the camera.</returns>
		[SuppressMessage( "Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Conforms with the other control methods." )]
		public async Task<GetIPInfoResult> GetIPInfo()
		{
			return await this.Execute<GetIPInfoResult>( "getIPInfo" );
		}

		#endregion


		#region Device management commands

		/// <summary>
		/// Gets the product model number of the camera.
		/// </summary>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The model number of the camera</returns>
		[SuppressMessage( "Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Conforms with the other control methods." )]
		public async Task<GetProductModelResult> GetProductModel()
		{
			return await this.Execute<GetProductModelResult>( "getProductModel" );
		}


		/// <summary>
		/// Gets the product model name of the camera.
		/// </summary>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>THe model name of the camera.</returns>
		[SuppressMessage( "Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Conforms with the other control methods." )]
		public async Task<GetProductModelNameResult> GetProductModelName()
		{
			return await this.Execute<GetProductModelNameResult>( "getProductModelName" );
		}

		#endregion


		#region Private helper methods

		/// <summary>
		/// Executes the specified command and returns its result in the specified format.
		/// </summary>
		/// <typeparam name="TResult">The type which describes the command result.</typeparam>
		/// <param name="commandName">The internal name of the command to execute. Must not be <c>null</c> or empty.</param>
		/// <returns>The result of the command execution.</returns>
		/// <remarks>
		/// The <c>Result</c> property of the returned object must be checked to verify whether the command executed successfully or not.
		/// </remarks>
		private async Task<TResult> Execute<TResult>( string commandName ) where TResult: ResultBase
		{
			// Input validation.
			Contract.Requires( !String.IsNullOrEmpty( commandName ) );
			Contract.Ensures( Contract.Result<TResult>() != null );

			// Build the command URL.
			string url = this.BuildCommandUrl( commandName );

			// Execute the command and download the raw XML result string.
			HttpClient client = new HttpClient();
			string result = await client.GetStringAsync( url );

			// Convert the raw XML result string to the expected result type.
			TextReader reader = new StringReader( result );
			XmlSerializer serializer = new XmlSerializer( typeof( TResult ) );
			return (TResult) serializer.Deserialize( reader );
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
			return String.Format( CultureInfo.InvariantCulture, @"http://{0}/cgi-bin/CGIProxy.fcgi?usr={1}&pwd={2}&cmd={3}", this.address, this.userName, this.password, commandName );
		}

		#endregion
	}
}

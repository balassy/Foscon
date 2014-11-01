using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Foscon.Client
{
	public partial class Camera
	{
		/// <summary>
		/// Gets the IP information of the camera.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The current IP configuration of the camera.</returns>
		[SuppressMessage( "Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Conforms with the other control methods." )]
		public Task<GetIPInfoResult> GetIPInfoAsync( CancellationToken token )
		{
			return this.ExecuteAsync<GetIPInfoResult>( "getIPInfo", token );
		}


		/// <summary>
		/// Gets the service ports of the camera.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The current port configuration of the camera.</returns>
		[SuppressMessage( "Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Conforms with the other control methods." )]
		public Task<GetPortInfoResult> GetPortInfoAsync( CancellationToken token )
		{
			return this.ExecuteAsync<GetPortInfoResult>( "getPortInfo", token );
		}


		/// <summary>
		/// Gets the Dynamic DNS configuration settings of the camera.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The current DDNS configuration of the camera.</returns>
		[SuppressMessage( "Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Conforms with the other control methods." )]
		public Task<GetDdnsConfigResult> GetDdnsConfigAsync( CancellationToken token )
		{
			return this.ExecuteAsync<GetDdnsConfigResult>( "getDDNSConfig", token );
		}


		/// <summary>
		/// Gets the FTP configuration settings of the camera.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The current FTP configuration of the camera.</returns>
		[SuppressMessage( "Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Conforms with the other control methods." )]
		public Task<GetFtpConfigResult> GetFtpConfigAsync( CancellationToken token )
		{
			return this.ExecuteAsync<GetFtpConfigResult>( "getFtpConfig", token );
		}
	}
}

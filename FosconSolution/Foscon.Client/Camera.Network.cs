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
	}
}

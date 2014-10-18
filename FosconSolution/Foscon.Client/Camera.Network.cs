using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace Foscon.Client
{
	public partial class Camera
	{
		/// <summary>
		/// Gets the IP information of the camera.
		/// </summary>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The current IP configuration of the camera.</returns>
		[SuppressMessage( "Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Conforms with the other control methods." )]
		public async Task<GetIPInfoResult> GetIPInfo()
		{
			return await this.Execute<GetIPInfoResult>( "getIPInfo" ).ConfigureAwait( false );
		}
	}
}

using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Foscon.Client
{
	public partial class Camera
	{
		/// <summary>
		/// Gets the detailed information about the camera device.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The version numbers and date settings of the camera.</returns>
		[SuppressMessage( "Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Conforms with the other control methods." )]
		public Task<GetDeviceInfoResult> GetDeviceInfoAsync( CancellationToken token )
		{
			return this.ExecuteAsync<GetDeviceInfoResult>( "getDevInfo", token );
		}

		/// <summary>
		/// Gets the product model number of the camera.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The model number of the camera</returns>
		[SuppressMessage( "Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Conforms with the other control methods." )]
		public Task<GetProductModelResult> GetProductModelAsync( CancellationToken token )
		{
			return this.ExecuteAsync<GetProductModelResult>( "getProductModel", token );
		}


		/// <summary>
		/// Gets the product model name of the camera.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The model name of the camera.</returns>
		[SuppressMessage( "Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Conforms with the other control methods." )]
		public Task<GetProductModelNameResult> GetProductModelNameAsync( CancellationToken token )
		{
			return this.ExecuteAsync<GetProductModelNameResult>( "getProductModelName", token );
		}


		/// <summary>
		/// Gets the current state of the various features of the camera.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The current states of the camera.</returns>
		[SuppressMessage( "Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Conforms with the other control methods." )]
		public Task<GetDeviceStateResult> GetDeviceStateAsync( CancellationToken token )
		{
			return this.ExecuteAsync<GetDeviceStateResult>( "getDevState", token );
		}
	}
}

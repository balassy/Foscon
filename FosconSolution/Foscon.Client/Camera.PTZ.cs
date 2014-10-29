using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Foscon.Client
{
	public partial class Camera
	{
		/// <summary>
		/// Moves the camera up.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public Task<ResultBase> MoveUpAsync( CancellationToken token )
		{
			return this.ExecuteAsync<ResultBase>( "ptzMoveUp", token );
		}


		/// <summary>
		/// Moves the camera down.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public Task<ResultBase> MoveDownAsync( CancellationToken token )
		{
			return this.ExecuteAsync<ResultBase>( "ptzMoveDown", token );
		}


		/// <summary>
		/// Moves the camera left.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public Task<ResultBase> MoveLeftAsync( CancellationToken token )
		{
			return this.ExecuteAsync<ResultBase>( "ptzMoveLeft", token );
		}


		/// <summary>
		/// Moves the camera right.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public Task<ResultBase> MoveRightAsync( CancellationToken token )
		{
			return this.ExecuteAsync<ResultBase>( "ptzMoveRight", token );
		}


		/// <summary>
		/// Moves the camera to top-left direction.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public Task<ResultBase> MoveTopLeftAsync( CancellationToken token )
		{
			return this.ExecuteAsync<ResultBase>( "ptzMoveTopLeft", token );
		}


		/// <summary>
		/// Moves the camera to top-right direction.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public Task<ResultBase> MoveTopRightAsync( CancellationToken token )
		{
			return this.ExecuteAsync<ResultBase>( "ptzMoveTopRight", token );
		}


		/// <summary>
		/// Moves the camera to bottom-left direction.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public Task<ResultBase> MoveBottomLeftAsync( CancellationToken token )
		{
			return this.ExecuteAsync<ResultBase>( "ptzMoveBottomLeft", token );
		}


		/// <summary>
		/// Moves the camera to bottom-right direction.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public Task<ResultBase> MoveBottomRightAsync( CancellationToken token )
		{
			return this.ExecuteAsync<ResultBase>( "ptzMoveBottomRight", token );
		}


		/// <summary>
		/// Stops the current movement of the camera.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public Task<ResultBase> StopMoveAsync( CancellationToken token )
		{
			return this.ExecuteAsync<ResultBase>( "ptzStopRun", token );
		}


		/// <summary>
		/// Resets the camera to its default position.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Operator privileges.</remarks>
		/// <returns>The result status of the operation.</returns>
		public Task<ResultBase> ResetPositionAsync( CancellationToken token )
		{
			return this.ExecuteAsync<ResultBase>( "ptzReset", token );
		}


		/// <summary>
		/// Returns the previously set speed for the pan-tilt-zoom operations.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The current pan-tilt-zoom speed setting.</returns>
		[SuppressMessage( "Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Conforms with the other control methods." )]
		public Task<GetPtzSpeedResult> GetPtzSpeedAsync( CancellationToken token )
		{
			return this.ExecuteAsync<GetPtzSpeedResult>( "getPTZSpeed", token );
		}


		/// <summary>
		/// Returns the list of the currently set pan-tilt-zoom preset points.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The names of the currently set preset points for pan-tilt-zoom.</returns>
		[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Conforms with the other control methods.")]
		public Task<GetPtzPresetPointListResult> GetPtzPresetPointListAsync( CancellationToken token )
		{
			return this.ExecuteAsync<GetPtzPresetPointListResult>( "getPTZPresetPointList", token );
		}


		/// <summary>
		/// Returns the previously set speed for the zoom operations.
		/// </summary>
		/// <param name="token">The token that can be used to cancel the operation.</param>
		/// <remarks>Requires Visitor privileges.</remarks>
		/// <returns>The current zoom speed setting.</returns>
		[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Conforms with the other control methods.")]
		public Task<GetZoomSpeedResult> GetZoomSpeedAsync( CancellationToken token )
		{
			return this.ExecuteAsync<GetZoomSpeedResult>( "getZoomSpeed", token );
		}
	}
}

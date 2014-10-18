using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace Foscon.Client
{
	public partial class Camera
	{
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
	}
}

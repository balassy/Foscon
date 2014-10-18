using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace Foscon.Client
{
	public partial class Camera
	{
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
		/// <returns>The model name of the camera.</returns>
		[SuppressMessage( "Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Conforms with the other control methods." )]
		public async Task<GetProductModelNameResult> GetProductModelName()
		{
			return await this.Execute<GetProductModelNameResult>( "getProductModelName" ).ConfigureAwait( false );
		}
	}
}

using System;


namespace R5T.T0152
{
	public class AssetsTagValues : IAssetsTagValues
	{
		#region Infrastructure

	    public static IAssetsTagValues Instance { get; } = new AssetsTagValues();

	    private AssetsTagValues()
	    {
        }

	    #endregion
	}
}
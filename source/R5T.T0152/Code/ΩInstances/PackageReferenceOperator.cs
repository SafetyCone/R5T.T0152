using System;


namespace R5T.T0152
{
	public class PackageReferenceOperator : IPackageReferenceOperator
	{
		#region Infrastructure

	    public static IPackageReferenceOperator Instance { get; } = new PackageReferenceOperator();

	    private PackageReferenceOperator()
	    {
        }

	    #endregion
	}
}
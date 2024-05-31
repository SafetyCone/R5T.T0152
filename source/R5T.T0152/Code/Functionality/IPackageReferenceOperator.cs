using System;

using R5T.T0132;


namespace R5T.T0152
{
	[FunctionalityMarker]
	public partial interface IPackageReferenceOperator : IFunctionalityMarker
	{
		public N001.PackageReference ToStringBasedPackageReference(PackageReference packageReference)
		{
			var output = new N001.PackageReference
			{
				Identity = packageReference.Identity,
				Version = Instances.VersionOperator.ToString_Major_Minor_Build(packageReference.Version),
				PrivateAssets = packageReference.PrivateAssets,
			};

			return output;
		}
	}
}
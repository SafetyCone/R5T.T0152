using System;
using System.Collections.Generic;
using System.Linq;

namespace R5T.T0152.Code.Extensions
{
	public static class PackageReferenceExtensions
	{
		public static N001.PackageReference ToStringBasedPackageReference(this PackageReference packageReference)
		{
			var output = PackageReferenceOperator.Instance.ToStringBasedPackageReference(packageReference);
			return output;
		}

		public static IEnumerable<N001.PackageReference> ToStringBasedPackageReferences(this IEnumerable<PackageReference> packageReferences)
		{
			var output = packageReferences
				.Select(x => x.ToStringBasedPackageReference())
				;

			return output;
		}
	}
}

using System;
using System.Collections.Generic;
using R5T.T0142;


namespace R5T.T0152.N001
{
	/// <summary>
	/// A fully string-based NuGet package reference type.
	/// </summary>
	[DataTypeMarker]
	public sealed class PackageReference : IDataTypeMarker, IEquatable<PackageReference>
	{
		#region Static

		public static bool operator ==(PackageReference left, PackageReference right)
		{
			return EqualityComparer<PackageReference>.Default.Equals(left, right);
		}

		public static bool operator !=(PackageReference left, PackageReference right)
		{
			return !(left == right);
		}

		#endregion

		/// <inheritdoc cref="T0152.PackageReference.Identity"/>
		public string Identity { get; set; }

        /// <inheritdoc cref="T0152.PackageReference.Version"/>
        public string Version { get; set; }

        /// <inheritdoc cref="T0152.PackageReference.PrivateAssets"/>
        public string PrivateAssets { get; set; }


        public bool Equals(PackageReference other)
		{
			if(other is null)
			{
				return false;
			}

			var output = true
				&& this.Identity == other.Identity
				&& this.Version == other.Version
				;

			return output;
		}

		public override bool Equals(object obj)
		{
			if(obj is PackageReference objAsPackageReference)
			{
				return this.Equals(objAsPackageReference);
			}

			return false;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(
				this.Identity,
				this.Version);
		}
	}
}

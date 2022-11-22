using System;

using R5T.T0131;


namespace R5T.T0152
{
    /// <summary>
    /// Source: <see href="https://learn.microsoft.com/en-us/nuget/consume-packages/package-references-in-project-files#controlling-dependency-assets"/>
    /// </summary>
    [ValuesMarker]
	public partial interface IAssetsTagValues : IValuesMarker
	{
        /// <summary>
        /// Contents of the lib folder and controls whether your project can compile against the assemblies within the folder.
        /// </summary>
        public string Compile => "compile";

        /// <summary>
        /// Contents of the lib and runtimes folder and controls whether these assemblies will be copied out to the build output directory.
        /// </summary>
        public string RunTime => "runtime";

        /// <summary>
        /// Contents of the contentfiles folder.
        /// </summary>
        public string ContentFiles => "contentfiles";

        /// <summary>
        /// .props and .targets in the build folder
        /// </summary>
        public string Build => "build";

        /// <summary>
        /// (4.0) .props and .targets in the buildMultitargeting folder, for cross-framework targeting
        /// </summary>
        public string BuildMultitargeting => "buildMultitargeting";

        /// <summary>
        /// (5.0+) .props and .targets in the buildTransitive folder, for assets that flow transitively to any consuming project. See the <see href="https://github.com/NuGet/Home/wiki/Allow-package--authors-to-define-build-assets-transitive-behavior">feature</see> page.
        /// </summary>
        public string BuildTransitive => "buildTransitive";

        /// <summary>
        /// .NET analyzers
        /// </summary>
        public string Analyzers => "analyzers";

        /// <summary>
        /// Contents of the native folder
        /// </summary>
        public string Native => "native";

        /// <summary>
        /// None of the above are used.
        /// </summary>
        public string None => "none";

        /// <summary>
        /// All of the above (except none)
        /// </summary>
        public string All => "all";
    }
}
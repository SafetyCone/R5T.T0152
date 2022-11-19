using System;

using R5T.T0142;


namespace R5T.T0152
{
    /// <summary>
    /// Represents a NuGet package reference (for example, in a project file).
    /// </summary>
    [DataTypeMarker]
    public class PackageReference
    {
        /// <summary>
        /// Example: Microsoft.AspNetCore.Components.WebAssembly.Server.
        /// </summary>
        public string Identity { get; set; }

        /// <summary>
        /// Example: 6.0.11
        /// </summary>
        public Version Version { get; set; }
    }
}

using System;

namespace PuppeteerSharp
{
    /// <summary>
    /// Platform used by a <see cref="BrowserFetcher"/>.
    /// </summary>
    public enum Platform
    {
        /// <summary>
        /// Unknown.
        /// </summary>
        Unknown,
        /// <summary>
        /// MacOS.
        /// </summary>
        MacOS,
        /// <summary>
        /// MacOS ARM64.
        /// </summary>
        MacOSArm,
        /// <summary>
        /// Linux.
        /// </summary>
        Linux,
        /// <summary>
        /// Linux ARM64.
        /// </summary>
        LinuxArm64,
        /// <summary>
        /// Win32.
        /// </summary>
        Win32,
        /// <summary>
        /// Win64.
        /// </summary>
        Win64,
        /// <summary>
        /// Win ARM64
        /// </summary>
        Win64Arm,
    }
}

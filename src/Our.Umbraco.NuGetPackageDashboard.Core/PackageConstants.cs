﻿namespace Our.Umbraco.NuGetPackageDashboard.Core
{
    internal static class PackageConstants
    {
        public const string Name = "NuGetPackageDashboard";
        public const string CacheKey = "Our.Umbraco.NuGetPackageDashboard:Packages";

        public static class XmlConfigSettings
        {
            public const string RootElementName = "packages";
            public const string PackageElementName = "package";
        }
    }
}

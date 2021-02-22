namespace TonyBark.WebApp
{
    public struct AppConsts
    {
        public const string APP_TITLE = "Web App";
        public const string LANGUAGE_NAME = "Akina";

        public static string Version => $"{ThisAssembly.Git.SemVer.Major}.{ThisAssembly.Git.SemVer.Minor}.{ThisAssembly.Git.SemVer.Patch}.";

        public static string VersionCommmit => $"{Version}-{ThisAssembly.Git.Commit}";
    }
}

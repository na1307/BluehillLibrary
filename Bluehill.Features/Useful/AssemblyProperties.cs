using System.Reflection;

namespace Bluehill;

public static class AssemblyProperties {
    private static readonly Assembly? EntryAssembly = Assembly.GetEntryAssembly();

    public static string AssemblyTitle {
        get {
            var attribute = GetAttribute<AssemblyTitleAttribute>();

            return attribute != null && !string.IsNullOrEmpty(attribute.Title) ? attribute.Title : Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly()!.Location)!;
        }
    }

    public static string VersionNumber {
        get {
            var attribute = GetAttribute<AssemblyFileVersionAttribute>();
#pragma warning disable SA1110 // Opening parenthesis or bracket should be on declaration line
            var version =
#if !NETFRAMEWORK || NET40_OR_GREATER
                Version.Parse
#else
                new Version
#endif
                (attribute?.Version ?? GetAttribute<AssemblyVersionAttribute>()!.Version);
#pragma warning restore SA1110 // Opening parenthesis or bracket should be on declaration line

            return version.ToString(2) + (version.Build == 0 ? string.Empty : $".{version.Build}");
        }
    }

    public static string AssemblyInformationalVersion {
        get {
            var attribute = GetAttribute<AssemblyInformationalVersionAttribute>();

            return attribute?.InformationalVersion ?? VersionNumber;
        }
    }

    public static string AssemblyDescription {
        get {
            var attribute = GetAttribute<AssemblyDescriptionAttribute>();

            return attribute?.Description ?? string.Empty;
        }
    }

    public static string AssemblyProduct {
        get {
            var attribute = GetAttribute<AssemblyProductAttribute>();

            return attribute?.Product ?? string.Empty;
        }
    }

    public static string AssemblyCopyright {
        get {
            var attribute = GetAttribute<AssemblyCopyrightAttribute>();

            return attribute?.Copyright ?? string.Empty;
        }
    }

    public static string AssemblyCompany {
        get {
            var attribute = GetAttribute<AssemblyCompanyAttribute>();

            return attribute?.Company ?? string.Empty;
        }
    }

    private static T? GetAttribute<T>() where T : Attribute => (T?)Attribute.GetCustomAttribute(EntryAssembly!, typeof(T));
}

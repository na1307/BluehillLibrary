namespace Bluehill;

public static class DriveInfoExtensions {
    public static string GetDriveLetter(this DriveInfo driveInfo) => driveInfo.Name.TrimEnd('\\');
}

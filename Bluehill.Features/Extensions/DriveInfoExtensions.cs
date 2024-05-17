namespace Bluehill;

public static class DriveInfoExtensions {
    public static char GetDriveLetter(this DriveInfo driveInfo) => driveInfo.Name[0];
    public static string GetDriveLetterAndColon(this DriveInfo driveInfo) => driveInfo.Name.TrimEnd('\\');
}

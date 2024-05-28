namespace Bluehill;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0057:범위 연산자 사용")]
public static class StringExtensions {
    /// <summary>
    /// <paramref name="source"/> 문자열에서 왼쪽으로 <paramref name="length"/>만큼의 문자열을 반환
    /// </summary>
    /// <param name="source">원본 문자열</param>
    /// <param name="length">자를 길이</param>
    /// <returns><paramref name="source"/>에서 <paramref name="length"/>만큼 자른 문자열</returns>
    public static string Left(this string source, int length) => source.Substring(0, length);

    /// <summary>
    /// <paramref name="source"/> 문자열에서 오른쪽으로 <paramref name="length"/>만큼의 문자열을 반환
    /// </summary>
    /// <param name="source">원본 문자열</param>
    /// <param name="length">자를 길이</param>
    /// <returns><paramref name="source"/>에서 <paramref name="length"/>만큼 자른 문자열</returns>
    public static string Right(this string source, int length) => source.Substring(source.Length - length);

    public static int Appears(this string source, string sub) => source.Split([sub], StringSplitOptions.None).Length - 1;

    public static string Piece(this string source, char delimiter, int position) => source.Piece(delimiter, position, int.MaxValue);

    public static string Piece(this string source, string delimiter, int position) => source.Piece(delimiter, position, int.MaxValue);

    public static string Piece(this string source, char delimiter, int position, int limit) => source.Piece(delimiter, position, limit, StringSplitOptions.None);

    public static string Piece(this string source, string delimiter, int position, int limit) => source.Piece(delimiter, position, limit, StringSplitOptions.None);

    public static string Piece(this string source, char delimiter, int position, int limit, StringSplitOptions options) {
        var strings = source.Split([delimiter], limit, options);

        return position >= 0 ? strings[position] : strings[strings.Length + position];
    }

    public static string Piece(this string source, string delimiter, int position, int limit, StringSplitOptions options) {
        var strings = source.Split([delimiter], limit, options);

        return position >= 0 ? strings[position] : strings[strings.Length + position];
    }

    public static string JoinStrings(this IEnumerable<string?> strings) => strings.JoinStrings(null);

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S3220:Method calls should not resolve ambiguously to overloads with \"params\"")]
    public static string JoinStrings(this IEnumerable<string?> strings, string? separator) => string.Join(separator, [.. strings]);
}

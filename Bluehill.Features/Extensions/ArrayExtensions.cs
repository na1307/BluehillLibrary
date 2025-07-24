namespace Bluehill;

public static class ArrayExtensions {
    public static ArraySegment<T> Slice<T>(this T[] array, int offset, int count) => new(array, offset, count);
#if NETCOREAPP2_1_OR_GREATER

    public static Span<T> SliceSpan<T>(this T[] array, int offset, int count) => new(array, offset, count);
#endif
}

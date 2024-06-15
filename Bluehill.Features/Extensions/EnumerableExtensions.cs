#if NET45_OR_GREATER || NETCOREAPP1_0_OR_GREATER
using System.Threading.Tasks;
#endif

namespace Bluehill;

public static class EnumerableExtensions {
    public static void ForEach<T>(this IEnumerable<T> source, Action<T> action) {
        foreach (var item in source) {
            action(item);
        }
    }
#if NET45_OR_GREATER || NETCOREAPP1_0_OR_GREATER

    public static async Task ForEach<T>(this IEnumerable<T> source, Func<T, Task> action) {
        foreach (var item in source) {
            await action(item);
        }
    }
#endif
#if NETCOREAPP3_0_OR_GREATER

    public static async Task ForEach<T>(this IAsyncEnumerable<T> source, Action<T> action) {
        await foreach (var item in source) {
            action(item);
        }
    }

    public static async Task ForEach<T>(this IAsyncEnumerable<T> source, Func<T, Task> action) {
        await foreach (var item in source) {
            await action(item);
        }
    }
#endif
}

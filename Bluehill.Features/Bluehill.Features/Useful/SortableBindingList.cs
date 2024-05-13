﻿#if NET35_OR_GREATER || NETSTANDARD1_0_OR_GREATER || NETCOREAPP1_0_OR_GREATER
using System.ComponentModel;
using System.Linq;

namespace Bluehill;

public class SortableBindingList<T> : BindingList<T> {
    private bool isSortedValue;
    private ListSortDirection sortDirectionValue;
    private PropertyDescriptor? sortPropertyValue;

    public SortableBindingList() { }
    public SortableBindingList(IList<T> list) : base(list) { }

    protected override PropertyDescriptor? SortPropertyCore => sortPropertyValue;
    protected override ListSortDirection SortDirectionCore => sortDirectionValue;
    protected override bool SupportsSortingCore => true;
    protected override bool IsSortedCore => isSortedValue;

    protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction) {
        var interfaceType = prop.PropertyType.GetInterface("IComparable");

        if (interfaceType == null && prop.PropertyType.IsValueType) {
            var underlyingType = Nullable.GetUnderlyingType(prop.PropertyType);

            if (underlyingType != null) {
                interfaceType = underlyingType.GetInterface("IComparable");
            }
        }

        if (interfaceType != null) {
            sortPropertyValue = prop;
            sortDirectionValue = direction;

            IEnumerable<T> query = Items;

            query = direction == ListSortDirection.Ascending
                ? query.OrderBy(i => prop.GetValue(i))
                : (IEnumerable<T>)query.OrderByDescending(i => prop.GetValue(i));

            var newIndex = 0;

            foreach (var item in query) {
                Items[newIndex] = item;
                newIndex++;
            }

            isSortedValue = true;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        } else {
            throw new NotSupportedException($"Cannot sort by {prop.Name}. This {prop.PropertyType} does not implement IComparable");
        }
    }
}
#endif

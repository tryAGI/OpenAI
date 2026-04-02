#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FiltersItem : global::System.IEquatable<FiltersItem>
    {
        /// <summary>
        /// A filter used to compare a specified attribute key to a given value using a defined comparison operation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComparisonFilter? ComparisonFilter { get; init; }
#else
        public global::tryAGI.OpenAI.ComparisonFilter? ComparisonFilter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComparisonFilter))]
#endif
        public bool IsComparisonFilter => ComparisonFilter != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? CompoundFilterVariant2 { get; init; }
#else
        public object? CompoundFilterVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompoundFilterVariant2))]
#endif
        public bool IsCompoundFilterVariant2 => CompoundFilterVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FiltersItem(global::tryAGI.OpenAI.ComparisonFilter value) => new FiltersItem((global::tryAGI.OpenAI.ComparisonFilter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComparisonFilter?(FiltersItem @this) => @this.ComparisonFilter;

        /// <summary>
        /// 
        /// </summary>
        public FiltersItem(global::tryAGI.OpenAI.ComparisonFilter? value)
        {
            ComparisonFilter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FiltersItem(
            global::tryAGI.OpenAI.ComparisonFilter? comparisonFilter,
            object? compoundFilterVariant2
            )
        {
            ComparisonFilter = comparisonFilter;
            CompoundFilterVariant2 = compoundFilterVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CompoundFilterVariant2 as object ??
            ComparisonFilter as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ComparisonFilter?.ToString() ??
            CompoundFilterVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsComparisonFilter && !IsCompoundFilterVariant2 || !IsComparisonFilter && IsCompoundFilterVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.ComparisonFilter?, TResult>? comparisonFilter = null,
            global::System.Func<object?, TResult>? compoundFilterVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComparisonFilter && comparisonFilter != null)
            {
                return comparisonFilter(ComparisonFilter!);
            }
            else if (IsCompoundFilterVariant2 && compoundFilterVariant2 != null)
            {
                return compoundFilterVariant2(CompoundFilterVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.ComparisonFilter?>? comparisonFilter = null,
            global::System.Action<object?>? compoundFilterVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComparisonFilter)
            {
                comparisonFilter?.Invoke(ComparisonFilter!);
            }
            else if (IsCompoundFilterVariant2)
            {
                compoundFilterVariant2?.Invoke(CompoundFilterVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ComparisonFilter,
                typeof(global::tryAGI.OpenAI.ComparisonFilter),
                CompoundFilterVariant2,
                typeof(object),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(FiltersItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComparisonFilter?>.Default.Equals(ComparisonFilter, other.ComparisonFilter) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(CompoundFilterVariant2, other.CompoundFilterVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FiltersItem obj1, FiltersItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FiltersItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FiltersItem obj1, FiltersItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FiltersItem o && Equals(o);
        }
    }
}

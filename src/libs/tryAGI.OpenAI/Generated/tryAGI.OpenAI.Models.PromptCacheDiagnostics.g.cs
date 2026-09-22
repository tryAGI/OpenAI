#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Prompt cache diagnostics requested for this response.
    /// </summary>
    public readonly partial struct PromptCacheDiagnostics : global::System.IEquatable<PromptCacheDiagnostics>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody? CacheMiss { get; init; }
#else
        public global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody? CacheMiss { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CacheMiss))]
#endif
        public bool IsCacheMiss => CacheMiss != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCacheMiss(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody? value)
        {
            value = CacheMiss;
            return IsCacheMiss;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody PickCacheMiss() => IsCacheMiss
            ? CacheMiss!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CacheMiss' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody? CacheHit { get; init; }
#else
        public global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody? CacheHit { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CacheHit))]
#endif
        public bool IsCacheHit => CacheHit != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCacheHit(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody? value)
        {
            value = CacheHit;
            return IsCacheHit;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody PickCacheHit() => IsCacheHit
            ? CacheHit!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CacheHit' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody? ComparisonResponseNotFound { get; init; }
#else
        public global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody? ComparisonResponseNotFound { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComparisonResponseNotFound))]
#endif
        public bool IsComparisonResponseNotFound => ComparisonResponseNotFound != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComparisonResponseNotFound(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody? value)
        {
            value = ComparisonResponseNotFound;
            return IsComparisonResponseNotFound;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody PickComparisonResponseNotFound() => IsComparisonResponseNotFound
            ? ComparisonResponseNotFound!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComparisonResponseNotFound' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody? Unavailable { get; init; }
#else
        public global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody? Unavailable { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unavailable))]
#endif
        public bool IsUnavailable => Unavailable != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnavailable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody? value)
        {
            value = Unavailable;
            return IsUnavailable;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody PickUnavailable() => IsUnavailable
            ? Unavailable!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Unavailable' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptCacheDiagnostics(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody value) => new PromptCacheDiagnostics((global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody?(PromptCacheDiagnostics @this) => @this.CacheMiss;

        /// <summary>
        ///
        /// </summary>
        public PromptCacheDiagnostics(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody? value)
        {
            CacheMiss = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptCacheDiagnostics FromCacheMiss(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody? value) => new PromptCacheDiagnostics(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptCacheDiagnostics(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody value) => new PromptCacheDiagnostics((global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody?(PromptCacheDiagnostics @this) => @this.CacheHit;

        /// <summary>
        ///
        /// </summary>
        public PromptCacheDiagnostics(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody? value)
        {
            CacheHit = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptCacheDiagnostics FromCacheHit(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody? value) => new PromptCacheDiagnostics(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptCacheDiagnostics(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody value) => new PromptCacheDiagnostics((global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody?(PromptCacheDiagnostics @this) => @this.ComparisonResponseNotFound;

        /// <summary>
        ///
        /// </summary>
        public PromptCacheDiagnostics(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody? value)
        {
            ComparisonResponseNotFound = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptCacheDiagnostics FromComparisonResponseNotFound(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody? value) => new PromptCacheDiagnostics(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptCacheDiagnostics(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody value) => new PromptCacheDiagnostics((global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody?(PromptCacheDiagnostics @this) => @this.Unavailable;

        /// <summary>
        ///
        /// </summary>
        public PromptCacheDiagnostics(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody? value)
        {
            Unavailable = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptCacheDiagnostics FromUnavailable(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody? value) => new PromptCacheDiagnostics(value);

        /// <summary>
        ///
        /// </summary>
        public PromptCacheDiagnostics(
            global::tryAGI.OpenAI.PromptCacheDiagnosticsDiscriminatorType? type,
            global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody? cacheMiss,
            global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody? cacheHit,
            global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody? comparisonResponseNotFound,
            global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody? unavailable
            )
        {
            Type = type;

            CacheMiss = cacheMiss;
            CacheHit = cacheHit;
            ComparisonResponseNotFound = comparisonResponseNotFound;
            Unavailable = unavailable;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Unavailable as object ??
            ComparisonResponseNotFound as object ??
            CacheHit as object ??
            CacheMiss as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CacheMiss?.ToString() ??
            CacheHit?.ToString() ??
            ComparisonResponseNotFound?.ToString() ??
            Unavailable?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCacheMiss && !IsCacheHit && !IsComparisonResponseNotFound && !IsUnavailable || !IsCacheMiss && IsCacheHit && !IsComparisonResponseNotFound && !IsUnavailable || !IsCacheMiss && !IsCacheHit && IsComparisonResponseNotFound && !IsUnavailable || !IsCacheMiss && !IsCacheHit && !IsComparisonResponseNotFound && IsUnavailable;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody, TResult>? cacheMiss = null,
            global::System.Func<global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody, TResult>? cacheHit = null,
            global::System.Func<global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody, TResult>? comparisonResponseNotFound = null,
            global::System.Func<global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody, TResult>? unavailable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCacheMiss && cacheMiss != null)
            {
                return cacheMiss(CacheMiss!);
            }
            else if (IsCacheHit && cacheHit != null)
            {
                return cacheHit(CacheHit!);
            }
            else if (IsComparisonResponseNotFound && comparisonResponseNotFound != null)
            {
                return comparisonResponseNotFound(ComparisonResponseNotFound!);
            }
            else if (IsUnavailable && unavailable != null)
            {
                return unavailable(Unavailable!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody>? cacheMiss = null,

            global::System.Action<global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody>? cacheHit = null,

            global::System.Action<global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody>? comparisonResponseNotFound = null,

            global::System.Action<global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody>? unavailable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCacheMiss)
            {
                cacheMiss?.Invoke(CacheMiss!);
            }
            else if (IsCacheHit)
            {
                cacheHit?.Invoke(CacheHit!);
            }
            else if (IsComparisonResponseNotFound)
            {
                comparisonResponseNotFound?.Invoke(ComparisonResponseNotFound!);
            }
            else if (IsUnavailable)
            {
                unavailable?.Invoke(Unavailable!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody>? cacheMiss = null,
            global::System.Action<global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody>? cacheHit = null,
            global::System.Action<global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody>? comparisonResponseNotFound = null,
            global::System.Action<global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody>? unavailable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCacheMiss)
            {
                cacheMiss?.Invoke(CacheMiss!);
            }
            else if (IsCacheHit)
            {
                cacheHit?.Invoke(CacheHit!);
            }
            else if (IsComparisonResponseNotFound)
            {
                comparisonResponseNotFound?.Invoke(ComparisonResponseNotFound!);
            }
            else if (IsUnavailable)
            {
                unavailable?.Invoke(Unavailable!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CacheMiss,
                typeof(global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody),
                CacheHit,
                typeof(global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody),
                ComparisonResponseNotFound,
                typeof(global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody),
                Unavailable,
                typeof(global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody),
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
        public bool Equals(PromptCacheDiagnostics other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PromptCacheMissDiagnosticsBody?>.Default.Equals(CacheMiss, other.CacheMiss) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PromptCacheHitDiagnosticsBody?>.Default.Equals(CacheHit, other.CacheHit) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PromptCacheComparisonResponseNotFoundDiagnosticsBody?>.Default.Equals(ComparisonResponseNotFound, other.ComparisonResponseNotFound) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBody?>.Default.Equals(Unavailable, other.Unavailable)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PromptCacheDiagnostics obj1, PromptCacheDiagnostics obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PromptCacheDiagnostics>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PromptCacheDiagnostics obj1, PromptCacheDiagnostics obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptCacheDiagnostics o && Equals(o);
        }
    }
}

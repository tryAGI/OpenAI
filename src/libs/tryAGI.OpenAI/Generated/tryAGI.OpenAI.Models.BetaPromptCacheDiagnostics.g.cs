#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Prompt cache diagnostics requested for this response.
    /// </summary>
    public readonly partial struct BetaPromptCacheDiagnostics : global::System.IEquatable<BetaPromptCacheDiagnostics>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody? CacheMiss { get; init; }
#else
        public global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody? CacheMiss { get; }
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
            out global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody? value)
        {
            value = CacheMiss;
            return IsCacheMiss;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody PickCacheMiss() => IsCacheMiss
            ? CacheMiss!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CacheMiss' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody? CacheHit { get; init; }
#else
        public global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody? CacheHit { get; }
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
            out global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody? value)
        {
            value = CacheHit;
            return IsCacheHit;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody PickCacheHit() => IsCacheHit
            ? CacheHit!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CacheHit' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody? ComparisonResponseNotFound { get; init; }
#else
        public global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody? ComparisonResponseNotFound { get; }
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
            out global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody? value)
        {
            value = ComparisonResponseNotFound;
            return IsComparisonResponseNotFound;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody PickComparisonResponseNotFound() => IsComparisonResponseNotFound
            ? ComparisonResponseNotFound!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComparisonResponseNotFound' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody? Unavailable { get; init; }
#else
        public global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody? Unavailable { get; }
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
            out global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody? value)
        {
            value = Unavailable;
            return IsUnavailable;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody PickUnavailable() => IsUnavailable
            ? Unavailable!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Unavailable' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaPromptCacheDiagnostics(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody value) => new BetaPromptCacheDiagnostics((global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody?(BetaPromptCacheDiagnostics @this) => @this.CacheMiss;

        /// <summary>
        ///
        /// </summary>
        public BetaPromptCacheDiagnostics(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody? value)
        {
            CacheMiss = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaPromptCacheDiagnostics FromCacheMiss(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody? value) => new BetaPromptCacheDiagnostics(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaPromptCacheDiagnostics(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody value) => new BetaPromptCacheDiagnostics((global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody?(BetaPromptCacheDiagnostics @this) => @this.CacheHit;

        /// <summary>
        ///
        /// </summary>
        public BetaPromptCacheDiagnostics(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody? value)
        {
            CacheHit = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaPromptCacheDiagnostics FromCacheHit(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody? value) => new BetaPromptCacheDiagnostics(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaPromptCacheDiagnostics(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody value) => new BetaPromptCacheDiagnostics((global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody?(BetaPromptCacheDiagnostics @this) => @this.ComparisonResponseNotFound;

        /// <summary>
        ///
        /// </summary>
        public BetaPromptCacheDiagnostics(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody? value)
        {
            ComparisonResponseNotFound = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaPromptCacheDiagnostics FromComparisonResponseNotFound(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody? value) => new BetaPromptCacheDiagnostics(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaPromptCacheDiagnostics(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody value) => new BetaPromptCacheDiagnostics((global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody?(BetaPromptCacheDiagnostics @this) => @this.Unavailable;

        /// <summary>
        ///
        /// </summary>
        public BetaPromptCacheDiagnostics(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody? value)
        {
            Unavailable = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaPromptCacheDiagnostics FromUnavailable(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody? value) => new BetaPromptCacheDiagnostics(value);

        /// <summary>
        ///
        /// </summary>
        public BetaPromptCacheDiagnostics(
            global::tryAGI.OpenAI.BetaPromptCacheDiagnosticsDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody? cacheMiss,
            global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody? cacheHit,
            global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody? comparisonResponseNotFound,
            global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody? unavailable
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
            global::System.Func<global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody, TResult>? cacheMiss = null,
            global::System.Func<global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody, TResult>? cacheHit = null,
            global::System.Func<global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody, TResult>? comparisonResponseNotFound = null,
            global::System.Func<global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody, TResult>? unavailable = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody>? cacheMiss = null,

            global::System.Action<global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody>? cacheHit = null,

            global::System.Action<global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody>? comparisonResponseNotFound = null,

            global::System.Action<global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody>? unavailable = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody>? cacheMiss = null,
            global::System.Action<global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody>? cacheHit = null,
            global::System.Action<global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody>? comparisonResponseNotFound = null,
            global::System.Action<global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody>? unavailable = null,
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
                typeof(global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody),
                CacheHit,
                typeof(global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody),
                ComparisonResponseNotFound,
                typeof(global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody),
                Unavailable,
                typeof(global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody),
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
        public bool Equals(BetaPromptCacheDiagnostics other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaPromptCacheMissDiagnosticsBody?>.Default.Equals(CacheMiss, other.CacheMiss) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaPromptCacheHitDiagnosticsBody?>.Default.Equals(CacheHit, other.CacheHit) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaPromptCacheComparisonResponseNotFoundDiagnosticsBody?>.Default.Equals(ComparisonResponseNotFound, other.ComparisonResponseNotFound) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBody?>.Default.Equals(Unavailable, other.Unavailable)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaPromptCacheDiagnostics obj1, BetaPromptCacheDiagnostics obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaPromptCacheDiagnostics>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaPromptCacheDiagnostics obj1, BetaPromptCacheDiagnostics obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaPromptCacheDiagnostics o && Equals(o);
        }
    }
}

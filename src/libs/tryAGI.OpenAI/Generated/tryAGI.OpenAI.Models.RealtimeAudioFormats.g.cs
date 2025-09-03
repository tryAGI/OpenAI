#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RealtimeAudioFormats : global::System.IEquatable<RealtimeAudioFormats>
    {
        /// <summary>
        /// The PCM audio format. Only a 24kHz sample rate is supported.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeAudioFormatsVariant1? Value1 { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeAudioFormatsVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeAudioFormats(global::tryAGI.OpenAI.RealtimeAudioFormatsVariant1 value) => new RealtimeAudioFormats((global::tryAGI.OpenAI.RealtimeAudioFormatsVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeAudioFormatsVariant1?(RealtimeAudioFormats @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeAudioFormats(global::tryAGI.OpenAI.RealtimeAudioFormatsVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// The G.711 μ-law format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeAudioFormatsVariant2? Value2 { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeAudioFormatsVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeAudioFormats(global::tryAGI.OpenAI.RealtimeAudioFormatsVariant2 value) => new RealtimeAudioFormats((global::tryAGI.OpenAI.RealtimeAudioFormatsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeAudioFormatsVariant2?(RealtimeAudioFormats @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeAudioFormats(global::tryAGI.OpenAI.RealtimeAudioFormatsVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// The G.711 A-law format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeAudioFormatsVariant3? Value3 { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeAudioFormatsVariant3? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeAudioFormats(global::tryAGI.OpenAI.RealtimeAudioFormatsVariant3 value) => new RealtimeAudioFormats((global::tryAGI.OpenAI.RealtimeAudioFormatsVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeAudioFormatsVariant3?(RealtimeAudioFormats @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeAudioFormats(global::tryAGI.OpenAI.RealtimeAudioFormatsVariant3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RealtimeAudioFormats(
            global::tryAGI.OpenAI.RealtimeAudioFormatsVariant1? value1,
            global::tryAGI.OpenAI.RealtimeAudioFormatsVariant2? value2,
            global::tryAGI.OpenAI.RealtimeAudioFormatsVariant3? value3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RealtimeAudioFormatsVariant1?, TResult>? value1 = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeAudioFormatsVariant2?, TResult>? value2 = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeAudioFormatsVariant3?, TResult>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RealtimeAudioFormatsVariant1?>? value1 = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeAudioFormatsVariant2?>? value2 = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeAudioFormatsVariant3?>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsVariant1),
                Value2,
                typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsVariant2),
                Value3,
                typeof(global::tryAGI.OpenAI.RealtimeAudioFormatsVariant3),
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
        public bool Equals(RealtimeAudioFormats other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeAudioFormatsVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeAudioFormatsVariant2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeAudioFormatsVariant3?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RealtimeAudioFormats obj1, RealtimeAudioFormats obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RealtimeAudioFormats>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RealtimeAudioFormats obj1, RealtimeAudioFormats obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RealtimeAudioFormats o && Equals(o);
        }
    }
}

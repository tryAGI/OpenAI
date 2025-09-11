#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for turn detection, ether Server VAD or Semantic VAD. This can be set to `null` to turn off, in which case the client must manually trigger model response.<br/>
    /// Server VAD means that the model will detect the start and end of speech based on audio volume and respond at the end of user speech.<br/>
    /// Semantic VAD is more advanced and uses a turn detection model (in conjunction with VAD) to semantically estimate whether the user has finished speaking, then dynamically sets a timeout based on this probability. For example, if user audio trails off with "uhhm", the model will score a low probability of turn end and wait longer for the user to continue speaking. This can be useful for more natural conversations, but may have a higher latency.
    /// </summary>
    public readonly partial struct RealtimeTurnDetection : global::System.IEquatable<RealtimeTurnDetection>
    {
        /// <summary>
        /// Server-side voice activity detection (VAD) which flips on when user speech is detected and off after a period of silence.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTurnDetectionVariant1? Value1 { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTurnDetectionVariant1? Value1 { get; }
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
        public static implicit operator RealtimeTurnDetection(global::tryAGI.OpenAI.RealtimeTurnDetectionVariant1 value) => new RealtimeTurnDetection((global::tryAGI.OpenAI.RealtimeTurnDetectionVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTurnDetectionVariant1?(RealtimeTurnDetection @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTurnDetection(global::tryAGI.OpenAI.RealtimeTurnDetectionVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// Server-side semantic turn detection which uses a model to determine when the user has finished speaking.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTurnDetectionVariant2? Value2 { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTurnDetectionVariant2? Value2 { get; }
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
        public static implicit operator RealtimeTurnDetection(global::tryAGI.OpenAI.RealtimeTurnDetectionVariant2 value) => new RealtimeTurnDetection((global::tryAGI.OpenAI.RealtimeTurnDetectionVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTurnDetectionVariant2?(RealtimeTurnDetection @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTurnDetection(global::tryAGI.OpenAI.RealtimeTurnDetectionVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTurnDetection(
            global::tryAGI.OpenAI.RealtimeTurnDetectionVariant1? value1,
            global::tryAGI.OpenAI.RealtimeTurnDetectionVariant2? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RealtimeTurnDetectionVariant1?, TResult>? value1 = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeTurnDetectionVariant2?, TResult>? value2 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RealtimeTurnDetectionVariant1?>? value1 = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeTurnDetectionVariant2?>? value2 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionVariant1),
                Value2,
                typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionVariant2),
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
        public bool Equals(RealtimeTurnDetection other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTurnDetectionVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTurnDetectionVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RealtimeTurnDetection obj1, RealtimeTurnDetection obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RealtimeTurnDetection>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RealtimeTurnDetection obj1, RealtimeTurnDetection obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RealtimeTurnDetection o && Equals(o);
        }
    }
}

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for turn detection, ether Server VAD or Semantic VAD. This can be set to `null` to turn off, in which case the client must manually trigger model response.<br/>
    /// Server VAD means that the model will detect the start and end of speech based on audio volume and respond at the end of user speech.<br/>
    /// Semantic VAD is more advanced and uses a turn detection model (in conjunction with VAD) to semantically estimate whether the user has finished speaking, then dynamically sets a timeout based on this probability. For example, if user audio trails off with "uhhm", the model will score a low probability of turn end and wait longer for the user to continue speaking. This can be useful for more natural conversations, but may have a higher latency.
    /// </summary>
    public readonly partial struct RealtimeTurnDetectionRealtimeTurnDetection1 : global::System.IEquatable<RealtimeTurnDetectionRealtimeTurnDetection1>
    {
        /// <summary>
        /// Server-side voice activity detection (VAD) which flips on when user speech is detected and off after a period of silence.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad? ServerVad { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad? ServerVad { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ServerVad))]
#endif
        public bool IsServerVad => ServerVad != null;

        /// <summary>
        /// Server-side semantic turn detection which uses a model to determine when the user has finished speaking.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad? SemanticVad { get; init; }
#else
        public global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad? SemanticVad { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SemanticVad))]
#endif
        public bool IsSemanticVad => SemanticVad != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTurnDetectionRealtimeTurnDetection1(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad value) => new RealtimeTurnDetectionRealtimeTurnDetection1((global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad?(RealtimeTurnDetectionRealtimeTurnDetection1 @this) => @this.ServerVad;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTurnDetectionRealtimeTurnDetection1(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad? value)
        {
            ServerVad = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTurnDetectionRealtimeTurnDetection1(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad value) => new RealtimeTurnDetectionRealtimeTurnDetection1((global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad?(RealtimeTurnDetectionRealtimeTurnDetection1 @this) => @this.SemanticVad;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTurnDetectionRealtimeTurnDetection1(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad? value)
        {
            SemanticVad = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTurnDetectionRealtimeTurnDetection1(
            global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad? serverVad,
            global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad? semanticVad
            )
        {
            ServerVad = serverVad;
            SemanticVad = semanticVad;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SemanticVad as object ??
            ServerVad as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ServerVad?.ToString() ??
            SemanticVad?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsServerVad && !IsSemanticVad || !IsServerVad && IsSemanticVad;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad?, TResult>? serverVad = null,
            global::System.Func<global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad?, TResult>? semanticVad = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsServerVad && serverVad != null)
            {
                return serverVad(ServerVad!);
            }
            else if (IsSemanticVad && semanticVad != null)
            {
                return semanticVad(SemanticVad!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad?>? serverVad = null,
            global::System.Action<global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad?>? semanticVad = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsServerVad)
            {
                serverVad?.Invoke(ServerVad!);
            }
            else if (IsSemanticVad)
            {
                semanticVad?.Invoke(SemanticVad!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ServerVad,
                typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad),
                SemanticVad,
                typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad),
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
        public bool Equals(RealtimeTurnDetectionRealtimeTurnDetection1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad?>.Default.Equals(ServerVad, other.ServerVad) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad?>.Default.Equals(SemanticVad, other.SemanticVad) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RealtimeTurnDetectionRealtimeTurnDetection1 obj1, RealtimeTurnDetectionRealtimeTurnDetection1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RealtimeTurnDetectionRealtimeTurnDetection1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RealtimeTurnDetectionRealtimeTurnDetection1 obj1, RealtimeTurnDetectionRealtimeTurnDetection1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RealtimeTurnDetectionRealtimeTurnDetection1 o && Equals(o);
        }
    }
}

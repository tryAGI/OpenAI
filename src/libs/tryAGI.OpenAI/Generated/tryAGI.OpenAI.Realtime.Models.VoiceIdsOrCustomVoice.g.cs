#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// A built-in voice name or a custom voice reference.
    /// </summary>
    public readonly partial struct VoiceIdsOrCustomVoice : global::System.IEquatable<VoiceIdsOrCustomVoice>
    {
        /// <summary>
        /// Example: ash
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.VoiceIdsShared? Shared { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.VoiceIdsShared? Shared { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared))]
#endif
        public bool IsShared => Shared != null;

        /// <summary>
        /// Custom voice reference.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.VoiceIdsOrCustomVoiceVariant2? VoiceIdsOrCustomVoiceVariant2 { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.VoiceIdsOrCustomVoiceVariant2? VoiceIdsOrCustomVoiceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VoiceIdsOrCustomVoiceVariant2))]
#endif
        public bool IsVoiceIdsOrCustomVoiceVariant2 => VoiceIdsOrCustomVoiceVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VoiceIdsOrCustomVoice(global::tryAGI.OpenAI.Realtime.VoiceIdsShared value) => new VoiceIdsOrCustomVoice((global::tryAGI.OpenAI.Realtime.VoiceIdsShared?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.VoiceIdsShared?(VoiceIdsOrCustomVoice @this) => @this.Shared;

        /// <summary>
        /// 
        /// </summary>
        public VoiceIdsOrCustomVoice(global::tryAGI.OpenAI.Realtime.VoiceIdsShared? value)
        {
            Shared = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VoiceIdsOrCustomVoice(global::tryAGI.OpenAI.Realtime.VoiceIdsOrCustomVoiceVariant2 value) => new VoiceIdsOrCustomVoice((global::tryAGI.OpenAI.Realtime.VoiceIdsOrCustomVoiceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.VoiceIdsOrCustomVoiceVariant2?(VoiceIdsOrCustomVoice @this) => @this.VoiceIdsOrCustomVoiceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public VoiceIdsOrCustomVoice(global::tryAGI.OpenAI.Realtime.VoiceIdsOrCustomVoiceVariant2? value)
        {
            VoiceIdsOrCustomVoiceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VoiceIdsOrCustomVoice(
            global::tryAGI.OpenAI.Realtime.VoiceIdsShared? shared,
            global::tryAGI.OpenAI.Realtime.VoiceIdsOrCustomVoiceVariant2? voiceIdsOrCustomVoiceVariant2
            )
        {
            Shared = shared;
            VoiceIdsOrCustomVoiceVariant2 = voiceIdsOrCustomVoiceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VoiceIdsOrCustomVoiceVariant2 as object ??
            Shared as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Shared?.ToString() ??
            VoiceIdsOrCustomVoiceVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsShared || IsVoiceIdsOrCustomVoiceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.Realtime.VoiceIdsShared?, TResult>? shared = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.VoiceIdsOrCustomVoiceVariant2?, TResult>? voiceIdsOrCustomVoiceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared && shared != null)
            {
                return shared(Shared!);
            }
            else if (IsVoiceIdsOrCustomVoiceVariant2 && voiceIdsOrCustomVoiceVariant2 != null)
            {
                return voiceIdsOrCustomVoiceVariant2(VoiceIdsOrCustomVoiceVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.Realtime.VoiceIdsShared?>? shared = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.VoiceIdsOrCustomVoiceVariant2?>? voiceIdsOrCustomVoiceVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsShared)
            {
                shared?.Invoke(Shared!);
            }
            else if (IsVoiceIdsOrCustomVoiceVariant2)
            {
                voiceIdsOrCustomVoiceVariant2?.Invoke(VoiceIdsOrCustomVoiceVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared,
                typeof(global::tryAGI.OpenAI.Realtime.VoiceIdsShared),
                VoiceIdsOrCustomVoiceVariant2,
                typeof(global::tryAGI.OpenAI.Realtime.VoiceIdsOrCustomVoiceVariant2),
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
        public bool Equals(VoiceIdsOrCustomVoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.VoiceIdsShared?>.Default.Equals(Shared, other.Shared) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.VoiceIdsOrCustomVoiceVariant2?>.Default.Equals(VoiceIdsOrCustomVoiceVariant2, other.VoiceIdsOrCustomVoiceVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VoiceIdsOrCustomVoice obj1, VoiceIdsOrCustomVoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VoiceIdsOrCustomVoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VoiceIdsOrCustomVoice obj1, VoiceIdsOrCustomVoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VoiceIdsOrCustomVoice o && Equals(o);
        }
    }
}

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Audio encoding and sample rate for audio sent and received over a Live WebSocket connection. WebRTC and SIP negotiate their media format separately.
    /// </summary>
    public readonly partial struct LiveAudioFormat : global::System.IEquatable<LiveAudioFormat>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveAudioFormatDiscriminatorType? Type { get; }

        /// <summary>
        /// Raw, mono 16-bit little-endian PCM audio for a Live WebSocket connection.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam? AudioPcm { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam? AudioPcm { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioPcm))]
#endif
        public bool IsAudioPcm => AudioPcm != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudioPcm(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam? value)
        {
            value = AudioPcm;
            return IsAudioPcm;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam PickAudioPcm() => IsAudioPcm
            ? AudioPcm!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioPcm' but the value was {ToString()}.");

        /// <summary>
        /// Raw, mono G.711 μ-law audio for a Live WebSocket connection.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam? AudioPcmu { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam? AudioPcmu { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioPcmu))]
#endif
        public bool IsAudioPcmu => AudioPcmu != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudioPcmu(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam? value)
        {
            value = AudioPcmu;
            return IsAudioPcmu;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam PickAudioPcmu() => IsAudioPcmu
            ? AudioPcmu!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioPcmu' but the value was {ToString()}.");

        /// <summary>
        /// Raw, mono G.711 A-law audio for a Live WebSocket connection.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam? AudioPcma { get; init; }
#else
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam? AudioPcma { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioPcma))]
#endif
        public bool IsAudioPcma => AudioPcma != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudioPcma(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam? value)
        {
            value = AudioPcma;
            return IsAudioPcma;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam PickAudioPcma() => IsAudioPcma
            ? AudioPcma!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioPcma' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveAudioFormat(global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam value) => new LiveAudioFormat((global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam?(LiveAudioFormat @this) => @this.AudioPcm;

        /// <summary>
        ///
        /// </summary>
        public LiveAudioFormat(global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam? value)
        {
            AudioPcm = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveAudioFormat FromAudioPcm(global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam? value) => new LiveAudioFormat(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveAudioFormat(global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam value) => new LiveAudioFormat((global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam?(LiveAudioFormat @this) => @this.AudioPcmu;

        /// <summary>
        ///
        /// </summary>
        public LiveAudioFormat(global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam? value)
        {
            AudioPcmu = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveAudioFormat FromAudioPcmu(global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam? value) => new LiveAudioFormat(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveAudioFormat(global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam value) => new LiveAudioFormat((global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam?(LiveAudioFormat @this) => @this.AudioPcma;

        /// <summary>
        ///
        /// </summary>
        public LiveAudioFormat(global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam? value)
        {
            AudioPcma = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveAudioFormat FromAudioPcma(global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam? value) => new LiveAudioFormat(value);

        /// <summary>
        ///
        /// </summary>
        public LiveAudioFormat(
            global::tryAGI.OpenAI.LiveAudioFormatDiscriminatorType? type,
            global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam? audioPcm,
            global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam? audioPcmu,
            global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam? audioPcma
            )
        {
            Type = type;

            AudioPcm = audioPcm;
            AudioPcmu = audioPcmu;
            AudioPcma = audioPcma;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AudioPcma as object ??
            AudioPcmu as object ??
            AudioPcm as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AudioPcm?.ToString() ??
            AudioPcmu?.ToString() ??
            AudioPcma?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAudioPcm && !IsAudioPcmu && !IsAudioPcma || !IsAudioPcm && IsAudioPcmu && !IsAudioPcma || !IsAudioPcm && !IsAudioPcmu && IsAudioPcma;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam, TResult>? audioPcm = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam, TResult>? audioPcmu = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam, TResult>? audioPcma = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioPcm && audioPcm != null)
            {
                return audioPcm(AudioPcm!);
            }
            else if (IsAudioPcmu && audioPcmu != null)
            {
                return audioPcmu(AudioPcmu!);
            }
            else if (IsAudioPcma && audioPcma != null)
            {
                return audioPcma(AudioPcma!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam>? audioPcm = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam>? audioPcmu = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam>? audioPcma = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioPcm)
            {
                audioPcm?.Invoke(AudioPcm!);
            }
            else if (IsAudioPcmu)
            {
                audioPcmu?.Invoke(AudioPcmu!);
            }
            else if (IsAudioPcma)
            {
                audioPcma?.Invoke(AudioPcma!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam>? audioPcm = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam>? audioPcmu = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam>? audioPcma = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioPcm)
            {
                audioPcm?.Invoke(AudioPcm!);
            }
            else if (IsAudioPcmu)
            {
                audioPcmu?.Invoke(AudioPcmu!);
            }
            else if (IsAudioPcma)
            {
                audioPcma?.Invoke(AudioPcma!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AudioPcm,
                typeof(global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam),
                AudioPcmu,
                typeof(global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam),
                AudioPcma,
                typeof(global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam),
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
        public bool Equals(LiveAudioFormat other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParam?>.Default.Equals(AudioPcm, other.AudioPcm) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParam?>.Default.Equals(AudioPcmu, other.AudioPcmu) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParam?>.Default.Equals(AudioPcma, other.AudioPcma)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(LiveAudioFormat obj1, LiveAudioFormat obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LiveAudioFormat>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(LiveAudioFormat obj1, LiveAudioFormat obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LiveAudioFormat o && Equals(o);
        }
    }
}

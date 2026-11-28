#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Controls how the audio is cut into chunks. When set to `"auto"`, the<br/>
    /// server first normalizes loudness and then uses voice activity detection (VAD) to<br/>
    /// choose boundaries. `server_vad` object can be provided to tweak VAD detection<br/>
    /// parameters manually. If unset, the audio is transcribed as a single block.
    /// </summary>
    public readonly partial struct TranscriptionChunkingStrategy : global::System.IEquatable<TranscriptionChunkingStrategy>
    {
        /// <summary>
        /// Automatically set chunking parameters based on the audio. Must be set to `"auto"`.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? TranscriptionChunkingStrategyVariant1 { get; init; }
#else
        public string? TranscriptionChunkingStrategyVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptionChunkingStrategyVariant1))]
#endif
        public bool IsTranscriptionChunkingStrategyVariant1 => TranscriptionChunkingStrategyVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTranscriptionChunkingStrategyVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = TranscriptionChunkingStrategyVariant1;
            return IsTranscriptionChunkingStrategyVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickTranscriptionChunkingStrategyVariant1() => TranscriptionChunkingStrategyVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TranscriptionChunkingStrategyVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.VadConfig? VadConfig { get; init; }
#else
        public global::tryAGI.OpenAI.VadConfig? VadConfig { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VadConfig))]
#endif
        public bool IsVadConfig => VadConfig != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVadConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.VadConfig? value)
        {
            value = VadConfig;
            return IsVadConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.VadConfig PickVadConfig() => VadConfig is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VadConfig' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TranscriptionChunkingStrategy(string value) => new TranscriptionChunkingStrategy((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(TranscriptionChunkingStrategy @this) => @this.TranscriptionChunkingStrategyVariant1;

        /// <summary>
        ///
        /// </summary>
        public TranscriptionChunkingStrategy(string? value)
        {
            TranscriptionChunkingStrategyVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TranscriptionChunkingStrategy FromTranscriptionChunkingStrategyVariant1(string? value) => new TranscriptionChunkingStrategy(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TranscriptionChunkingStrategy(global::tryAGI.OpenAI.VadConfig value) => new TranscriptionChunkingStrategy((global::tryAGI.OpenAI.VadConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.VadConfig?(TranscriptionChunkingStrategy @this) => @this.VadConfig;

        /// <summary>
        ///
        /// </summary>
        public TranscriptionChunkingStrategy(global::tryAGI.OpenAI.VadConfig? value)
        {
            VadConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TranscriptionChunkingStrategy FromVadConfig(global::tryAGI.OpenAI.VadConfig? value) => new TranscriptionChunkingStrategy(value);

        /// <summary>
        ///
        /// </summary>
        public TranscriptionChunkingStrategy(
            string? transcriptionChunkingStrategyVariant1,
            global::tryAGI.OpenAI.VadConfig? vadConfig
            )
        {
            TranscriptionChunkingStrategyVariant1 = transcriptionChunkingStrategyVariant1;
            VadConfig = vadConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            VadConfig as object ??
            TranscriptionChunkingStrategyVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TranscriptionChunkingStrategyVariant1?.ToString() ??
            VadConfig?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTranscriptionChunkingStrategyVariant1 && !IsVadConfig || !IsTranscriptionChunkingStrategyVariant1 && IsVadConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? transcriptionChunkingStrategyVariant1 = null,
            global::System.Func<global::tryAGI.OpenAI.VadConfig, TResult>? vadConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TranscriptionChunkingStrategyVariant1 is { } __value0 && transcriptionChunkingStrategyVariant1 != null)
            {
                return transcriptionChunkingStrategyVariant1(__value0);
            }
            else if (VadConfig is { } __value1 && vadConfig != null)
            {
                return vadConfig(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? transcriptionChunkingStrategyVariant1 = null,

            global::System.Action<global::tryAGI.OpenAI.VadConfig>? vadConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TranscriptionChunkingStrategyVariant1 is { } __value0)
            {
                transcriptionChunkingStrategyVariant1?.Invoke(__value0);
            }
            else if (VadConfig is { } __value1)
            {
                vadConfig?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? transcriptionChunkingStrategyVariant1 = null,
            global::System.Action<global::tryAGI.OpenAI.VadConfig>? vadConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TranscriptionChunkingStrategyVariant1 is { } __value0)
            {
                transcriptionChunkingStrategyVariant1?.Invoke(__value0);
            }
            else if (VadConfig is { } __value1)
            {
                vadConfig?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TranscriptionChunkingStrategyVariant1,
                typeof(string),
                VadConfig,
                typeof(global::tryAGI.OpenAI.VadConfig),
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
        public bool Equals(TranscriptionChunkingStrategy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(TranscriptionChunkingStrategyVariant1, other.TranscriptionChunkingStrategyVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.VadConfig?>.Default.Equals(VadConfig, other.VadConfig)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TranscriptionChunkingStrategy obj1, TranscriptionChunkingStrategy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TranscriptionChunkingStrategy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TranscriptionChunkingStrategy obj1, TranscriptionChunkingStrategy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TranscriptionChunkingStrategy o && Equals(o);
        }
    }
}

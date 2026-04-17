#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI.Realtime
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
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmAudioFormat? PcmAudioFormat { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmAudioFormat? PcmAudioFormat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PcmAudioFormat))]
#endif
        public bool IsPcmAudioFormat => PcmAudioFormat != null;

        /// <summary>
        /// The G.711 μ-law format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmuAudioFormat? PcmuAudioFormat { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmuAudioFormat? PcmuAudioFormat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PcmuAudioFormat))]
#endif
        public bool IsPcmuAudioFormat => PcmuAudioFormat != null;

        /// <summary>
        /// The G.711 A-law format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmaAudioFormat? PcmaAudioFormat { get; init; }
#else
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmaAudioFormat? PcmaAudioFormat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PcmaAudioFormat))]
#endif
        public bool IsPcmaAudioFormat => PcmaAudioFormat != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeAudioFormats(global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmAudioFormat value) => new RealtimeAudioFormats((global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmAudioFormat?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmAudioFormat?(RealtimeAudioFormats @this) => @this.PcmAudioFormat;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeAudioFormats(global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmAudioFormat? value)
        {
            PcmAudioFormat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeAudioFormats(global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmuAudioFormat value) => new RealtimeAudioFormats((global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmuAudioFormat?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmuAudioFormat?(RealtimeAudioFormats @this) => @this.PcmuAudioFormat;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeAudioFormats(global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmuAudioFormat? value)
        {
            PcmuAudioFormat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeAudioFormats(global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmaAudioFormat value) => new RealtimeAudioFormats((global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmaAudioFormat?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmaAudioFormat?(RealtimeAudioFormats @this) => @this.PcmaAudioFormat;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeAudioFormats(global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmaAudioFormat? value)
        {
            PcmaAudioFormat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RealtimeAudioFormats(
            global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmAudioFormat? pcmAudioFormat,
            global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmuAudioFormat? pcmuAudioFormat,
            global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmaAudioFormat? pcmaAudioFormat
            )
        {
            PcmAudioFormat = pcmAudioFormat;
            PcmuAudioFormat = pcmuAudioFormat;
            PcmaAudioFormat = pcmaAudioFormat;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PcmaAudioFormat as object ??
            PcmuAudioFormat as object ??
            PcmAudioFormat as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PcmAudioFormat?.ToString() ??
            PcmuAudioFormat?.ToString() ??
            PcmaAudioFormat?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPcmAudioFormat || IsPcmuAudioFormat || IsPcmaAudioFormat;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmAudioFormat?, TResult>? pcmAudioFormat = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmuAudioFormat?, TResult>? pcmuAudioFormat = null,
            global::System.Func<global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmaAudioFormat?, TResult>? pcmaAudioFormat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPcmAudioFormat && pcmAudioFormat != null)
            {
                return pcmAudioFormat(PcmAudioFormat!);
            }
            else if (IsPcmuAudioFormat && pcmuAudioFormat != null)
            {
                return pcmuAudioFormat(PcmuAudioFormat!);
            }
            else if (IsPcmaAudioFormat && pcmaAudioFormat != null)
            {
                return pcmaAudioFormat(PcmaAudioFormat!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmAudioFormat?>? pcmAudioFormat = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmuAudioFormat?>? pcmuAudioFormat = null,
            global::System.Action<global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmaAudioFormat?>? pcmaAudioFormat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPcmAudioFormat)
            {
                pcmAudioFormat?.Invoke(PcmAudioFormat!);
            }
            else if (IsPcmuAudioFormat)
            {
                pcmuAudioFormat?.Invoke(PcmuAudioFormat!);
            }
            else if (IsPcmaAudioFormat)
            {
                pcmaAudioFormat?.Invoke(PcmaAudioFormat!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PcmAudioFormat,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmAudioFormat),
                PcmuAudioFormat,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmuAudioFormat),
                PcmaAudioFormat,
                typeof(global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmaAudioFormat),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmAudioFormat?>.Default.Equals(PcmAudioFormat, other.PcmAudioFormat) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmuAudioFormat?>.Default.Equals(PcmuAudioFormat, other.PcmuAudioFormat) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmaAudioFormat?>.Default.Equals(PcmaAudioFormat, other.PcmaAudioFormat) 
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

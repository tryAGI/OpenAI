#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VideoModel : global::System.IEquatable<VideoModel>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? VideoModelVariant1 { get; init; }
#else
        public string? VideoModelVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoModelVariant1))]
#endif
        public bool IsVideoModelVariant1 => VideoModelVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.VideoModelEnum? Enum { get; init; }
#else
        public global::tryAGI.OpenAI.VideoModelEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoModel(string value) => new VideoModel((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(VideoModel @this) => @this.VideoModelVariant1;

        /// <summary>
        /// 
        /// </summary>
        public VideoModel(string? value)
        {
            VideoModelVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoModel(global::tryAGI.OpenAI.VideoModelEnum value) => new VideoModel((global::tryAGI.OpenAI.VideoModelEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.VideoModelEnum?(VideoModel @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public VideoModel(global::tryAGI.OpenAI.VideoModelEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VideoModel(
            string? videoModelVariant1,
            global::tryAGI.OpenAI.VideoModelEnum? @enum
            )
        {
            VideoModelVariant1 = videoModelVariant1;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            VideoModelVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VideoModelVariant1?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVideoModelVariant1 || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? videoModelVariant1 = null,
            global::System.Func<global::tryAGI.OpenAI.VideoModelEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoModelVariant1 && videoModelVariant1 != null)
            {
                return videoModelVariant1(VideoModelVariant1!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? videoModelVariant1 = null,
            global::System.Action<global::tryAGI.OpenAI.VideoModelEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoModelVariant1)
            {
                videoModelVariant1?.Invoke(VideoModelVariant1!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VideoModelVariant1,
                typeof(string),
                Enum,
                typeof(global::tryAGI.OpenAI.VideoModelEnum),
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
        public bool Equals(VideoModel other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(VideoModelVariant1, other.VideoModelVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.VideoModelEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VideoModel obj1, VideoModel obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VideoModel>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VideoModel obj1, VideoModel obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VideoModel o && Equals(o);
        }
    }
}

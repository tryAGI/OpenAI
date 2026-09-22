#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A file materialized in an OpenAI-hosted execution environment.
    /// </summary>
    public readonly partial struct HostedEnvironmentFileParam : global::System.IEquatable<HostedEnvironmentFileParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType? Type { get; }

        /// <summary>
        /// A file previously uploaded through the OpenAI Files API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId? FileId { get; init; }
#else
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId? FileId { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileId))]
#endif
        public bool IsFileId => FileId != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFileId(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId? value)
        {
            value = FileId;
            return IsFileId;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId PickFileId() => IsFileId
            ? FileId!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileId' but the value was {ToString()}.");

        /// <summary>
        /// A file supplied directly as standard-base64 data.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamInline? Inline { get; init; }
#else
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamInline? Inline { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Inline))]
#endif
        public bool IsInline => Inline != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInline(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.HostedEnvironmentFileParamInline? value)
        {
            value = Inline;
            return IsInline;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileParamInline PickInline() => IsInline
            ? Inline!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Inline' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator HostedEnvironmentFileParam(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId value) => new HostedEnvironmentFileParam((global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId?(HostedEnvironmentFileParam @this) => @this.FileId;

        /// <summary>
        ///
        /// </summary>
        public HostedEnvironmentFileParam(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId? value)
        {
            FileId = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static HostedEnvironmentFileParam FromFileId(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId? value) => new HostedEnvironmentFileParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator HostedEnvironmentFileParam(global::tryAGI.OpenAI.HostedEnvironmentFileParamInline value) => new HostedEnvironmentFileParam((global::tryAGI.OpenAI.HostedEnvironmentFileParamInline?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.HostedEnvironmentFileParamInline?(HostedEnvironmentFileParam @this) => @this.Inline;

        /// <summary>
        ///
        /// </summary>
        public HostedEnvironmentFileParam(global::tryAGI.OpenAI.HostedEnvironmentFileParamInline? value)
        {
            Inline = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static HostedEnvironmentFileParam FromInline(global::tryAGI.OpenAI.HostedEnvironmentFileParamInline? value) => new HostedEnvironmentFileParam(value);

        /// <summary>
        ///
        /// </summary>
        public HostedEnvironmentFileParam(
            global::tryAGI.OpenAI.HostedEnvironmentFileParamDiscriminatorType? type,
            global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId? fileId,
            global::tryAGI.OpenAI.HostedEnvironmentFileParamInline? inline
            )
        {
            Type = type;

            FileId = fileId;
            Inline = inline;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Inline as object ??
            FileId as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            FileId?.ToString() ??
            Inline?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFileId && !IsInline || !IsFileId && IsInline;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId, TResult>? fileId = null,
            global::System.Func<global::tryAGI.OpenAI.HostedEnvironmentFileParamInline, TResult>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileId && fileId != null)
            {
                return fileId(FileId!);
            }
            else if (IsInline && inline != null)
            {
                return inline(Inline!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId>? fileId = null,

            global::System.Action<global::tryAGI.OpenAI.HostedEnvironmentFileParamInline>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileId)
            {
                fileId?.Invoke(FileId!);
            }
            else if (IsInline)
            {
                inline?.Invoke(Inline!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId>? fileId = null,
            global::System.Action<global::tryAGI.OpenAI.HostedEnvironmentFileParamInline>? inline = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileId)
            {
                fileId?.Invoke(FileId!);
            }
            else if (IsInline)
            {
                inline?.Invoke(Inline!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FileId,
                typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId),
                Inline,
                typeof(global::tryAGI.OpenAI.HostedEnvironmentFileParamInline),
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
        public bool Equals(HostedEnvironmentFileParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.HostedEnvironmentFileParamFileId?>.Default.Equals(FileId, other.FileId) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.HostedEnvironmentFileParamInline?>.Default.Equals(Inline, other.Inline)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(HostedEnvironmentFileParam obj1, HostedEnvironmentFileParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<HostedEnvironmentFileParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(HostedEnvironmentFileParam obj1, HostedEnvironmentFileParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is HostedEnvironmentFileParam o && Equals(o);
        }
    }
}

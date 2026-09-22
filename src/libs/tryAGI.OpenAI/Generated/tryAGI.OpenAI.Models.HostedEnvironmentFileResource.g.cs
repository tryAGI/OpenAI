#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Metadata for a file materialized in an OpenAI-hosted execution environment.
    /// </summary>
    public readonly partial struct HostedEnvironmentFileResource : global::System.IEquatable<HostedEnvironmentFileResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// A file copied from the OpenAI Files API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId? FileId { get; init; }
#else
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId? FileId { get; }
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
            out global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId? value)
        {
            value = FileId;
            return IsFileId;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId PickFileId() => IsFileId
            ? FileId!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileId' but the value was {ToString()}.");

        /// <summary>
        /// A file supplied inline when the session was created.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline? Inline { get; init; }
#else
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline? Inline { get; }
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
            out global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline? value)
        {
            value = Inline;
            return IsInline;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline PickInline() => IsInline
            ? Inline!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Inline' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator HostedEnvironmentFileResource(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId value) => new HostedEnvironmentFileResource((global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId?(HostedEnvironmentFileResource @this) => @this.FileId;

        /// <summary>
        ///
        /// </summary>
        public HostedEnvironmentFileResource(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId? value)
        {
            FileId = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static HostedEnvironmentFileResource FromFileId(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId? value) => new HostedEnvironmentFileResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator HostedEnvironmentFileResource(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline value) => new HostedEnvironmentFileResource((global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline?(HostedEnvironmentFileResource @this) => @this.Inline;

        /// <summary>
        ///
        /// </summary>
        public HostedEnvironmentFileResource(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline? value)
        {
            Inline = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static HostedEnvironmentFileResource FromInline(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline? value) => new HostedEnvironmentFileResource(value);

        /// <summary>
        ///
        /// </summary>
        public HostedEnvironmentFileResource(
            global::tryAGI.OpenAI.HostedEnvironmentFileResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId? fileId,
            global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline? inline
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
            global::System.Func<global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId, TResult>? fileId = null,
            global::System.Func<global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline, TResult>? inline = null,
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
            global::System.Action<global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId>? fileId = null,

            global::System.Action<global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline>? inline = null,
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
            global::System.Action<global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId>? fileId = null,
            global::System.Action<global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline>? inline = null,
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
                typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId),
                Inline,
                typeof(global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline),
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
        public bool Equals(HostedEnvironmentFileResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.HostedEnvironmentFileResourceFileId?>.Default.Equals(FileId, other.FileId) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.HostedEnvironmentFileResourceInline?>.Default.Equals(Inline, other.Inline)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(HostedEnvironmentFileResource obj1, HostedEnvironmentFileResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<HostedEnvironmentFileResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(HostedEnvironmentFileResource obj1, HostedEnvironmentFileResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is HostedEnvironmentFileResource o && Equals(o);
        }
    }
}

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Safe metadata for a file configured by an environment template.
    /// </summary>
    public readonly partial struct HostedTemplateFileResource : global::System.IEquatable<HostedTemplateFileResource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// A project-scoped Files API reference resolved separately for each session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.HostedTemplateFileResourceFileId? FileId { get; init; }
#else
        public global::tryAGI.OpenAI.HostedTemplateFileResourceFileId? FileId { get; }
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
            out global::tryAGI.OpenAI.HostedTemplateFileResourceFileId? value)
        {
            value = FileId;
            return IsFileId;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceFileId PickFileId() => IsFileId
            ? FileId!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileId' but the value was {ToString()}.");

        /// <summary>
        /// Metadata for confidential inline file contents.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.HostedTemplateFileResourceInline? Inline { get; init; }
#else
        public global::tryAGI.OpenAI.HostedTemplateFileResourceInline? Inline { get; }
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
            out global::tryAGI.OpenAI.HostedTemplateFileResourceInline? value)
        {
            value = Inline;
            return IsInline;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.HostedTemplateFileResourceInline PickInline() => IsInline
            ? Inline!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Inline' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator HostedTemplateFileResource(global::tryAGI.OpenAI.HostedTemplateFileResourceFileId value) => new HostedTemplateFileResource((global::tryAGI.OpenAI.HostedTemplateFileResourceFileId?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.HostedTemplateFileResourceFileId?(HostedTemplateFileResource @this) => @this.FileId;

        /// <summary>
        ///
        /// </summary>
        public HostedTemplateFileResource(global::tryAGI.OpenAI.HostedTemplateFileResourceFileId? value)
        {
            FileId = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static HostedTemplateFileResource FromFileId(global::tryAGI.OpenAI.HostedTemplateFileResourceFileId? value) => new HostedTemplateFileResource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator HostedTemplateFileResource(global::tryAGI.OpenAI.HostedTemplateFileResourceInline value) => new HostedTemplateFileResource((global::tryAGI.OpenAI.HostedTemplateFileResourceInline?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.HostedTemplateFileResourceInline?(HostedTemplateFileResource @this) => @this.Inline;

        /// <summary>
        ///
        /// </summary>
        public HostedTemplateFileResource(global::tryAGI.OpenAI.HostedTemplateFileResourceInline? value)
        {
            Inline = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static HostedTemplateFileResource FromInline(global::tryAGI.OpenAI.HostedTemplateFileResourceInline? value) => new HostedTemplateFileResource(value);

        /// <summary>
        ///
        /// </summary>
        public HostedTemplateFileResource(
            global::tryAGI.OpenAI.HostedTemplateFileResourceDiscriminatorType? type,
            global::tryAGI.OpenAI.HostedTemplateFileResourceFileId? fileId,
            global::tryAGI.OpenAI.HostedTemplateFileResourceInline? inline
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
            global::System.Func<global::tryAGI.OpenAI.HostedTemplateFileResourceFileId, TResult>? fileId = null,
            global::System.Func<global::tryAGI.OpenAI.HostedTemplateFileResourceInline, TResult>? inline = null,
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
            global::System.Action<global::tryAGI.OpenAI.HostedTemplateFileResourceFileId>? fileId = null,

            global::System.Action<global::tryAGI.OpenAI.HostedTemplateFileResourceInline>? inline = null,
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
            global::System.Action<global::tryAGI.OpenAI.HostedTemplateFileResourceFileId>? fileId = null,
            global::System.Action<global::tryAGI.OpenAI.HostedTemplateFileResourceInline>? inline = null,
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
                typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceFileId),
                Inline,
                typeof(global::tryAGI.OpenAI.HostedTemplateFileResourceInline),
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
        public bool Equals(HostedTemplateFileResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.HostedTemplateFileResourceFileId?>.Default.Equals(FileId, other.FileId) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.HostedTemplateFileResourceInline?>.Default.Equals(Inline, other.Inline)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(HostedTemplateFileResource obj1, HostedTemplateFileResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<HostedTemplateFileResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(HostedTemplateFileResource obj1, HostedTemplateFileResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is HostedTemplateFileResource o && Equals(o);
        }
    }
}

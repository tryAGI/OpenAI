#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// One of the create_file, delete_file, or update_file operations supplied to the apply_patch tool.
    /// </summary>
    public readonly partial struct BetaApplyPatchOperationParam : global::System.IEquatable<BetaApplyPatchOperationParam>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType? Type { get; }

        /// <summary>
        /// Instruction for creating a new file via the apply_patch tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam? CreateFile { get; init; }
#else
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam? CreateFile { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateFile))]
#endif
        public bool IsCreateFile => CreateFile != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam? value)
        {
            value = CreateFile;
            return IsCreateFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam PickCreateFile() => IsCreateFile
            ? CreateFile!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateFile' but the value was {ToString()}.");

        /// <summary>
        /// Instruction for deleting an existing file via the apply_patch tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam? DeleteFile { get; init; }
#else
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam? DeleteFile { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteFile))]
#endif
        public bool IsDeleteFile => DeleteFile != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDeleteFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam? value)
        {
            value = DeleteFile;
            return IsDeleteFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam PickDeleteFile() => IsDeleteFile
            ? DeleteFile!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeleteFile' but the value was {ToString()}.");

        /// <summary>
        /// Instruction for updating an existing file via the apply_patch tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam? UpdateFile { get; init; }
#else
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam? UpdateFile { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateFile))]
#endif
        public bool IsUpdateFile => UpdateFile != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUpdateFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam? value)
        {
            value = UpdateFile;
            return IsUpdateFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam PickUpdateFile() => IsUpdateFile
            ? UpdateFile!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateFile' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaApplyPatchOperationParam(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam value) => new BetaApplyPatchOperationParam((global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam?(BetaApplyPatchOperationParam @this) => @this.CreateFile;

        /// <summary>
        ///
        /// </summary>
        public BetaApplyPatchOperationParam(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam? value)
        {
            CreateFile = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaApplyPatchOperationParam FromCreateFile(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam? value) => new BetaApplyPatchOperationParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaApplyPatchOperationParam(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam value) => new BetaApplyPatchOperationParam((global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam?(BetaApplyPatchOperationParam @this) => @this.DeleteFile;

        /// <summary>
        ///
        /// </summary>
        public BetaApplyPatchOperationParam(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam? value)
        {
            DeleteFile = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaApplyPatchOperationParam FromDeleteFile(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam? value) => new BetaApplyPatchOperationParam(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaApplyPatchOperationParam(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam value) => new BetaApplyPatchOperationParam((global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam?(BetaApplyPatchOperationParam @this) => @this.UpdateFile;

        /// <summary>
        ///
        /// </summary>
        public BetaApplyPatchOperationParam(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam? value)
        {
            UpdateFile = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaApplyPatchOperationParam FromUpdateFile(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam? value) => new BetaApplyPatchOperationParam(value);

        /// <summary>
        ///
        /// </summary>
        public BetaApplyPatchOperationParam(
            global::tryAGI.OpenAI.BetaApplyPatchOperationParamDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam? createFile,
            global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam? deleteFile,
            global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam? updateFile
            )
        {
            Type = type;

            CreateFile = createFile;
            DeleteFile = deleteFile;
            UpdateFile = updateFile;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UpdateFile as object ??
            DeleteFile as object ??
            CreateFile as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CreateFile?.ToString() ??
            DeleteFile?.ToString() ??
            UpdateFile?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCreateFile && !IsDeleteFile && !IsUpdateFile || !IsCreateFile && IsDeleteFile && !IsUpdateFile || !IsCreateFile && !IsDeleteFile && IsUpdateFile;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam, TResult>? createFile = null,
            global::System.Func<global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam, TResult>? deleteFile = null,
            global::System.Func<global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam, TResult>? updateFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateFile && createFile != null)
            {
                return createFile(CreateFile!);
            }
            else if (IsDeleteFile && deleteFile != null)
            {
                return deleteFile(DeleteFile!);
            }
            else if (IsUpdateFile && updateFile != null)
            {
                return updateFile(UpdateFile!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam>? createFile = null,

            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam>? deleteFile = null,

            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam>? updateFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateFile)
            {
                createFile?.Invoke(CreateFile!);
            }
            else if (IsDeleteFile)
            {
                deleteFile?.Invoke(DeleteFile!);
            }
            else if (IsUpdateFile)
            {
                updateFile?.Invoke(UpdateFile!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam>? createFile = null,
            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam>? deleteFile = null,
            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam>? updateFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateFile)
            {
                createFile?.Invoke(CreateFile!);
            }
            else if (IsDeleteFile)
            {
                deleteFile?.Invoke(DeleteFile!);
            }
            else if (IsUpdateFile)
            {
                updateFile?.Invoke(UpdateFile!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateFile,
                typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam),
                DeleteFile,
                typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam),
                UpdateFile,
                typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam),
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
        public bool Equals(BetaApplyPatchOperationParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperationParam?>.Default.Equals(CreateFile, other.CreateFile) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperationParam?>.Default.Equals(DeleteFile, other.DeleteFile) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperationParam?>.Default.Equals(UpdateFile, other.UpdateFile)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaApplyPatchOperationParam obj1, BetaApplyPatchOperationParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaApplyPatchOperationParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaApplyPatchOperationParam obj1, BetaApplyPatchOperationParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaApplyPatchOperationParam o && Equals(o);
        }
    }
}

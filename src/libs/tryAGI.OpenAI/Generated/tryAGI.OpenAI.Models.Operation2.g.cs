#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// One of the create_file, delete_file, or update_file operations applied via apply_patch.
    /// </summary>
    public readonly partial struct Operation2 : global::System.IEquatable<Operation2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType? Type { get; }

        /// <summary>
        /// Instruction describing how to create a file via the apply_patch tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation? CreateFile { get; init; }
#else
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation? CreateFile { get; }
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
            out global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation? value)
        {
            value = CreateFile;
            return IsCreateFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation PickCreateFile() => IsCreateFile
            ? CreateFile!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateFile' but the value was {ToString()}.");

        /// <summary>
        /// Instruction describing how to delete a file via the apply_patch tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation? DeleteFile { get; init; }
#else
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation? DeleteFile { get; }
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
            out global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation? value)
        {
            value = DeleteFile;
            return IsDeleteFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation PickDeleteFile() => IsDeleteFile
            ? DeleteFile!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeleteFile' but the value was {ToString()}.");

        /// <summary>
        /// Instruction describing how to update a file via the apply_patch tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation? UpdateFile { get; init; }
#else
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation? UpdateFile { get; }
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
            out global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation? value)
        {
            value = UpdateFile;
            return IsUpdateFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation PickUpdateFile() => IsUpdateFile
            ? UpdateFile!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateFile' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Operation2(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation value) => new Operation2((global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation?(Operation2 @this) => @this.CreateFile;

        /// <summary>
        ///
        /// </summary>
        public Operation2(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation? value)
        {
            CreateFile = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Operation2 FromCreateFile(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation? value) => new Operation2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Operation2(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation value) => new Operation2((global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation?(Operation2 @this) => @this.DeleteFile;

        /// <summary>
        ///
        /// </summary>
        public Operation2(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation? value)
        {
            DeleteFile = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Operation2 FromDeleteFile(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation? value) => new Operation2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Operation2(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation value) => new Operation2((global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation?(Operation2 @this) => @this.UpdateFile;

        /// <summary>
        ///
        /// </summary>
        public Operation2(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation? value)
        {
            UpdateFile = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Operation2 FromUpdateFile(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation? value) => new Operation2(value);

        /// <summary>
        ///
        /// </summary>
        public Operation2(
            global::tryAGI.OpenAI.BetaApplyPatchToolCallOperationDiscriminatorType? type,
            global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation? createFile,
            global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation? deleteFile,
            global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation? updateFile
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
            global::System.Func<global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation, TResult>? createFile = null,
            global::System.Func<global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation, TResult>? deleteFile = null,
            global::System.Func<global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation, TResult>? updateFile = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation>? createFile = null,

            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation>? deleteFile = null,

            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation>? updateFile = null,
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
            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation>? createFile = null,
            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation>? deleteFile = null,
            global::System.Action<global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation>? updateFile = null,
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
                typeof(global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation),
                DeleteFile,
                typeof(global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation),
                UpdateFile,
                typeof(global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation),
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
        public bool Equals(Operation2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaApplyPatchCreateFileOperation?>.Default.Equals(CreateFile, other.CreateFile) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaApplyPatchDeleteFileOperation?>.Default.Equals(DeleteFile, other.DeleteFile) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.BetaApplyPatchUpdateFileOperation?>.Default.Equals(UpdateFile, other.UpdateFile)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Operation2 obj1, Operation2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Operation2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Operation2 obj1, Operation2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Operation2 o && Equals(o);
        }
    }
}

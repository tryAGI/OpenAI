#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// One of the create_file, delete_file, or update_file operations applied via apply_patch.
    /// </summary>
    public readonly partial struct Operation : global::System.IEquatable<Operation>
    {
        /// <summary>
        /// Instruction describing how to create a file via the apply_patch tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperation? CreateFile { get; init; }
#else
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperation? CreateFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateFile))]
#endif
        public bool IsCreateFile => CreateFile != null;

        /// <summary>
        /// Instruction describing how to delete a file via the apply_patch tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation? DeleteFile { get; init; }
#else
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation? DeleteFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteFile))]
#endif
        public bool IsDeleteFile => DeleteFile != null;

        /// <summary>
        /// Instruction describing how to update a file via the apply_patch tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation? UpdateFile { get; init; }
#else
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation? UpdateFile { get; }
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
        public static implicit operator Operation(global::tryAGI.OpenAI.ApplyPatchCreateFileOperation value) => new Operation((global::tryAGI.OpenAI.ApplyPatchCreateFileOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ApplyPatchCreateFileOperation?(Operation @this) => @this.CreateFile;

        /// <summary>
        /// 
        /// </summary>
        public Operation(global::tryAGI.OpenAI.ApplyPatchCreateFileOperation? value)
        {
            CreateFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Operation(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation value) => new Operation((global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation?(Operation @this) => @this.DeleteFile;

        /// <summary>
        /// 
        /// </summary>
        public Operation(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation? value)
        {
            DeleteFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Operation(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation value) => new Operation((global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation?(Operation @this) => @this.UpdateFile;

        /// <summary>
        /// 
        /// </summary>
        public Operation(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation? value)
        {
            UpdateFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Operation(
            global::tryAGI.OpenAI.ApplyPatchCreateFileOperation? createFile,
            global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation? deleteFile,
            global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation? updateFile
            )
        {
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
            global::System.Func<global::tryAGI.OpenAI.ApplyPatchCreateFileOperation?, TResult>? createFile = null,
            global::System.Func<global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation?, TResult>? deleteFile = null,
            global::System.Func<global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation?, TResult>? updateFile = null,
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
            global::System.Action<global::tryAGI.OpenAI.ApplyPatchCreateFileOperation?>? createFile = null,
            global::System.Action<global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation?>? deleteFile = null,
            global::System.Action<global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation?>? updateFile = null,
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
                typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperation),
                DeleteFile,
                typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation),
                UpdateFile,
                typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation),
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
        public bool Equals(Operation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ApplyPatchCreateFileOperation?>.Default.Equals(CreateFile, other.CreateFile) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ApplyPatchDeleteFileOperation?>.Default.Equals(DeleteFile, other.DeleteFile) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ApplyPatchUpdateFileOperation?>.Default.Equals(UpdateFile, other.UpdateFile) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Operation obj1, Operation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Operation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Operation obj1, Operation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Operation o && Equals(o);
        }
    }
}

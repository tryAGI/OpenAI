#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// One of the create_file, delete_file, or update_file operations supplied to the apply_patch tool.
    /// </summary>
    public readonly partial struct ApplyPatchOperationParam : global::System.IEquatable<ApplyPatchOperationParam>
    {
        /// <summary>
        /// Instruction for creating a new file via the apply_patch tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam? CreateFile { get; init; }
#else
        public global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam? CreateFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateFile))]
#endif
        public bool IsCreateFile => CreateFile != null;

        /// <summary>
        /// Instruction for deleting an existing file via the apply_patch tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam? DeleteFile { get; init; }
#else
        public global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam? DeleteFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeleteFile))]
#endif
        public bool IsDeleteFile => DeleteFile != null;

        /// <summary>
        /// Instruction for updating an existing file via the apply_patch tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam? UpdateFile { get; init; }
#else
        public global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam? UpdateFile { get; }
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
        public static implicit operator ApplyPatchOperationParam(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam value) => new ApplyPatchOperationParam((global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam?(ApplyPatchOperationParam @this) => @this.CreateFile;

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchOperationParam(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam? value)
        {
            CreateFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplyPatchOperationParam(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam value) => new ApplyPatchOperationParam((global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam?(ApplyPatchOperationParam @this) => @this.DeleteFile;

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchOperationParam(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam? value)
        {
            DeleteFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApplyPatchOperationParam(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam value) => new ApplyPatchOperationParam((global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam?(ApplyPatchOperationParam @this) => @this.UpdateFile;

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchOperationParam(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam? value)
        {
            UpdateFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ApplyPatchOperationParam(
            global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam? createFile,
            global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam? deleteFile,
            global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam? updateFile
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
            global::System.Func<global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam?, TResult>? createFile = null,
            global::System.Func<global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam?, TResult>? deleteFile = null,
            global::System.Func<global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam?, TResult>? updateFile = null,
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
            global::System.Action<global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam?>? createFile = null,
            global::System.Action<global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam?>? deleteFile = null,
            global::System.Action<global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam?>? updateFile = null,
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
                typeof(global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam),
                DeleteFile,
                typeof(global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam),
                UpdateFile,
                typeof(global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam),
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
        public bool Equals(ApplyPatchOperationParam other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ApplyPatchCreateFileOperationParam?>.Default.Equals(CreateFile, other.CreateFile) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ApplyPatchDeleteFileOperationParam?>.Default.Equals(DeleteFile, other.DeleteFile) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ApplyPatchUpdateFileOperationParam?>.Default.Equals(UpdateFile, other.UpdateFile) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ApplyPatchOperationParam obj1, ApplyPatchOperationParam obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ApplyPatchOperationParam>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ApplyPatchOperationParam obj1, ApplyPatchOperationParam obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ApplyPatchOperationParam o && Equals(o);
        }
    }
}

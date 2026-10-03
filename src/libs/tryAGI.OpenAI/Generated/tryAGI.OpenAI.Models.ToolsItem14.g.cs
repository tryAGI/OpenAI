#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ToolsItem14 : global::System.IEquatable<ToolsItem14>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminatorType? Type { get; }

        /// <summary>
        /// A function tool available to the Responses backend when the Live model delegates a task.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveFunctionToolInputParam? Function { get; init; }
#else
        public global::tryAGI.OpenAI.LiveFunctionToolInputParam? Function { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveFunctionToolInputParam? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFunctionToolInputParam PickFunction() => Function is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// A web search tool available to the Live session’s Responses backend.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParam? WebSearch { get; init; }
#else
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParam? WebSearch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearch))]
#endif
        public bool IsWebSearch => WebSearch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveWebSearchToolInputParam? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveWebSearchToolInputParam PickWebSearch() => WebSearch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveFileSearchToolInputParam? FileSearch { get; init; }
#else
        public global::tryAGI.OpenAI.LiveFileSearchToolInputParam? FileSearch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearch))]
#endif
        public bool IsFileSearch => FileSearch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFileSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveFileSearchToolInputParam? value)
        {
            value = FileSearch;
            return IsFileSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveFileSearchToolInputParam PickFileSearch() => FileSearch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileSearch' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam? CodeInterpreter { get; init; }
#else
        public global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam? CodeInterpreter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreter))]
#endif
        public bool IsCodeInterpreter => CodeInterpreter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeInterpreter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam? value)
        {
            value = CodeInterpreter;
            return IsCodeInterpreter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam PickCodeInterpreter() => CodeInterpreter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeInterpreter' but the value was {ToString()}.");

        /// <summary>
        /// A Responses shell tool with a container_auto or container_reference environment. Local execution and domain secrets are not supported.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParam? Shell { get; init; }
#else
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParam? Shell { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shell))]
#endif
        public bool IsShell => Shell != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShell(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveHostedShellToolInputParam? value)
        {
            value = Shell;
            return IsShell;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveHostedShellToolInputParam PickShell() => Shell is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shell' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveImageGenerationToolInputParam? ImageGeneration { get; init; }
#else
        public global::tryAGI.OpenAI.LiveImageGenerationToolInputParam? ImageGeneration { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGeneration))]
#endif
        public bool IsImageGeneration => ImageGeneration != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImageGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveImageGenerationToolInputParam? value)
        {
            value = ImageGeneration;
            return IsImageGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveImageGenerationToolInputParam PickImageGeneration() => ImageGeneration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGeneration' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem14(global::tryAGI.OpenAI.LiveFunctionToolInputParam value) => new ToolsItem14((global::tryAGI.OpenAI.LiveFunctionToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveFunctionToolInputParam?(ToolsItem14 @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem14(global::tryAGI.OpenAI.LiveFunctionToolInputParam? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem14 FromFunction(global::tryAGI.OpenAI.LiveFunctionToolInputParam? value) => new ToolsItem14(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem14(global::tryAGI.OpenAI.LiveWebSearchToolInputParam value) => new ToolsItem14((global::tryAGI.OpenAI.LiveWebSearchToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveWebSearchToolInputParam?(ToolsItem14 @this) => @this.WebSearch;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem14(global::tryAGI.OpenAI.LiveWebSearchToolInputParam? value)
        {
            WebSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem14 FromWebSearch(global::tryAGI.OpenAI.LiveWebSearchToolInputParam? value) => new ToolsItem14(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem14(global::tryAGI.OpenAI.LiveFileSearchToolInputParam value) => new ToolsItem14((global::tryAGI.OpenAI.LiveFileSearchToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveFileSearchToolInputParam?(ToolsItem14 @this) => @this.FileSearch;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem14(global::tryAGI.OpenAI.LiveFileSearchToolInputParam? value)
        {
            FileSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem14 FromFileSearch(global::tryAGI.OpenAI.LiveFileSearchToolInputParam? value) => new ToolsItem14(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem14(global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam value) => new ToolsItem14((global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam?(ToolsItem14 @this) => @this.CodeInterpreter;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem14(global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam? value)
        {
            CodeInterpreter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem14 FromCodeInterpreter(global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam? value) => new ToolsItem14(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem14(global::tryAGI.OpenAI.LiveHostedShellToolInputParam value) => new ToolsItem14((global::tryAGI.OpenAI.LiveHostedShellToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveHostedShellToolInputParam?(ToolsItem14 @this) => @this.Shell;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem14(global::tryAGI.OpenAI.LiveHostedShellToolInputParam? value)
        {
            Shell = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem14 FromShell(global::tryAGI.OpenAI.LiveHostedShellToolInputParam? value) => new ToolsItem14(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolsItem14(global::tryAGI.OpenAI.LiveImageGenerationToolInputParam value) => new ToolsItem14((global::tryAGI.OpenAI.LiveImageGenerationToolInputParam?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveImageGenerationToolInputParam?(ToolsItem14 @this) => @this.ImageGeneration;

        /// <summary>
        ///
        /// </summary>
        public ToolsItem14(global::tryAGI.OpenAI.LiveImageGenerationToolInputParam? value)
        {
            ImageGeneration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolsItem14 FromImageGeneration(global::tryAGI.OpenAI.LiveImageGenerationToolInputParam? value) => new ToolsItem14(value);

        /// <summary>
        ///
        /// </summary>
        public ToolsItem14(
            global::tryAGI.OpenAI.LiveResponsesDelegationSettingsInputParamToolDiscriminatorType? type,
            global::tryAGI.OpenAI.LiveFunctionToolInputParam? function,
            global::tryAGI.OpenAI.LiveWebSearchToolInputParam? webSearch,
            global::tryAGI.OpenAI.LiveFileSearchToolInputParam? fileSearch,
            global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam? codeInterpreter,
            global::tryAGI.OpenAI.LiveHostedShellToolInputParam? shell,
            global::tryAGI.OpenAI.LiveImageGenerationToolInputParam? imageGeneration
            )
        {
            Type = type;

            Function = function;
            WebSearch = webSearch;
            FileSearch = fileSearch;
            CodeInterpreter = codeInterpreter;
            Shell = shell;
            ImageGeneration = imageGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ImageGeneration as object ??
            Shell as object ??
            CodeInterpreter as object ??
            FileSearch as object ??
            WebSearch as object ??
            Function as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            WebSearch?.ToString() ??
            FileSearch?.ToString() ??
            CodeInterpreter?.ToString() ??
            Shell?.ToString() ??
            ImageGeneration?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsWebSearch && !IsFileSearch && !IsCodeInterpreter && !IsShell && !IsImageGeneration || !IsFunction && IsWebSearch && !IsFileSearch && !IsCodeInterpreter && !IsShell && !IsImageGeneration || !IsFunction && !IsWebSearch && IsFileSearch && !IsCodeInterpreter && !IsShell && !IsImageGeneration || !IsFunction && !IsWebSearch && !IsFileSearch && IsCodeInterpreter && !IsShell && !IsImageGeneration || !IsFunction && !IsWebSearch && !IsFileSearch && !IsCodeInterpreter && IsShell && !IsImageGeneration || !IsFunction && !IsWebSearch && !IsFileSearch && !IsCodeInterpreter && !IsShell && IsImageGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.LiveFunctionToolInputParam, TResult>? function = null,
            global::System.Func<global::tryAGI.OpenAI.LiveWebSearchToolInputParam, TResult>? webSearch = null,
            global::System.Func<global::tryAGI.OpenAI.LiveFileSearchToolInputParam, TResult>? fileSearch = null,
            global::System.Func<global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam, TResult>? codeInterpreter = null,
            global::System.Func<global::tryAGI.OpenAI.LiveHostedShellToolInputParam, TResult>? shell = null,
            global::System.Func<global::tryAGI.OpenAI.LiveImageGenerationToolInputParam, TResult>? imageGeneration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Function is { } __value0 && function != null)
            {
                return function(__value0);
            }
            else if (WebSearch is { } __value1 && webSearch != null)
            {
                return webSearch(__value1);
            }
            else if (FileSearch is { } __value2 && fileSearch != null)
            {
                return fileSearch(__value2);
            }
            else if (CodeInterpreter is { } __value3 && codeInterpreter != null)
            {
                return codeInterpreter(__value3);
            }
            else if (Shell is { } __value4 && shell != null)
            {
                return shell(__value4);
            }
            else if (ImageGeneration is { } __value5 && imageGeneration != null)
            {
                return imageGeneration(__value5);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.LiveFunctionToolInputParam>? function = null,

            global::System.Action<global::tryAGI.OpenAI.LiveWebSearchToolInputParam>? webSearch = null,

            global::System.Action<global::tryAGI.OpenAI.LiveFileSearchToolInputParam>? fileSearch = null,

            global::System.Action<global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam>? codeInterpreter = null,

            global::System.Action<global::tryAGI.OpenAI.LiveHostedShellToolInputParam>? shell = null,

            global::System.Action<global::tryAGI.OpenAI.LiveImageGenerationToolInputParam>? imageGeneration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Function is { } __value0)
            {
                function?.Invoke(__value0);
            }
            else if (WebSearch is { } __value1)
            {
                webSearch?.Invoke(__value1);
            }
            else if (FileSearch is { } __value2)
            {
                fileSearch?.Invoke(__value2);
            }
            else if (CodeInterpreter is { } __value3)
            {
                codeInterpreter?.Invoke(__value3);
            }
            else if (Shell is { } __value4)
            {
                shell?.Invoke(__value4);
            }
            else if (ImageGeneration is { } __value5)
            {
                imageGeneration?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.LiveFunctionToolInputParam>? function = null,
            global::System.Action<global::tryAGI.OpenAI.LiveWebSearchToolInputParam>? webSearch = null,
            global::System.Action<global::tryAGI.OpenAI.LiveFileSearchToolInputParam>? fileSearch = null,
            global::System.Action<global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam>? codeInterpreter = null,
            global::System.Action<global::tryAGI.OpenAI.LiveHostedShellToolInputParam>? shell = null,
            global::System.Action<global::tryAGI.OpenAI.LiveImageGenerationToolInputParam>? imageGeneration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Function is { } __value0)
            {
                function?.Invoke(__value0);
            }
            else if (WebSearch is { } __value1)
            {
                webSearch?.Invoke(__value1);
            }
            else if (FileSearch is { } __value2)
            {
                fileSearch?.Invoke(__value2);
            }
            else if (CodeInterpreter is { } __value3)
            {
                codeInterpreter?.Invoke(__value3);
            }
            else if (Shell is { } __value4)
            {
                shell?.Invoke(__value4);
            }
            else if (ImageGeneration is { } __value5)
            {
                imageGeneration?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Function,
                typeof(global::tryAGI.OpenAI.LiveFunctionToolInputParam),
                WebSearch,
                typeof(global::tryAGI.OpenAI.LiveWebSearchToolInputParam),
                FileSearch,
                typeof(global::tryAGI.OpenAI.LiveFileSearchToolInputParam),
                CodeInterpreter,
                typeof(global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam),
                Shell,
                typeof(global::tryAGI.OpenAI.LiveHostedShellToolInputParam),
                ImageGeneration,
                typeof(global::tryAGI.OpenAI.LiveImageGenerationToolInputParam),
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
        public bool Equals(ToolsItem14 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveFunctionToolInputParam?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveWebSearchToolInputParam?>.Default.Equals(WebSearch, other.WebSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveFileSearchToolInputParam?>.Default.Equals(FileSearch, other.FileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveCodeInterpreterToolInputParam?>.Default.Equals(CodeInterpreter, other.CodeInterpreter) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveHostedShellToolInputParam?>.Default.Equals(Shell, other.Shell) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveImageGenerationToolInputParam?>.Default.Equals(ImageGeneration, other.ImageGeneration)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ToolsItem14 obj1, ToolsItem14 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem14>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ToolsItem14 obj1, ToolsItem14 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem14 o && Equals(o);
        }
    }
}

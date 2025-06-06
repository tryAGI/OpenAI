#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CodeInterpreterToolOutput : global::System.IEquatable<CodeInterpreterToolOutput>
    {
        /// <summary>
        /// The output of a code interpreter tool call that is text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CodeInterpreterTextOutput? Text { get; init; }
#else
        public global::tryAGI.OpenAI.CodeInterpreterTextOutput? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeInterpreterToolOutput(global::tryAGI.OpenAI.CodeInterpreterTextOutput value) => new CodeInterpreterToolOutput((global::tryAGI.OpenAI.CodeInterpreterTextOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CodeInterpreterTextOutput?(CodeInterpreterToolOutput @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterToolOutput(global::tryAGI.OpenAI.CodeInterpreterTextOutput? value)
        {
            Text = value;
        }

        /// <summary>
        /// The output of a code interpreter tool call that is a file.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.CodeInterpreterFileOutput? File { get; init; }
#else
        public global::tryAGI.OpenAI.CodeInterpreterFileOutput? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeInterpreterToolOutput(global::tryAGI.OpenAI.CodeInterpreterFileOutput value) => new CodeInterpreterToolOutput((global::tryAGI.OpenAI.CodeInterpreterFileOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.CodeInterpreterFileOutput?(CodeInterpreterToolOutput @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterToolOutput(global::tryAGI.OpenAI.CodeInterpreterFileOutput? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CodeInterpreterToolOutput(
            global::tryAGI.OpenAI.CodeInterpreterTextOutput? text,
            global::tryAGI.OpenAI.CodeInterpreterFileOutput? file
            )
        {
            Text = text;
            File = file;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            File as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            File?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsFile || !IsText && IsFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.CodeInterpreterTextOutput?, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.CodeInterpreterFileOutput?, TResult>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsFile && file != null)
            {
                return file(File!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.CodeInterpreterTextOutput?>? text = null,
            global::System.Action<global::tryAGI.OpenAI.CodeInterpreterFileOutput?>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsFile)
            {
                file?.Invoke(File!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::tryAGI.OpenAI.CodeInterpreterTextOutput),
                File,
                typeof(global::tryAGI.OpenAI.CodeInterpreterFileOutput),
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
        public bool Equals(CodeInterpreterToolOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CodeInterpreterTextOutput?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.CodeInterpreterFileOutput?>.Default.Equals(File, other.File) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CodeInterpreterToolOutput obj1, CodeInterpreterToolOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CodeInterpreterToolOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CodeInterpreterToolOutput obj1, CodeInterpreterToolOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CodeInterpreterToolOutput o && Equals(o);
        }
    }
}

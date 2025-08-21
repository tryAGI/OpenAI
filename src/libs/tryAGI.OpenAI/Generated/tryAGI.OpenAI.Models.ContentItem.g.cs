#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentItem : global::System.IEquatable<ContentItem>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputTextContent2? InputTextContent2 { get; init; }
#else
        public global::tryAGI.OpenAI.InputTextContent2? InputTextContent2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputTextContent2))]
#endif
        public bool IsInputTextContent2 => InputTextContent2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::tryAGI.OpenAI.InputTextContent2 value) => new ContentItem((global::tryAGI.OpenAI.InputTextContent2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputTextContent2?(ContentItem @this) => @this.InputTextContent2;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::tryAGI.OpenAI.InputTextContent2? value)
        {
            InputTextContent2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.OutputTextContent2? OutputTextContent2 { get; init; }
#else
        public global::tryAGI.OpenAI.OutputTextContent2? OutputTextContent2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputTextContent2))]
#endif
        public bool IsOutputTextContent2 => OutputTextContent2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::tryAGI.OpenAI.OutputTextContent2 value) => new ContentItem((global::tryAGI.OpenAI.OutputTextContent2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.OutputTextContent2?(ContentItem @this) => @this.OutputTextContent2;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::tryAGI.OpenAI.OutputTextContent2? value)
        {
            OutputTextContent2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.TextContent? Text { get; init; }
#else
        public global::tryAGI.OpenAI.TextContent? Text { get; }
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
        public static implicit operator ContentItem(global::tryAGI.OpenAI.TextContent value) => new ContentItem((global::tryAGI.OpenAI.TextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.TextContent?(ContentItem @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::tryAGI.OpenAI.TextContent? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.SummaryTextContent? SummaryText { get; init; }
#else
        public global::tryAGI.OpenAI.SummaryTextContent? SummaryText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SummaryText))]
#endif
        public bool IsSummaryText => SummaryText != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::tryAGI.OpenAI.SummaryTextContent value) => new ContentItem((global::tryAGI.OpenAI.SummaryTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SummaryTextContent?(ContentItem @this) => @this.SummaryText;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::tryAGI.OpenAI.SummaryTextContent? value)
        {
            SummaryText = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RefusalContent2? RefusalContent2 { get; init; }
#else
        public global::tryAGI.OpenAI.RefusalContent2? RefusalContent2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefusalContent2))]
#endif
        public bool IsRefusalContent2 => RefusalContent2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::tryAGI.OpenAI.RefusalContent2 value) => new ContentItem((global::tryAGI.OpenAI.RefusalContent2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RefusalContent2?(ContentItem @this) => @this.RefusalContent2;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::tryAGI.OpenAI.RefusalContent2? value)
        {
            RefusalContent2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputImageContent2? InputImageContent2 { get; init; }
#else
        public global::tryAGI.OpenAI.InputImageContent2? InputImageContent2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputImageContent2))]
#endif
        public bool IsInputImageContent2 => InputImageContent2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::tryAGI.OpenAI.InputImageContent2 value) => new ContentItem((global::tryAGI.OpenAI.InputImageContent2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputImageContent2?(ContentItem @this) => @this.InputImageContent2;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::tryAGI.OpenAI.InputImageContent2? value)
        {
            InputImageContent2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ComputerScreenshotContent? ComputerScreenshot { get; init; }
#else
        public global::tryAGI.OpenAI.ComputerScreenshotContent? ComputerScreenshot { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerScreenshot))]
#endif
        public bool IsComputerScreenshot => ComputerScreenshot != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::tryAGI.OpenAI.ComputerScreenshotContent value) => new ContentItem((global::tryAGI.OpenAI.ComputerScreenshotContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerScreenshotContent?(ContentItem @this) => @this.ComputerScreenshot;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::tryAGI.OpenAI.ComputerScreenshotContent? value)
        {
            ComputerScreenshot = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputFileContent2? InputFileContent2 { get; init; }
#else
        public global::tryAGI.OpenAI.InputFileContent2? InputFileContent2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFileContent2))]
#endif
        public bool IsInputFileContent2 => InputFileContent2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::tryAGI.OpenAI.InputFileContent2 value) => new ContentItem((global::tryAGI.OpenAI.InputFileContent2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputFileContent2?(ContentItem @this) => @this.InputFileContent2;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::tryAGI.OpenAI.InputFileContent2? value)
        {
            InputFileContent2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(
            global::tryAGI.OpenAI.InputTextContent2? inputTextContent2,
            global::tryAGI.OpenAI.OutputTextContent2? outputTextContent2,
            global::tryAGI.OpenAI.TextContent? text,
            global::tryAGI.OpenAI.SummaryTextContent? summaryText,
            global::tryAGI.OpenAI.RefusalContent2? refusalContent2,
            global::tryAGI.OpenAI.InputImageContent2? inputImageContent2,
            global::tryAGI.OpenAI.ComputerScreenshotContent? computerScreenshot,
            global::tryAGI.OpenAI.InputFileContent2? inputFileContent2
            )
        {
            InputTextContent2 = inputTextContent2;
            OutputTextContent2 = outputTextContent2;
            Text = text;
            SummaryText = summaryText;
            RefusalContent2 = refusalContent2;
            InputImageContent2 = inputImageContent2;
            ComputerScreenshot = computerScreenshot;
            InputFileContent2 = inputFileContent2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputFileContent2 as object ??
            ComputerScreenshot as object ??
            InputImageContent2 as object ??
            RefusalContent2 as object ??
            SummaryText as object ??
            Text as object ??
            OutputTextContent2 as object ??
            InputTextContent2 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputTextContent2?.ToString() ??
            OutputTextContent2?.ToString() ??
            Text?.ToString() ??
            SummaryText?.ToString() ??
            RefusalContent2?.ToString() ??
            InputImageContent2?.ToString() ??
            ComputerScreenshot?.ToString() ??
            InputFileContent2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputTextContent2 || IsOutputTextContent2 || IsText || IsSummaryText || IsRefusalContent2 || IsInputImageContent2 || IsComputerScreenshot || IsInputFileContent2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.InputTextContent2?, TResult>? inputTextContent2 = null,
            global::System.Func<global::tryAGI.OpenAI.OutputTextContent2?, TResult>? outputTextContent2 = null,
            global::System.Func<global::tryAGI.OpenAI.TextContent?, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.SummaryTextContent?, TResult>? summaryText = null,
            global::System.Func<global::tryAGI.OpenAI.RefusalContent2?, TResult>? refusalContent2 = null,
            global::System.Func<global::tryAGI.OpenAI.InputImageContent2?, TResult>? inputImageContent2 = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerScreenshotContent?, TResult>? computerScreenshot = null,
            global::System.Func<global::tryAGI.OpenAI.InputFileContent2?, TResult>? inputFileContent2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputTextContent2 && inputTextContent2 != null)
            {
                return inputTextContent2(InputTextContent2!);
            }
            else if (IsOutputTextContent2 && outputTextContent2 != null)
            {
                return outputTextContent2(OutputTextContent2!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsSummaryText && summaryText != null)
            {
                return summaryText(SummaryText!);
            }
            else if (IsRefusalContent2 && refusalContent2 != null)
            {
                return refusalContent2(RefusalContent2!);
            }
            else if (IsInputImageContent2 && inputImageContent2 != null)
            {
                return inputImageContent2(InputImageContent2!);
            }
            else if (IsComputerScreenshot && computerScreenshot != null)
            {
                return computerScreenshot(ComputerScreenshot!);
            }
            else if (IsInputFileContent2 && inputFileContent2 != null)
            {
                return inputFileContent2(InputFileContent2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.InputTextContent2?>? inputTextContent2 = null,
            global::System.Action<global::tryAGI.OpenAI.OutputTextContent2?>? outputTextContent2 = null,
            global::System.Action<global::tryAGI.OpenAI.TextContent?>? text = null,
            global::System.Action<global::tryAGI.OpenAI.SummaryTextContent?>? summaryText = null,
            global::System.Action<global::tryAGI.OpenAI.RefusalContent2?>? refusalContent2 = null,
            global::System.Action<global::tryAGI.OpenAI.InputImageContent2?>? inputImageContent2 = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerScreenshotContent?>? computerScreenshot = null,
            global::System.Action<global::tryAGI.OpenAI.InputFileContent2?>? inputFileContent2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputTextContent2)
            {
                inputTextContent2?.Invoke(InputTextContent2!);
            }
            else if (IsOutputTextContent2)
            {
                outputTextContent2?.Invoke(OutputTextContent2!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsSummaryText)
            {
                summaryText?.Invoke(SummaryText!);
            }
            else if (IsRefusalContent2)
            {
                refusalContent2?.Invoke(RefusalContent2!);
            }
            else if (IsInputImageContent2)
            {
                inputImageContent2?.Invoke(InputImageContent2!);
            }
            else if (IsComputerScreenshot)
            {
                computerScreenshot?.Invoke(ComputerScreenshot!);
            }
            else if (IsInputFileContent2)
            {
                inputFileContent2?.Invoke(InputFileContent2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputTextContent2,
                typeof(global::tryAGI.OpenAI.InputTextContent2),
                OutputTextContent2,
                typeof(global::tryAGI.OpenAI.OutputTextContent2),
                Text,
                typeof(global::tryAGI.OpenAI.TextContent),
                SummaryText,
                typeof(global::tryAGI.OpenAI.SummaryTextContent),
                RefusalContent2,
                typeof(global::tryAGI.OpenAI.RefusalContent2),
                InputImageContent2,
                typeof(global::tryAGI.OpenAI.InputImageContent2),
                ComputerScreenshot,
                typeof(global::tryAGI.OpenAI.ComputerScreenshotContent),
                InputFileContent2,
                typeof(global::tryAGI.OpenAI.InputFileContent2),
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
        public bool Equals(ContentItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputTextContent2?>.Default.Equals(InputTextContent2, other.InputTextContent2) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.OutputTextContent2?>.Default.Equals(OutputTextContent2, other.OutputTextContent2) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.TextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SummaryTextContent?>.Default.Equals(SummaryText, other.SummaryText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RefusalContent2?>.Default.Equals(RefusalContent2, other.RefusalContent2) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputImageContent2?>.Default.Equals(InputImageContent2, other.InputImageContent2) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerScreenshotContent?>.Default.Equals(ComputerScreenshot, other.ComputerScreenshot) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputFileContent2?>.Default.Equals(InputFileContent2, other.InputFileContent2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentItem obj1, ContentItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentItem obj1, ContentItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentItem o && Equals(o);
        }
    }
}

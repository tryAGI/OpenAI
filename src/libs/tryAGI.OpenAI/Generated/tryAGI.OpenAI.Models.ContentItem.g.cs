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
        /// A text input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputTextContent? InputText { get; init; }
#else
        public global::tryAGI.OpenAI.InputTextContent? InputText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputText))]
#endif
        public bool IsInputText => InputText != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::tryAGI.OpenAI.InputTextContent value) => new ContentItem((global::tryAGI.OpenAI.InputTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputTextContent?(ContentItem @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::tryAGI.OpenAI.InputTextContent? value)
        {
            InputText = value;
        }

        /// <summary>
        /// A text output from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.OutputTextContent? OutputText { get; init; }
#else
        public global::tryAGI.OpenAI.OutputTextContent? OutputText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputText))]
#endif
        public bool IsOutputText => OutputText != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::tryAGI.OpenAI.OutputTextContent value) => new ContentItem((global::tryAGI.OpenAI.OutputTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.OutputTextContent?(ContentItem @this) => @this.OutputText;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::tryAGI.OpenAI.OutputTextContent? value)
        {
            OutputText = value;
        }

        /// <summary>
        /// A text content.
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
        /// A summary text from the model.
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
        /// Reasoning text from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.ReasoningTextContent? ReasoningText { get; init; }
#else
        public global::tryAGI.OpenAI.ReasoningTextContent? ReasoningText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningText))]
#endif
        public bool IsReasoningText => ReasoningText != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::tryAGI.OpenAI.ReasoningTextContent value) => new ContentItem((global::tryAGI.OpenAI.ReasoningTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ReasoningTextContent?(ContentItem @this) => @this.ReasoningText;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::tryAGI.OpenAI.ReasoningTextContent? value)
        {
            ReasoningText = value;
        }

        /// <summary>
        /// A refusal from the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.RefusalContent? Refusal { get; init; }
#else
        public global::tryAGI.OpenAI.RefusalContent? Refusal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Refusal))]
#endif
        public bool IsRefusal => Refusal != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::tryAGI.OpenAI.RefusalContent value) => new ContentItem((global::tryAGI.OpenAI.RefusalContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RefusalContent?(ContentItem @this) => @this.Refusal;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::tryAGI.OpenAI.RefusalContent? value)
        {
            Refusal = value;
        }

        /// <summary>
        /// An image input to the model. Learn about [image inputs](https://platform.openai.com/docs/guides/vision).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputImageContent? InputImage { get; init; }
#else
        public global::tryAGI.OpenAI.InputImageContent? InputImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputImage))]
#endif
        public bool IsInputImage => InputImage != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::tryAGI.OpenAI.InputImageContent value) => new ContentItem((global::tryAGI.OpenAI.InputImageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputImageContent?(ContentItem @this) => @this.InputImage;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::tryAGI.OpenAI.InputImageContent? value)
        {
            InputImage = value;
        }

        /// <summary>
        /// A screenshot of a computer.
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
        /// A file input to the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.InputFileContent? InputFile { get; init; }
#else
        public global::tryAGI.OpenAI.InputFileContent? InputFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputFile))]
#endif
        public bool IsInputFile => InputFile != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem(global::tryAGI.OpenAI.InputFileContent value) => new ContentItem((global::tryAGI.OpenAI.InputFileContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputFileContent?(ContentItem @this) => @this.InputFile;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(global::tryAGI.OpenAI.InputFileContent? value)
        {
            InputFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentItem(
            global::tryAGI.OpenAI.InputTextContent? inputText,
            global::tryAGI.OpenAI.OutputTextContent? outputText,
            global::tryAGI.OpenAI.TextContent? text,
            global::tryAGI.OpenAI.SummaryTextContent? summaryText,
            global::tryAGI.OpenAI.ReasoningTextContent? reasoningText,
            global::tryAGI.OpenAI.RefusalContent? refusal,
            global::tryAGI.OpenAI.InputImageContent? inputImage,
            global::tryAGI.OpenAI.ComputerScreenshotContent? computerScreenshot,
            global::tryAGI.OpenAI.InputFileContent? inputFile
            )
        {
            InputText = inputText;
            OutputText = outputText;
            Text = text;
            SummaryText = summaryText;
            ReasoningText = reasoningText;
            Refusal = refusal;
            InputImage = inputImage;
            ComputerScreenshot = computerScreenshot;
            InputFile = inputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputFile as object ??
            ComputerScreenshot as object ??
            InputImage as object ??
            Refusal as object ??
            ReasoningText as object ??
            SummaryText as object ??
            Text as object ??
            OutputText as object ??
            InputText as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputText?.ToString() ??
            OutputText?.ToString() ??
            Text?.ToString() ??
            SummaryText?.ToString() ??
            ReasoningText?.ToString() ??
            Refusal?.ToString() ??
            InputImage?.ToString() ??
            ComputerScreenshot?.ToString() ??
            InputFile?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputText || IsOutputText || IsText || IsSummaryText || IsReasoningText || IsRefusal || IsInputImage || IsComputerScreenshot || IsInputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.InputTextContent?, TResult>? inputText = null,
            global::System.Func<global::tryAGI.OpenAI.OutputTextContent?, TResult>? outputText = null,
            global::System.Func<global::tryAGI.OpenAI.TextContent?, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.SummaryTextContent?, TResult>? summaryText = null,
            global::System.Func<global::tryAGI.OpenAI.ReasoningTextContent?, TResult>? reasoningText = null,
            global::System.Func<global::tryAGI.OpenAI.RefusalContent?, TResult>? refusal = null,
            global::System.Func<global::tryAGI.OpenAI.InputImageContent?, TResult>? inputImage = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerScreenshotContent?, TResult>? computerScreenshot = null,
            global::System.Func<global::tryAGI.OpenAI.InputFileContent?, TResult>? inputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText && inputText != null)
            {
                return inputText(InputText!);
            }
            else if (IsOutputText && outputText != null)
            {
                return outputText(OutputText!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsSummaryText && summaryText != null)
            {
                return summaryText(SummaryText!);
            }
            else if (IsReasoningText && reasoningText != null)
            {
                return reasoningText(ReasoningText!);
            }
            else if (IsRefusal && refusal != null)
            {
                return refusal(Refusal!);
            }
            else if (IsInputImage && inputImage != null)
            {
                return inputImage(InputImage!);
            }
            else if (IsComputerScreenshot && computerScreenshot != null)
            {
                return computerScreenshot(ComputerScreenshot!);
            }
            else if (IsInputFile && inputFile != null)
            {
                return inputFile(InputFile!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::tryAGI.OpenAI.InputTextContent?>? inputText = null,
            global::System.Action<global::tryAGI.OpenAI.OutputTextContent?>? outputText = null,
            global::System.Action<global::tryAGI.OpenAI.TextContent?>? text = null,
            global::System.Action<global::tryAGI.OpenAI.SummaryTextContent?>? summaryText = null,
            global::System.Action<global::tryAGI.OpenAI.ReasoningTextContent?>? reasoningText = null,
            global::System.Action<global::tryAGI.OpenAI.RefusalContent?>? refusal = null,
            global::System.Action<global::tryAGI.OpenAI.InputImageContent?>? inputImage = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerScreenshotContent?>? computerScreenshot = null,
            global::System.Action<global::tryAGI.OpenAI.InputFileContent?>? inputFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputText)
            {
                inputText?.Invoke(InputText!);
            }
            else if (IsOutputText)
            {
                outputText?.Invoke(OutputText!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsSummaryText)
            {
                summaryText?.Invoke(SummaryText!);
            }
            else if (IsReasoningText)
            {
                reasoningText?.Invoke(ReasoningText!);
            }
            else if (IsRefusal)
            {
                refusal?.Invoke(Refusal!);
            }
            else if (IsInputImage)
            {
                inputImage?.Invoke(InputImage!);
            }
            else if (IsComputerScreenshot)
            {
                computerScreenshot?.Invoke(ComputerScreenshot!);
            }
            else if (IsInputFile)
            {
                inputFile?.Invoke(InputFile!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputText,
                typeof(global::tryAGI.OpenAI.InputTextContent),
                OutputText,
                typeof(global::tryAGI.OpenAI.OutputTextContent),
                Text,
                typeof(global::tryAGI.OpenAI.TextContent),
                SummaryText,
                typeof(global::tryAGI.OpenAI.SummaryTextContent),
                ReasoningText,
                typeof(global::tryAGI.OpenAI.ReasoningTextContent),
                Refusal,
                typeof(global::tryAGI.OpenAI.RefusalContent),
                InputImage,
                typeof(global::tryAGI.OpenAI.InputImageContent),
                ComputerScreenshot,
                typeof(global::tryAGI.OpenAI.ComputerScreenshotContent),
                InputFile,
                typeof(global::tryAGI.OpenAI.InputFileContent),
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
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputTextContent?>.Default.Equals(InputText, other.InputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.OutputTextContent?>.Default.Equals(OutputText, other.OutputText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.TextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.SummaryTextContent?>.Default.Equals(SummaryText, other.SummaryText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ReasoningTextContent?>.Default.Equals(ReasoningText, other.ReasoningText) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.RefusalContent?>.Default.Equals(Refusal, other.Refusal) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputImageContent?>.Default.Equals(InputImage, other.InputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.ComputerScreenshotContent?>.Default.Equals(ComputerScreenshot, other.ComputerScreenshot) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.InputFileContent?>.Default.Equals(InputFile, other.InputFile) 
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

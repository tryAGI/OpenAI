#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A content part that makes up an input or output item.
    /// </summary>
    public readonly partial struct ContentItem3 : global::System.IEquatable<ContentItem3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.MessageContentItemDiscriminatorType? Type { get; }

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
        public bool TryPickInputText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.InputTextContent? value)
        {
            value = InputText;
            return IsInputText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.InputTextContent PickInputText() => IsInputText
            ? InputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputText' but the value was {ToString()}.");

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
        public bool TryPickOutputText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.OutputTextContent? value)
        {
            value = OutputText;
            return IsOutputText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.OutputTextContent PickOutputText() => IsOutputText
            ? OutputText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputText' but the value was {ToString()}.");

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
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.TextContent? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.TextContent PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

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
        public bool TryPickSummaryText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.SummaryTextContent? value)
        {
            value = SummaryText;
            return IsSummaryText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.SummaryTextContent PickSummaryText() => IsSummaryText
            ? SummaryText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SummaryText' but the value was {ToString()}.");

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
        public bool TryPickReasoningText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ReasoningTextContent? value)
        {
            value = ReasoningText;
            return IsReasoningText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ReasoningTextContent PickReasoningText() => IsReasoningText
            ? ReasoningText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningText' but the value was {ToString()}.");

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
        public bool TryPickRefusal(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.RefusalContent? value)
        {
            value = Refusal;
            return IsRefusal;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.RefusalContent PickRefusal() => IsRefusal
            ? Refusal!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Refusal' but the value was {ToString()}.");

        /// <summary>
        /// An image input to the model. Learn about [image inputs](/docs/guides/vision).
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
        public bool TryPickInputImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.InputImageContent? value)
        {
            value = InputImage;
            return IsInputImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.InputImageContent PickInputImage() => IsInputImage
            ? InputImage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputImage' but the value was {ToString()}.");

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
        public bool TryPickComputerScreenshot(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.ComputerScreenshotContent? value)
        {
            value = ComputerScreenshot;
            return IsComputerScreenshot;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.ComputerScreenshotContent PickComputerScreenshot() => IsComputerScreenshot
            ? ComputerScreenshot!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerScreenshot' but the value was {ToString()}.");

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
        public bool TryPickInputFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.InputFileContent? value)
        {
            value = InputFile;
            return IsInputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::tryAGI.OpenAI.InputFileContent PickInputFile() => IsInputFile
            ? InputFile!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputFile' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem3(global::tryAGI.OpenAI.InputTextContent value) => new ContentItem3((global::tryAGI.OpenAI.InputTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputTextContent?(ContentItem3 @this) => @this.InputText;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem3(global::tryAGI.OpenAI.InputTextContent? value)
        {
            InputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContentItem3 FromInputText(global::tryAGI.OpenAI.InputTextContent? value) => new ContentItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem3(global::tryAGI.OpenAI.OutputTextContent value) => new ContentItem3((global::tryAGI.OpenAI.OutputTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.OutputTextContent?(ContentItem3 @this) => @this.OutputText;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem3(global::tryAGI.OpenAI.OutputTextContent? value)
        {
            OutputText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContentItem3 FromOutputText(global::tryAGI.OpenAI.OutputTextContent? value) => new ContentItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem3(global::tryAGI.OpenAI.TextContent value) => new ContentItem3((global::tryAGI.OpenAI.TextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.TextContent?(ContentItem3 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem3(global::tryAGI.OpenAI.TextContent? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContentItem3 FromText(global::tryAGI.OpenAI.TextContent? value) => new ContentItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem3(global::tryAGI.OpenAI.SummaryTextContent value) => new ContentItem3((global::tryAGI.OpenAI.SummaryTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.SummaryTextContent?(ContentItem3 @this) => @this.SummaryText;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem3(global::tryAGI.OpenAI.SummaryTextContent? value)
        {
            SummaryText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContentItem3 FromSummaryText(global::tryAGI.OpenAI.SummaryTextContent? value) => new ContentItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem3(global::tryAGI.OpenAI.ReasoningTextContent value) => new ContentItem3((global::tryAGI.OpenAI.ReasoningTextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ReasoningTextContent?(ContentItem3 @this) => @this.ReasoningText;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem3(global::tryAGI.OpenAI.ReasoningTextContent? value)
        {
            ReasoningText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContentItem3 FromReasoningText(global::tryAGI.OpenAI.ReasoningTextContent? value) => new ContentItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem3(global::tryAGI.OpenAI.RefusalContent value) => new ContentItem3((global::tryAGI.OpenAI.RefusalContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.RefusalContent?(ContentItem3 @this) => @this.Refusal;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem3(global::tryAGI.OpenAI.RefusalContent? value)
        {
            Refusal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContentItem3 FromRefusal(global::tryAGI.OpenAI.RefusalContent? value) => new ContentItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem3(global::tryAGI.OpenAI.InputImageContent value) => new ContentItem3((global::tryAGI.OpenAI.InputImageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputImageContent?(ContentItem3 @this) => @this.InputImage;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem3(global::tryAGI.OpenAI.InputImageContent? value)
        {
            InputImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContentItem3 FromInputImage(global::tryAGI.OpenAI.InputImageContent? value) => new ContentItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem3(global::tryAGI.OpenAI.ComputerScreenshotContent value) => new ContentItem3((global::tryAGI.OpenAI.ComputerScreenshotContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.ComputerScreenshotContent?(ContentItem3 @this) => @this.ComputerScreenshot;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem3(global::tryAGI.OpenAI.ComputerScreenshotContent? value)
        {
            ComputerScreenshot = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContentItem3 FromComputerScreenshot(global::tryAGI.OpenAI.ComputerScreenshotContent? value) => new ContentItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentItem3(global::tryAGI.OpenAI.InputFileContent value) => new ContentItem3((global::tryAGI.OpenAI.InputFileContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.InputFileContent?(ContentItem3 @this) => @this.InputFile;

        /// <summary>
        /// 
        /// </summary>
        public ContentItem3(global::tryAGI.OpenAI.InputFileContent? value)
        {
            InputFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ContentItem3 FromInputFile(global::tryAGI.OpenAI.InputFileContent? value) => new ContentItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public ContentItem3(
            global::tryAGI.OpenAI.MessageContentItemDiscriminatorType? type,
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
            Type = type;

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
            return IsInputText && !IsOutputText && !IsText && !IsSummaryText && !IsReasoningText && !IsRefusal && !IsInputImage && !IsComputerScreenshot && !IsInputFile || !IsInputText && IsOutputText && !IsText && !IsSummaryText && !IsReasoningText && !IsRefusal && !IsInputImage && !IsComputerScreenshot && !IsInputFile || !IsInputText && !IsOutputText && IsText && !IsSummaryText && !IsReasoningText && !IsRefusal && !IsInputImage && !IsComputerScreenshot && !IsInputFile || !IsInputText && !IsOutputText && !IsText && IsSummaryText && !IsReasoningText && !IsRefusal && !IsInputImage && !IsComputerScreenshot && !IsInputFile || !IsInputText && !IsOutputText && !IsText && !IsSummaryText && IsReasoningText && !IsRefusal && !IsInputImage && !IsComputerScreenshot && !IsInputFile || !IsInputText && !IsOutputText && !IsText && !IsSummaryText && !IsReasoningText && IsRefusal && !IsInputImage && !IsComputerScreenshot && !IsInputFile || !IsInputText && !IsOutputText && !IsText && !IsSummaryText && !IsReasoningText && !IsRefusal && IsInputImage && !IsComputerScreenshot && !IsInputFile || !IsInputText && !IsOutputText && !IsText && !IsSummaryText && !IsReasoningText && !IsRefusal && !IsInputImage && IsComputerScreenshot && !IsInputFile || !IsInputText && !IsOutputText && !IsText && !IsSummaryText && !IsReasoningText && !IsRefusal && !IsInputImage && !IsComputerScreenshot && IsInputFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::tryAGI.OpenAI.InputTextContent, TResult>? inputText = null,
            global::System.Func<global::tryAGI.OpenAI.OutputTextContent, TResult>? outputText = null,
            global::System.Func<global::tryAGI.OpenAI.TextContent, TResult>? text = null,
            global::System.Func<global::tryAGI.OpenAI.SummaryTextContent, TResult>? summaryText = null,
            global::System.Func<global::tryAGI.OpenAI.ReasoningTextContent, TResult>? reasoningText = null,
            global::System.Func<global::tryAGI.OpenAI.RefusalContent, TResult>? refusal = null,
            global::System.Func<global::tryAGI.OpenAI.InputImageContent, TResult>? inputImage = null,
            global::System.Func<global::tryAGI.OpenAI.ComputerScreenshotContent, TResult>? computerScreenshot = null,
            global::System.Func<global::tryAGI.OpenAI.InputFileContent, TResult>? inputFile = null,
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
            global::System.Action<global::tryAGI.OpenAI.InputTextContent>? inputText = null,

            global::System.Action<global::tryAGI.OpenAI.OutputTextContent>? outputText = null,

            global::System.Action<global::tryAGI.OpenAI.TextContent>? text = null,

            global::System.Action<global::tryAGI.OpenAI.SummaryTextContent>? summaryText = null,

            global::System.Action<global::tryAGI.OpenAI.ReasoningTextContent>? reasoningText = null,

            global::System.Action<global::tryAGI.OpenAI.RefusalContent>? refusal = null,

            global::System.Action<global::tryAGI.OpenAI.InputImageContent>? inputImage = null,

            global::System.Action<global::tryAGI.OpenAI.ComputerScreenshotContent>? computerScreenshot = null,

            global::System.Action<global::tryAGI.OpenAI.InputFileContent>? inputFile = null,
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
        public void Switch(
            global::System.Action<global::tryAGI.OpenAI.InputTextContent>? inputText = null,
            global::System.Action<global::tryAGI.OpenAI.OutputTextContent>? outputText = null,
            global::System.Action<global::tryAGI.OpenAI.TextContent>? text = null,
            global::System.Action<global::tryAGI.OpenAI.SummaryTextContent>? summaryText = null,
            global::System.Action<global::tryAGI.OpenAI.ReasoningTextContent>? reasoningText = null,
            global::System.Action<global::tryAGI.OpenAI.RefusalContent>? refusal = null,
            global::System.Action<global::tryAGI.OpenAI.InputImageContent>? inputImage = null,
            global::System.Action<global::tryAGI.OpenAI.ComputerScreenshotContent>? computerScreenshot = null,
            global::System.Action<global::tryAGI.OpenAI.InputFileContent>? inputFile = null,
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
        public bool Equals(ContentItem3 other)
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
        public static bool operator ==(ContentItem3 obj1, ContentItem3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentItem3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentItem3 obj1, ContentItem3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentItem3 o && Equals(o);
        }
    }
}

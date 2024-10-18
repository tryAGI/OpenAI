#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class AssistantStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.AssistantStreamEvent>
    {
        /// <inheritdoc />
        public override global::OpenAI.AssistantStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.ErrorEvent? value1 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.ErrorEvent)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.DoneEvent? value2 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.Done)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.DoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.DoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.DoneEvent)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant3? value3 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant3)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant4? value4 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant4)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant5? value5 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunQueued)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant5)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant6? value6 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant6)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant7? value7 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunRequiresAction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant7)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant8? value8 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant8)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant9? value9 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant9)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant10? value10 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant10)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant11? value11 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunCancelling)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant11)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant12? value12 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant12)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant13? value13 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunExpired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant13)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant14? value14 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunStepCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant14)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant15? value15 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunStepInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant15)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant16? value16 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunStepDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant16)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant17? value17 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunStepCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant17)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant18? value18 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunStepFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant18> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant18)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant19? value19 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunStepCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant19> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant19)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant20? value20 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunStepExpired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant20> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant20)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant21? value21 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadMessageCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant21> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant21)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant22? value22 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadMessageInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant22> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant22)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant23? value23 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadMessageDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant23> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant23)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant24? value24 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadMessageCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant24), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant24> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant24)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant25? value25 = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadMessageIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant25), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant25> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant25)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.AssistantStreamEvent(
                discriminator?.Event,
                value1,
                value2,
                value3,
                value4,
                value5,
                value6,
                value7,
                value8,
                value9,
                value10,
                value11,
                value12,
                value13,
                value14,
                value15,
                value16,
                value17,
                value18,
                value19,
                value20,
                value21,
                value22,
                value23,
                value24,
                value25
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.AssistantStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.DoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.DoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.DoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeInfo);
            }
            else if (value.IsValue5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value5, typeInfo);
            }
            else if (value.IsValue6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value6, typeInfo);
            }
            else if (value.IsValue7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value7, typeInfo);
            }
            else if (value.IsValue8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value8, typeInfo);
            }
            else if (value.IsValue9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value9, typeInfo);
            }
            else if (value.IsValue10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value10, typeInfo);
            }
            else if (value.IsValue11)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value11, typeInfo);
            }
            else if (value.IsValue12)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value12, typeInfo);
            }
            else if (value.IsValue13)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant13?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value13, typeInfo);
            }
            else if (value.IsValue14)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant14?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value14, typeInfo);
            }
            else if (value.IsValue15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value15, typeInfo);
            }
            else if (value.IsValue16)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant16?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value16, typeInfo);
            }
            else if (value.IsValue17)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant17?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value17, typeInfo);
            }
            else if (value.IsValue18)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant18?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant18).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value18, typeInfo);
            }
            else if (value.IsValue19)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant19?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant19).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value19, typeInfo);
            }
            else if (value.IsValue20)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant20?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant20).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value20, typeInfo);
            }
            else if (value.IsValue21)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant21?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant21).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value21, typeInfo);
            }
            else if (value.IsValue22)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant22?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant22).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value22, typeInfo);
            }
            else if (value.IsValue23)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant23?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant23).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value23, typeInfo);
            }
            else if (value.IsValue24)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant24), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant24?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant24).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value24, typeInfo);
            }
            else if (value.IsValue25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant25), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant25?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant25).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value25, typeInfo);
            }
        }
    }
}
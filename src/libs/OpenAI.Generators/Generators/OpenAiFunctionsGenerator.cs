using System.ComponentModel;
using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace H.Generators;

[Generator]
public class OpenAiFunctionsGenerator : IIncrementalGenerator
{
    #region Constants

    public const string Name = nameof(OpenAiFunctionsGenerator);
    public const string Id = "OAFG";

    #endregion

    #region Methods

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var attributes =
            context.SyntaxProvider
                .ForAttributeWithMetadataName("OpenAI.OpenAiFunctionsAttribute")
                .SelectManyAllAttributesOfCurrentInterfaceSyntax()
                .SelectAndReportExceptions(PrepareData, context, Id);
        
        attributes
            .SelectAndReportExceptions(AsTools, context, Id)
            .AddSource(context);
        attributes
            .SelectAndReportExceptions(AsCalls, context, Id)
            .AddSource(context);
    }

    private static string GetDescription(ISymbol symbol)
    {
        return symbol.GetAttributes()
            .FirstOrDefault(static x => x.AttributeClass?.Name == nameof(DescriptionAttribute))?
            .ConstructorArguments.First().Value?.ToString() ?? string.Empty;
    }
    
    private static InterfaceData PrepareData(
        (SemanticModel SemanticModel, AttributeData AttributeData, InterfaceDeclarationSyntax InterfaceSyntax, INamedTypeSymbol InterfaceSymbol) tuple)
    {
        var (_, _, _, interfaceSymbol) = tuple;

        var methods = interfaceSymbol
            .GetMembers()
            .OfType<IMethodSymbol>()
            .Where(static x => x.MethodKind == MethodKind.Ordinary)
            .Select(static x => new MethodData(
                Name: x.Name,
                Description: GetDescription(x),
                IsAsync: x.IsAsync || x.ReturnType.Name == "Task",
                IsVoid: x.ReturnsVoid,
                Parameters: new SchemaData(
                    Name: x.Name,
                    Description: GetDescription(x),
                    Type: "object",
                    SchemaType: "object",
                    Properties:
                        x.Parameters
                            .Where(static x => x.Type.MetadataName != "CancellationToken")
                            .Select(static x => ToParameterData(
                                typeSymbol: x.Type,
                                name: x.Name,
                                description: GetDescription(x),
                                isRequired: !x.IsOptional))
                            .ToArray(),
                    EnumValues: Array.Empty<string>(),
                    IsNullable: false,
                    IsRequired: true,
                    Format: null,
                    ArrayItem: Array.Empty<SchemaData>(),
                    DefaultValue: string.Empty)))
            .ToArray();

        return new InterfaceData(
            Namespace: interfaceSymbol.ContainingNamespace.ToDisplayString(),
            Name: interfaceSymbol.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat),
            Methods: methods);
    }
    
    private static SchemaData ToParameterData(ITypeSymbol typeSymbol, string? name = null, string? description = null, bool isRequired = true)
    {
        string schemaType;
        string? format = null;
        var properties = Array.Empty<SchemaData>();
        SchemaData? arrayItem = null;
        switch (typeSymbol.TypeKind)
        {
            case TypeKind.Enum:
                schemaType = "string";
                break;
            
            case TypeKind.Structure:
                switch (typeSymbol.SpecialType)
                {
                    case SpecialType.System_Int32:
                        schemaType = "integer";
                        format = "int32";
                        break;
                    
                    case SpecialType.System_Int64:
                        schemaType = "integer";
                        format = "int64";
                        break;
                    
                    case SpecialType.System_Single:
                        schemaType = "number";
                        format = "double";
                        break;
                    
                    case SpecialType.System_Double:
                        schemaType = "number";
                        format = "float";
                        break;
                    
                    case SpecialType.System_DateTime:
                        schemaType = "string";
                        format = "date-time";
                        break;
                    
                    case SpecialType.System_Boolean:
                        schemaType = "boolean";
                        break;
                    
                    case SpecialType.None:
                        switch (typeSymbol.Name)
                        {
                            case "DateOnly":
                                schemaType = "string";
                                format = "date";
                                break;
                            
                            default:
                                throw new NotImplementedException($"{typeSymbol.Name} is not implemented.");
                        }
                        break;
                    
                    default:
                        throw new NotImplementedException($"{typeSymbol.SpecialType} is not implemented.");
                }
                break;
            
            case TypeKind.Class:
                switch (typeSymbol.SpecialType)
                {
                    case SpecialType.System_String:
                        schemaType = "string";
                        break;
                    
                    
                    case SpecialType.None:
                        schemaType = "object";
                        properties = typeSymbol.GetMembers()
                            .OfType<IPropertySymbol>()
                            .Select(static y => ToParameterData(
                                typeSymbol: y.Type,
                                name: y.Name,
                                description: GetDescription(y),
                                isRequired: true))
                            .ToArray();
                        break;
                    
                    default:
                        throw new NotImplementedException($"{typeSymbol.SpecialType} is not implemented.");
                }
                break;
            
            case TypeKind.Interface when typeSymbol.MetadataName == "IReadOnlyCollection`1":
                schemaType = "array";
                arrayItem = (typeSymbol as INamedTypeSymbol)?.TypeArguments
                    .Select(static y => ToParameterData(y))
                    .FirstOrDefault();
                break;
            
            case TypeKind.Array:
                schemaType = "array";
                arrayItem = ToParameterData((typeSymbol as IArrayTypeSymbol)?.ElementType!);
                break;
            
            default:
                throw new NotImplementedException($"{typeSymbol.TypeKind} is not implemented.");
        }
        
        return new SchemaData(
            Name: !string.IsNullOrWhiteSpace(name)
                ? name!
                : typeSymbol.Name,
            Description: !string.IsNullOrWhiteSpace(description)
                ? description!
                : GetDescription(typeSymbol),
            Type: typeSymbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat),
            DefaultValue: GetDefaultValue(typeSymbol),
            SchemaType: schemaType,
            Format: format,
            Properties: properties,
            ArrayItem: arrayItem != null ? [arrayItem.Value] : Array.Empty<SchemaData>(),
            EnumValues: typeSymbol.TypeKind == TypeKind.Enum
                ? typeSymbol
                    .GetMembers()
                    .OfType<IFieldSymbol>()
                    .Select(static x => x.Name.ToLowerInvariant())
                    .ToArray()
                : Array.Empty<string>(),
            IsNullable: IsNullable(typeSymbol),
            IsRequired: isRequired);
    }
    
    private static bool IsNullable(ITypeSymbol typeSymbol)
    {
        if (typeSymbol.TypeKind == TypeKind.Enum)
        {
            return false;
        }
        if (typeSymbol.TypeKind == TypeKind.Structure)
        {
            return false;
        }

        return typeSymbol.SpecialType switch
        {
            SpecialType.System_String => false,
            _ => true,
        };
    }
    
    private static string GetDefaultValue(ITypeSymbol typeSymbol)
    {
        switch (typeSymbol.SpecialType)
        {
            case SpecialType.System_String:
                return "string.Empty";
                    
            default:
                return string.Empty;
        }
    }
    
    private static FileWithName AsTools(InterfaceData @interface)
    {
        return new FileWithName(
            Name: $"{@interface.Name}.Tools.generated.cs",
            Text: Sources.GenerateClientImplementation(@interface));
    }
    
    private static FileWithName AsCalls(InterfaceData @interface)
    {
        return new FileWithName(
            Name: $"{@interface.Name}.Calls.generated.cs",
            Text: Sources.GenerateCalls(@interface));
    }

    #endregion
}
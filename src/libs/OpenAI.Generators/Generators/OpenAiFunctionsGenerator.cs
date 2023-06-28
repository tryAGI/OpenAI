using System.ComponentModel;
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
        context.SyntaxProvider
            .ForAttributeWithMetadataName("tryAGI.OpenAI.OpenAiFunctionsAttribute")
            .SelectManyAllAttributesOfCurrentInterfaceSyntax()
            .SelectAndReportExceptions(PrepareData, context, Id)
            .SelectAndReportExceptions(GetClientSourceCode, context, Id)
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
                Parameters: x.Parameters
                    .Where(static x => x.Type.MetadataName != "CancellationToken")
                    .Select(static x => ToParameterData(
                        typeSymbol: x.Type,
                        name: x.Name,
                        description: GetDescription(x),
                        isRequired: !x.IsOptional))
                    .ToArray()))
            .ToArray();

        return new InterfaceData(
            Namespace: interfaceSymbol.ContainingNamespace.ToDisplayString(),
            Name: interfaceSymbol.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat),
            Methods: methods);
    }
    
    private static ParameterData ToParameterData(ITypeSymbol typeSymbol, string? name = null, string? description = null, bool isRequired = true)
    {
        string schemaType;
        var properties = Array.Empty<ParameterData>();
        ParameterData? arrayItem = null;
        switch (typeSymbol.TypeKind)
        {
            case TypeKind.Enum:
                schemaType = "string";
                break;
            
            case TypeKind.Class:
                switch (typeSymbol.SpecialType)
                {
                    case SpecialType.System_String:
                        schemaType = "string";
                        break;
                    
                    case SpecialType.System_Int32:
                        schemaType = "integer";
                        break;
                    
                    case SpecialType.System_Boolean:
                        schemaType = "boolean";
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
            
            default:
                throw new NotImplementedException($"{typeSymbol.TypeKind} is not implemented.");
        }
        
        return new ParameterData(
            Name: !string.IsNullOrWhiteSpace(name)
                ? name!
                : typeSymbol.Name,
            Description: !string.IsNullOrWhiteSpace(description)
                ? description!
                : GetDescription(typeSymbol),
            Type: typeSymbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat),
            DefaultValue: GetDefaultValue(typeSymbol),
            SchemaType: schemaType,
            Properties: properties,
            ArrayItem: arrayItem != null
                ? new []{ arrayItem.Value }
                : Array.Empty<ParameterData>(),
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
    
    private static FileWithName GetClientSourceCode(InterfaceData @interface)
    {
        return new FileWithName(
            Name: $"{@interface.Name}.Functions.generated.cs",
            Text: SourceGenerationHelper.GenerateClientImplementation(@interface));
    }

    #endregion
}
using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace OpenAI.IntegrationTests.Examples;

// # START EXAMPLE #

[OpenAiTools(Strict = false)]
public interface IAllToolsService
{
    [Description("Provided a family relation type like 'father' or 'mother', "
                 + "gets the name of the related person from the user.")]
    public string GetNameOfFamilyMember(
        [Description("The relation to the user to query, e.g. 'mother' or 'father'")]
        string relation);
}

public class AllToolsService : IAllToolsService
{
    public string GetNameOfFamilyMember(string relation)
    {
        return relation switch
        {
            not null when relation.Contains("father") => "John Doe",
            not null when relation.Contains("mother") => "Jane Doe",
            _ => throw new ArgumentException(relation, nameof(relation))
        };
    }
}
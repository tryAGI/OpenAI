using tryAGI.OpenAI;

namespace H.Ipc.Generator.IntegrationTests;

[TestClass]
public class Tests
{
    [TestMethod]
    [Ignore]
    public async Task SimpleMethod()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY is not set.");
        using var httpClient = new HttpClient();
        var api = new OpenAiApi(apiKey, httpClient);
        var service = new WeatherService();
        var messages = new List<ChatCompletionRequestMessage>
        {
            "You are a helpful weather assistant.".AsSystemMessage(),
            "What's the weather like today?".AsUserMessage(),
        };
        var functions = service.AsFunctions();
        var result = await api.CreateChatCompletionAsync(new CreateChatCompletionRequest
        {
            Messages = messages,
            Functions = functions,
            Function_call = Function_call4.Auto,
            Model = "gpt-3.5-turbo-0613",
        });
        var resultMessage = result.GetFirstChoiceMessage();
        messages.Add(resultMessage.AsRequestMessage());
        Console.WriteLine($"{resultMessage.Role}: {resultMessage.Content} | Finish Reason: {result.Choices.First().Finish_reason}");
        var locationMessage = new ChatCompletionRequestMessage
        {
            Role = ChatCompletionRequestMessageRole.User,
            Content = "Dubai, UAE",
        };
        messages.Add(locationMessage);
        Console.WriteLine($"{locationMessage.Role}: {locationMessage.Content}");
        result = await api.CreateChatCompletionAsync(new CreateChatCompletionRequest
        {
            Messages = messages,
            Functions = functions,
            Function_call = Function_call4.Auto,
            Model = "gpt-3.5-turbo-0613",
        });
        resultMessage = result.GetFirstChoiceMessage();
        messages.Add(resultMessage.AsRequestMessage());

        if (!string.IsNullOrWhiteSpace(resultMessage.Content))
        {
            // It's possible that the assistant will also ask you which units you want the temperature in.
            Console.WriteLine($"{resultMessage.Role}: {resultMessage.Content} | Finish Reason: {result.Choices.First().Finish_reason}");

            var unitMessage = new ChatCompletionRequestMessage
            {
                Role = ChatCompletionRequestMessageRole.User,
                Content = "celsius",
            };
            messages.Add(unitMessage);
            Console.WriteLine($"{unitMessage.Role}: {unitMessage.Content}");
            result = await api.CreateChatCompletionAsync(new CreateChatCompletionRequest
            {
                Messages = messages,
                Functions = functions,
                Function_call = Function_call4.Auto,
                Model = "gpt-3.5-turbo-0613",
            });
            resultMessage = result.GetFirstChoiceMessage();
        }

        Console.WriteLine($"{resultMessage.Role}: {resultMessage.Function_call?.Name} | Finish Reason: {result.Choices.First().Finish_reason}");
        Console.WriteLine($"{resultMessage.Function_call?.Arguments}");
        var json = await service.CallGetCurrentWeatherAsync(resultMessage.Function_call?.Arguments ?? string.Empty);
        Console.WriteLine($"Function: {json}");
    }

    [TestMethod]
    public void Call()
    {
        var json = /* lang=json */ """
                   {
                       "location": "Dubai, UAE"
                   }
                   """;
        var result = new WeatherService().CallGetCurrentWeather(json);

        result.Should().Be(/* lang=json */ """
            {"location":"Dubai, UAE","temperature":22,"unit":"celsius","description":"Sunny"}
            """);
    }
    
    [TestMethod]
    public async Task UpdateCode()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY is not set.");
        using var httpClient = new HttpClient();
        var api = new OpenAiApi(apiKey, httpClient);
        var service = new UpdateCodeService();
        var messages = new List<ChatCompletionRequestMessage>
        {
            "You are a Senior C# programmer.".AsSystemMessage(),
            /* lang=markdown */"""
You solve the issue with this description:
```
Hey there. My boss asked me to refactor our legacy project. Can you do that for me? They asked me to use SOLID principles, KISS, YAGNI and DRY as well as clean code
The IUserCreditService and IUserCreditServiceChannel interfaces and the UserCreditServiceClient class are generated code so please don't change them.
Keep in mind that anything withing LegacyApp.Consumer is someone else's code and MUST NOT be changed.
Please don't introduce any breaking changes in the UserService class and its AddUser method.
```
I need new steps to prevent these errors:
```
Non-nullable property 'Firstname' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
```
```
Non-nullable property 'Surname' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
```
```
Non-nullable property 'EmailAddress' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
```
```
Non-nullable property 'Client' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
```
```
Possible null reference assignment.
```
Here is the code:

LegacyApp/User.cs
```csharp
using System;

namespace LegacyApp
{
    public class User
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string EmailAddress { get; set; }

        public bool HasCreditLimit { get; set; }

        public int CreditLimit { get; set; }

        public Client Client { get; set; }
    }
}
```

LegacyApp/UserService.cs
```csharp
using System;

#nullable enable
namespace LegacyApp
{
    public class UserService
    {
        public bool AddUser(string? firname, string? surname, string? email, DateTime dateOfBirth, int clientId)
        {
            if (string.IsNullOrEmpty(firname) || string.IsNullOrEmpty(surname))
            {
                return false;
            }

            if (email == null || (!email.Contains(""@"") && !email.Contains(""."")))
            {
                return false;
            }

            var now = DateTime.Now;
            int age = now.Year - dateOfBirth.Year;
            if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) age--;

            if (age < 21)
            {
                return false;
            }

            var clientRepository = new ClientRepository();
            var client = clientRepository.GetById(clientId);

            var user = new User
            {
                Client = client,
                DateOfBirth = dateOfBirth,
                EmailAddress = email,
                Firstname = firname,
                Surname = surname
            };

            if (client?.Name == ""VeryImportantClient"")
            {
                // Skip credit check
                user.HasCreditLimit = false;
            }
            else if (client?.Name == ""ImportantClient"")
            {
                // Do credit check and double credit limit
                user.HasCreditLimit = true;
                using (var userCreditService = new UserCreditServiceClient())
                {
                    var creditLimit = userCreditService.GetCreditLimit(user.Firstname, user.Surname, user.DateOfBirth);
                    creditLimit = creditLimit * 2;
                    user.CreditLimit = creditLimit;
                }
            }
            else
            {
                // Do credit check
                user.HasCreditLimit = true;
                using (var userCreditService = new UserCreditServiceClient())
                {
                    var creditLimit = userCreditService.GetCreditLimit(user.Firstname, user.Surname, user.DateOfBirth);
                    user.CreditLimit = creditLimit;
                }
            }

            if (user.HasCreditLimit && user.CreditLimit < 500)
            {
                return false;
            }

            UserDataAccess.AddUser(user);

            return true;
        }
    }
}
```
""".AsUserMessage(),
        };
        var result = await api.CreateChatCompletionAsync(new CreateChatCompletionRequest
        {
            Messages = messages,
            Functions = service.AsFunctions(),
            Function_call = Function_call4.Auto,
            Model = "gpt-3.5-turbo-0613",
        });
        var json = result.Choices.First().Message?.Function_call?.Arguments ?? string.Empty;
        Console.WriteLine(json);
        
        var args = service.AsUpdateCodeArgs(json);
        args.Changes.Should().NotBeEmpty();
    }
}
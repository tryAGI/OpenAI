// using System.Threading;
// using System.Threading.Tasks;
// using tryAGI.OpenAI;
//
// namespace H.Ipc.Generator.IntegrationTests;
//
// [OpenAiFunctions]
// public interface IMaintenanceFunctions
// {
//     [System.ComponentModel.Description("Get the tasks to extract from a contract")]
//     public Task<ExtractTasksRequest> GetContractTasksAsync([System.ComponentModel.Description("The tasks extracted from the contract")] ExtractTasksRequest tasks, CancellationToken cancellationToken = default);
// }
//
// public class MaintenanceService : IMaintenanceFunctions
// {
//     public Task<ExtractTasksRequest> GetContractTasksAsync(ExtractTasksRequest tasks, CancellationToken cancellationToken = default)
//     {
//         return Task.FromResult(tasks);
//     }
// }
//
// public class ExtractTasksRequest
// {
//     public string[] Tasks { get; set; }
// }
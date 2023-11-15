// using System;
// using System.Collections.Generic;
// using tryAGI.OpenAI;
// using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;
//
// namespace H.Ipc.Generator.IntegrationTests;
//
// /// <summary>
// /// 
// /// </summary>
// public enum ChangeType
// {
//     /// <summary>
//     /// 
//     /// </summary>
//     CreateFile,
//     
//     /// <summary>
//     /// 
//     /// </summary>
//     ReplaceFragment,
//     
//     /// <summary>
//     /// 
//     /// </summary>
//     DeleteFragment,
//     
//     /// <summary>
//     /// 
//     /// </summary>
//     RenameFile,
//     
//     /// <summary>
//     /// 
//     /// </summary>
//     DeleteFile,
//     
//     /// <summary>
//     /// 
//     /// </summary>
//     End,
// }
//
// public class Change
// {
//     /// <summary>
//     /// 
//     /// </summary>
//     [Description("Describes the type of change to be made")]
//     public ChangeType Type { get; set; }
//     
//     /// <summary>
//     /// 
//     /// </summary>
//     [Description("Specifies the path to a file")]
//     public string Path { get; set; } = string.Empty;
//     
//     /// <summary>
//     /// 
//     /// </summary>
//     [Description("Specifies the code to be removed. Used when deleting or replacing code.")]
//     public string RemoveCode { get; set; } = string.Empty;
//     
//     /// <summary>
//     /// 
//     /// </summary>
//     [Description("Specifies the code to add. Used when creating a file or replacing code.")]
//     public string AddCode { get; set; } = string.Empty;
//     
//     /// <summary>
//     /// 
//     /// </summary>
//     [Description("Specifies the new path for the file. Used when renaming a file.")]
//     public string NewPath { get; set; } = string.Empty;
// }
//
// [OpenAiFunctions]
// public interface IUpdateCodeFunctions
// {
//     [Description("Allows to change the project code")]
//     public void UpdateCode(
//         [Description("A series of code changes that must end with END change type")] IReadOnlyCollection<Change> changes);
// }
//
// public class UpdateCodeService : IUpdateCodeFunctions
// {
//     public void UpdateCode(IReadOnlyCollection<Change> changes)
//     {
//         changes = changes ?? throw new ArgumentNullException(nameof(changes));
//         
//         foreach (var change in changes)
//         {
//             Console.WriteLine($"Type: {change.Type}, Path: {change.Path}");
//             Console.WriteLine($"RemoveCode: {change.RemoveCode}");
//             Console.WriteLine($"AddCode: {change.AddCode}");
//             Console.WriteLine($"NewPath: {change.NewPath}");
//         }
//     }
// }
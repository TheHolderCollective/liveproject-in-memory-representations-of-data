
using Gtc.Services;
// Uncomment the following line for Milestone 1
using Gtc.Models.Congress;

var secretConfigReader = new SecretConfigReader();
var federalRegisterService = new FederalRegisterService();
// Uncomment the following line for Milestone 1
var congressService = new CongressService(secretConfigReader);

// begin test code
//var  response = congressService.GetCongressResponseAsync();
//Console.WriteLine(response.Result);

// end of test code

// Uncomment the following five lines for Milestone 2
// var fileStorageService = new FileStorageService<CongressResponse>();
// var congressFileService = new CongressFileService(secretConfigReader, fileStorageService);
// var memoryStorageService = new MemoryStorageService();
// var federalRegisterMemoryService = new FederalRegisterMemoryService(memoryStorageService);

// Uncomment the following line for milestone 1
 var menuService = new MenuService(federalRegisterService, congressService);
// Delete de previous line and uncomment for milestone 2
// var menuService = new MenuService(federalRegisterMemoryService, congressFileService);

// Uncomment the following line for milestone 1
await menuService.ShowMenu();

using Grpc.Net.Client;
using GrpcGreeterClient;

var data = new HelloRequest { Name = "ezgim" };
var grpcChannel = GrpcChannel.ForAddress("http://localhost:5127");
var client = new Greeter.GreeterClient(grpcChannel);

var response = await client.SayHelloAsync(data);

Console.WriteLine(response);
Console.ReadLine();
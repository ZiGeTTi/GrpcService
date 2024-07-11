﻿
using Grpc.Net.Client;
using GrpcGreeterClient;
using GrpcOrderService;


//var data = new HelloRequest { Name = "ezgim" };
//var grpcChannel = GrpcChannel.ForAddress("http://localhost:5127");
//var client = new Greeter.GreeterClient(grpcChannel);

//var response = await client.SayHelloAsync(data);

//Console.WriteLine(response);



var dataOrderRequest = new OrderRequest { OrderId = 10 };
var grpcChannelOrder = GrpcChannel.ForAddress("http://localhost:5127");
var clientOrder = new OrderProcessing.OrderProcessingClient(grpcChannelOrder);

var responseOrder = await  clientOrder.GetOrderAsync(dataOrderRequest);

Console.WriteLine(responseOrder);

Console.ReadLine();
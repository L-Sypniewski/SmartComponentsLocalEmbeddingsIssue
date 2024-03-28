// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using LocalEmbeddings;
using SmartComponents.LocalEmbeddings;


var embedder = new Embedder(new LocalEmbedder());
var response = embedder.PerformEmbedding("I like pizza with pineapple");
Console.WriteLine(JsonSerializer.Serialize(response));

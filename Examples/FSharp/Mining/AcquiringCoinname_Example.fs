open System
open System.Net
open System.Net.Http
open System.Threading.Tasks
open Microsoft.Extensions.Logging
open Binance.Common
open Binance.Spot
open Binance.Spot.Models

[<EntryPoint>]
let main argv =
    let loggerFactory = LoggerFactory.Create(fun (builder:ILoggingBuilder) -> 
        builder.AddConsole() |> ignore
    )
    let logger = loggerFactory.CreateLogger()

    let loggingHandler = new BinanceLoggingHandler(logger)
    let httpClient = new HttpClient(loggingHandler)

    let apiKey = "api-key";
    let apiSecret = "api-secret";
    
    let mining = new Mining(httpClient, apiKey = apiKey, apiSecret = apiSecret)
    
    let result = mining.AcquiringCoinname() |> Async.AwaitTask |> Async.RunSynchronously
    
    0

namespace FSharp.WebAPI

open System.Web.Http
open System.Net
open System.Net.Http

type HelloResponse() =
    [<DefaultValue>] val mutable Message : string
 
type HomeController() =
    inherit ApiController()
    member this.Get() =
        this.Request.CreateResponse(
            HttpStatusCode.OK,
            HelloResponse(Message = "Hello from F#"))
namespace Api.Controllers

open Microsoft.AspNetCore.Mvc

[<Route("api/[controller]")>]
[<ApiController>]
type TestController () =
    inherit ControllerBase()

    [<HttpGet>]
    [<ProducesResponseType(200)>]
    member __.Get() =
         ActionResult<string>("Hello from the Test Controller")

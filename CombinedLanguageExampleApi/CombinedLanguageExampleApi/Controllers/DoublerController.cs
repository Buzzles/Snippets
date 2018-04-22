using CSharpServices;
using FSharpServices;
using Microsoft.AspNetCore.Mvc;

namespace CombinedLanguageExampleApi.Controllers
{
    [Route("api/Doubler")]
    public class DoublerController : Controller
    {
        private readonly ICSharpService _cSharpService;
        private readonly IFSharpService _fSharpService;

        public DoublerController(ICSharpService cSharpService, IFSharpService fSharpService)
        {
            _cSharpService = cSharpService;
            _fSharpService = fSharpService;
        }

        [Route("CSharpDoubler")]
        [HttpGet]
        public int CDoubler(int x)
        {
            return _cSharpService.Double(x);
        }

        [Route("FSharpDoubler")]
        [HttpGet]
        public int FDoubler(int x)
        {
            return _fSharpService.Doubler(x);
        }
    }
}
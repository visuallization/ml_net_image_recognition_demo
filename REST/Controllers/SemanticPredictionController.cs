using Microsoft.AspNetCore.Mvc;
using MLDigitAppML.Model;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemanticPredictionController : ControllerBase {
        // GET: api/<SemanticPredictionController>
        [HttpGet]
        public SemanticPrediction Get(string path) {
            ModelInput input = new ModelInput()
            {
                ImageSource = @path,
            };

            ModelOutput result = ConsumeModel.Predict(input);

            return new SemanticPrediction
            {
                Prediction = result.Prediction,
                Score = result.Score,
            };
        }
    }
}

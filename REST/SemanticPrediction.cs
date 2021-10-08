using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MLDigitAppML.Model;

namespace REST {
    public class SemanticPrediction {
        public string Prediction { get; set; }

        public float[] Score { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EDBackendAPI.Core.Utilities.Results
{
    public class Result : IResult
    {
        //this(success) yazmayıp, alttaki constructor'a "Success = success;" yazabilirdik. kod tekrarı olmasın diye bu şekilde kullandık.
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}

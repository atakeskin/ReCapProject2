using System.Net.Http;

namespace Core.Utilities.Results
{
    /// <summary>
    /// SuccessResult : true or true/message
    /// </summary>
    public class SuccessResult : Result
    {
        public SuccessResult(string message ) : base(true,message)
        {
        }

        public SuccessResult():base(true)
        {
        }
    }
}

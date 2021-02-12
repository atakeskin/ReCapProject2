using System.Net.Http;

namespace Core.Utilities.Results
{
    /// <summary>
    /// T Data and success : True/False and/or message returns
    /// </summary>
    public class DataResult<T> : Result,IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}

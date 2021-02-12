namespace Core.Utilities.Results
{
    /// <summary>
    /// T Data and/or success : True and/or message returns
    /// </summary>
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data,true, message)
        {
        }

        public SuccessDataResult(T data) : base(data,true)
        {
        }

        public SuccessDataResult(string message) : base(default, true, message)
        {
        }

        public SuccessDataResult() : base(default,true)
        {
        }
    }
}

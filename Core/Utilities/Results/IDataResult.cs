namespace Core.Utilities.Results
{
    /// <summary>
    /// Temel Void için başlangıç imzaları
    /// </summary>
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}

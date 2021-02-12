namespace Core.Utilities.Results
{
    /// <summary>
    /// Temel Void için başlangıç imzaları
    /// </summary>
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}

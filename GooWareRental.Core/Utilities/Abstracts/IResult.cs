namespace GooWareRental.Core.Utilities.Abstracts
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}

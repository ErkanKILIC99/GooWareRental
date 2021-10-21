namespace GooWareRental.Core.Utilities.Abstracts
{
    public interface IDataResult<TData> : IResult
    {
        TData Data { get; }
    }
}

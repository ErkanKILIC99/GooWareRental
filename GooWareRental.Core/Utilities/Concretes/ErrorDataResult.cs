namespace GooWareRental.Core.Utilities.Concretes
{
    public class ErrorDataResult<TData> : DataResult<TData>
    {
        public ErrorDataResult(TData data) : base(data, false) { }
        public ErrorDataResult(TData data, string message) : base(data, false, message) { }
    }
}

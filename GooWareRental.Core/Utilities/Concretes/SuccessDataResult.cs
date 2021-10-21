namespace GooWareRental.Core.Utilities.Concretes
{
    public class SuccessDataResult<TData> : DataResult<TData>
    {
        public SuccessDataResult(TData data) : base(data, true) { }
        public SuccessDataResult(TData data, string message) : base(data, true, message) { }
    }
}

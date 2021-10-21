using GooWareRental.Core.Utilities.Abstracts;

namespace GooWareRental.Core.Utilities.Concretes
{
    public class DataResult<TData> : Result, IDataResult<TData>
    {
        public TData Data { get; }

        public DataResult(TData data, bool success) : base(success) { Data = data; }
        public DataResult(TData data, bool success, string message) : base(success, message) { Data = data; }
    }
}

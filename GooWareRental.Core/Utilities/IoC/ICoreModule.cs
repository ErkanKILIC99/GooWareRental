using Microsoft.Extensions.DependencyInjection;

namespace GooWareRental.Core.Utilities.IoC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}

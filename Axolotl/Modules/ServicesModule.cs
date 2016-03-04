using Autofac;
using Autofac.Integration.WebApi;
using Axolotl.Services;

namespace Axolotl.Modules
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DataService>()
                .As<IDataService>()
                .InstancePerApiRequest();
        }
    }
}
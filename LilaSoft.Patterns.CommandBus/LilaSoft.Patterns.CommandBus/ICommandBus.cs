namespace LilaSoft.Patterns.CommandBus
{
    using System.Threading.Tasks;

    public interface ICommandBus
    {
        Task SendAsync<T>(T command) where T : IntegrationCommand;
    }
}

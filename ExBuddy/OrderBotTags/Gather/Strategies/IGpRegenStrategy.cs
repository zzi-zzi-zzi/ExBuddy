namespace ExBuddy.OrderBotTags.Gather
{
    using System.Threading.Tasks;

    internal interface IGpRegenStrategy
    {
        Task<GpRegenStrategyResult> RegenerateGp();
    }
}
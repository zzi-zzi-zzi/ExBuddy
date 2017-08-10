namespace ExBuddy.OrderBotTags.Gather
{
    using System;
    using System.Threading.Tasks;
    using Behaviors;
    using Enumerations;
    using ff14bot.Objects;
    using Interfaces;
    using Inventory;
    using Inventory.StockManagers;

    internal class AfterGatherGpRegenStrategy : IGpRegenStrategy
    {
        private readonly CordialStockManager cordialStock;

        /// <summary>
        /// Instantiates a new instance of <see cref="AfterGatherGpRegenStrategy"/> class.
        /// </summary>
        public AfterGatherGpRegenStrategy(CordialStockManager cordialStock)
        {
            this.cordialStock = cordialStock ?? throw new ArgumentNullException("cordialStock");
        }

        /// <summary>
        /// Executes the strategy logic in charge of regenerating GP after the gather.
        /// </summary>
        /// <returns></returns>
        public async Task<GpRegenStrategyResult> RegenerateGp(GatheringPointObject node, IGatheringRotation gatherRotation, GatherStrategy gatherStrategy, CordialTime cordialTime, CordialType cordialType)
        {
            var rtn = new GpRegenStrategyResult()
            {
                StrategyState = GpRegenStrategyResult.GpRegenStrategyResultState.OK,
                EffectiveCordialType = cordialType,
                OriginalCordialType = cordialType,
            };

            var useCordial = cordialTime.HasFlag(CordialTime.AfterGather)
                && this.cordialStock.HasStock()
                && this.cordialStock.GetCordialCooldown() == TimeSpan.Zero;

            var missingGp = ExProfileBehavior.Me.MaxGP - ExProfileBehavior.Me.CurrentGP;
            var cordial = this.cordialStock.GetBestCordial(missingGp, cordialType);

            // Return OK if there is no cordial to use
            if (cordial == null)
            {
                rtn.UseState = InventoryItem.UseResult.OK;
                return rtn;
            }

            // Use the cordial
            rtn.UseState = await cordial.Use(
                ExProfileBehavior.Me
            );

            return rtn;
        }
    }
}

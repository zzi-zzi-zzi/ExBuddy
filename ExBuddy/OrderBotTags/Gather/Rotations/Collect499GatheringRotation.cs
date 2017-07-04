namespace ExBuddy.OrderBotTags.Gather.Rotations
{
	using ExBuddy.Attributes;
	using ExBuddy.Interfaces;
	using ff14bot;
	using ff14bot.Managers;
	using System.Threading.Tasks;

	[GatheringRotation("Ditto499", 28, 600)]
	public sealed class Collect499GatheringRotation : CollectableGatheringRotation, IGetOverridePriority
	{
		#region IGetOverridePriority Members

		int IGetOverridePriority.GetOverridePriority(ExGatherTag tag)
		{
			// if we have a collectable && the collectable value is greater than or equal to 495: Priority 499
			if (tag.CollectableItem != null && tag.CollectableItem.Value >= 499)
			{
				return 499;
			}

			return -1;
		}

		#endregion IGetOverridePriority Members

		public override async Task<bool> ExecuteRotation(ExGatherTag tag)
		{
			if (tag.IsUnspoiled())
			{
				await DiscerningMethodical(tag);
				await Discerning(tag);
				await AppraiseAndRebuff(tag);
				await Methodical(tag);
				await IncreaseChance(tag);
			}
			else
			{
				if (Core.Player.CurrentGP >= 600)
				{
					if (GatheringManager.SwingsRemaining > 4)
					{
						await DiscerningMethodical(tag);
						await Discerning(tag);
						await AppraiseAndRebuff(tag);
						await Methodical(tag);
						await IncreaseChance(tag);
					}
					else
					{
						await Methodical(tag);
						await Methodical(tag);
						await Methodical(tag);
						await Methodical(tag);
					}
				}

				await Impulsive(tag);
				await Impulsive(tag);
				await Methodical(tag);
			}
			return true;
		}
	}
}
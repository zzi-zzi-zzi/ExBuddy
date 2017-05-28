namespace ExBuddy.OrderBotTags.Gather.Rotations
{
	using ExBuddy.Attributes;
	using ExBuddy.Interfaces;
	using System.Threading.Tasks;

	[GatheringRotation("Collect480", 31, 600, 400)]
	public sealed class Collect480GatheringRotation : CollectableGatheringRotation, IGetOverridePriority
	{
		#region IGetOverridePriority Members

		int IGetOverridePriority.GetOverridePriority(ExGatherTag tag)
		{
			// if we have a collectable && the collectable value is greater than or equal to 480: Priority 480
			if (tag.CollectableItem != null && tag.CollectableItem.Value >= 480)
			{
				return 480;
			}

			return -1;
		}

		#endregion IGetOverridePriority Members

		public override async Task<bool> ExecuteRotation(ExGatherTag tag)
		{
			await UtmostSingleMindImpulsive(tag);

			if (HasDiscerningEye)
			{
				await Methodical(tag);
				await Impulsive(tag);
				await UtmostSingleMindMethodical(tag);
			}
			else
			{
				await Impulsive(tag);

				if (HasDiscerningEye)
				{
					await Methodical(tag);
					await UtmostSingleMindMethodical(tag);
				}
				else
				{
					await Impulsive(tag);

					if (HasDiscerningEye)
					{
						await UtmostSingleMindMethodical(tag);
					}
					else
					{
						await UtmostDiscerningMethodical(tag);
					}
				}
			}
			await IncreaseChance(tag);

			return true;
		}
	}
}
#pragma warning disable 1998

namespace ExBuddy.OrderBotTags.Gather.GatherSpots
{
    using Clio.Utilities;
	using Clio.XmlEngine;
	using ExBuddy.Helpers;
	using ExBuddy.Interfaces;
	using System.ComponentModel;
    using System.Threading.Tasks;
    using ff14bot.Managers;

    [XmlElement("GatherSpot")]
	public class GatherSpot : IGatherSpot
	{
		[DefaultValue(true)]
		[XmlAttribute("UseMesh")]
		public bool UseMesh { get; set; }

		public override string ToString()
		{
			return this.DynamicToString();
		}

		#region IGatherSpot Members

		[XmlAttribute("NodeLocation")]
		public Vector3 NodeLocation { get; set; }

		public virtual async Task<bool> MoveFromSpot(ExGatherTag tag)
		{
			tag.StatusText = "Moving from " + this;

			return true;
		}

		public virtual async Task<bool> MoveToSpot(ExGatherTag tag)
		{
		    tag.StatusText = "Moving to " + this;

		    Vector3 randomApproachLocation;
		    if (MovementManager.IsFlying || MovementManager.IsDiving)
            {
		        randomApproachLocation = NodeLocation.AddRandomDirection(3.0f, SphereType.TopHalf);
		    }
		    else
		    {
		        randomApproachLocation = NodeLocation.AddRandomDirection2D(3.0f);
		    }

		    var result = await
		        randomApproachLocation.MoveTo(
		            UseMesh,
		            radius: tag.Distance,
		            name: tag.Node.EnglishName,
		            stopCallback: tag.MovementStopCallback);

            if (!result) return false;

		    result =
				await
					NodeLocation.MoveTo(
						UseMesh,
						radius: tag.Distance,
						name: tag.Node.EnglishName,
						stopCallback: tag.MovementStopCallback);

		    return result;
		}

		#endregion IGatherSpot Members
	}
}
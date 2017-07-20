namespace ExBuddy.OrderBotTags.Behaviors.Objects
{
	public enum ShopType
	{
#if RB_CN
#else
#endif
#if RB_CN
		BlueCrafter,

		RedCrafter,

		BlueGatherer,

		RedGatherer
#else
		RedCrafter50,

		RedCrafter61,

		YellowCrafter,

		YellowCrafterItems,

		RedGatherer50,

		RedGatherer61,

		YellowGatherer,

		YellowGathererItems
#endif
	}
}
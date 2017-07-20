namespace ExBuddy.OrderBotTags.Behaviors.Objects
{
	public enum ShopItem
	{
#if RB_CN

		#region BlueCrafter

        BlueCrafterToken = 0,

		CommercialEngineeringManual = 1,

		SweetCreamMilk = 2,

		StoneCheese = 3,

		HeavensEgg = 4,

		CarbonFiber = 5,

		LoaghtanFilet = 6,

		GoldenApple = 7,

		SolsticeGarlic = 8,

		MatureOliveOil = 9,

		PowderedMermanHorn = 10,

		BouillonCube = 11,

		BeanSauce = 12,

		BeanPaste = 13,

		KukuruPowder = 14,

		AdeptsHat = 15,

		AdeptsGown = 16,

		AdeptsGloves = 17,

		AdeptsHose = 18,

		AdeptsThighboots = 19,

		CrpDelineation = 20,

		BsmDelineation = 21,

		ArmDelineation = 22,

		GsmDelineation = 23,

		LtwDelineation = 24,

		WvrDelineation = 25,

		AlcDelineation = 26,

		CulDelineation = 27,

		#endregion BlueCrafter

		#region RedCrafter

		SoulOfTheCrafter = -100,

		RedCrafterToken = -99,

		GoblinCup = -98,

		CompetenceIV = -97,

		CunningIV = -96,

		CommandIV = -95,

		CompetenceV = -94,

		CunningV = -93,

		CommandV = -92,

		#endregion RedCrafter

		#region BlueGatherer

		BlueGatherToken = -200,

		BlueToken = BlueGatherToken,

		HiCordial = -199,

		CommercialSurvivalManual = -198,

		TrailblazersScarf = -197,

		TrailblazersVest = -196,

		TrailblazersWristguards = -195,

		TrailblazersSlops = -194,

		TrailblazersShoes = -193,

		BruteLeech = -192,

		CraneFly = -191,

		FiendWorm = -190,

		MagmaWorm = -189,

		RedBalloon = -188,

		CrownTrout = -187,

		CrownTroutHQ = -186,

		RetributionStaff = -185,

		RetributionStaffHQ = -184,

		ThiefBetta = -183,

		ThiefBettaHQ = -182,

		GoldsmithCrab = -181,

		GoldsmithCrabHQ = -180,

		Pterodactyl = -179,

		PterodactylHQ = -178,

		Eurhinosaur = -177,

		EurhinosaurHQ = -176,

		GemMarimo = -175,

		GemMarimoHQ = -174,

		Sphalerite = -173,

		SphaleriteHQ = -172,

		WindSilk = -171,

		CloudCottonBoll = -170,

		CloudCottonBollHQ = -169,

		DinosaurLeather = -168,

		RoyalMistletoe = -167,

		RoyalMistletoeHQ = -166,

		#endregion BlueGatherer

		#region RedGatherer

		RedGatherToken = -300,

		GoblinDice = -299,

		GuerdonIV = -298,

		GuileIV = -297,

		GraspIV = -296,

		GuerdonV = -295,

		GuileV = -294,

		GraspV = -293

		#endregion RedGatherer

#else

		#region RedCrafter50

		SoulOfTheCrafter = 0,

		CommercialEngineeringManual = 1,

		CrpDelineation = 2,

		BsmDelineation = 3,

		ArmDelineation = 4,

		GsmDelineation = 5,

		LtwDelineation = 6,

		WvrDelineation = 7,

		AlcDelineation = 8,

		CulDelineation = 9,

		CompetenceIV = 10,

		CompetenceV = 11,

		CunningIV = 12,

		CunningV = 13,

		CommandIV = 14,

		CommandV = 15,

		#endregion RedCrafter50

		#region RedCrafter61

		DomanIronHalfheartSaw = 100,

		DomanIronClawHammer = 101,

		DomanIronLumpHammer = 102,

		DomanIronFile = 103,

		DomanIronRaisingHammer = 104,

		DomanIronPliers = 105,

		DuriumTextureHammer = 106,

		SlateGrindingWheel = 107,

		DomanIronHeadKnife = 108,

		DomanIronAwl = 109,

		DzoHornNeedle = 110,

		PineSpinningWheel = 111,

		DomanIronAlembic = 112,

		DomanIronMortar = 113,

		DomanIronFrypan = 114,

		DomanIronCulinaryKnife = 115,

		KudzuCapofCrafting = 116,

		KudzuRobeofCrafting = 117,

		DuriumChaplets = 118,

		KudzuCulottesofCrafting = 119,

		TigerskinBootsofCrafting = 120,

		MasterCarpenterV = 121,

		MasterBlacksmithV = 122,

		MasterArmorerV = 123,

		MasterGoldsmithV = 124,

		MasterLeatherworkerV = 125,

		MasterWeaverV = 126,

		MasterAlchemistV = 127,

		MasterCulinarianV = 128,

		#endregion RedCrafter61

		#region YellowGathererItems

		KoshuPork = 200,

		TeaBrick = 201,

		#endregion YellowGathererItems

		#region RedGatherer50

		HiCordial = 300,

		CommercialSurvivalManual = 301,

		GiantCraneFly = 302,

		BruteLeech = 303,

		FiendWorm = 304,

		MagmaWorm = 305,

		RedBalloon = 306,

		GuerdonIV = 307,

		GuerdonV = 308,

		GuileIV = 309,

		GuileV = 310,

		GraspIV = 311,

		GraspV = 312,

		#endregion RedGatherer50

		#region RedGatherer61

		FolkloreGatherToken = 400,

		DomanIronPickaxe = 401,

		DomanIronSledgehammer = 402,

		DomanIronHatchet = 403,

		DomanIronScythe = 404,

		PineFishingRod = 405,

		TigerskinCapofGathering = 406,

		KudzuCoatofGathering = 407,

		TigerskinFingerlessGlovesofGathering = 408,

		KudzuCulottesofGathering = 409,

		TigerskinBootsofGathering = 410,

		SuspendingMinnow = 411,

		BreamLure = 412,

		Silkworm = 413,

		#endregion RedGatherer61

		#region YellowGathererItems

		BlueBobbit = 500,

		StoneflyLarva = 501

		#endregion YellowGathererItems

#endif
	}
}
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

		#endregion RedCrafter61

		#region RedGatherer50

		HiCordial = 200,

		CommercialSurvivalManual = 201,

		GiantCraneFly = 202,

		BruteLeech = 203,

		FiendWorm = 204,

		MagmaWorm = 205,

		RedBalloon = 206,

		GuerdonIV = 207,

		GuerdonV = 208,

		GuileIV = 209,

		GuileV = 210,

		GraspIV = 211,

		GraspV = 212,

		#endregion RedGatherer50

		#region RedGatherer61

		FolkloreGatherToken = 300,

		DomanIronPickaxe = 301,

		DomanIronSledgehammer = 302,

		DomanIronHatchet = 303,

		DomanIronScythe = 304,

		PineFishingRod = 305,

		TigerskinCapofGathering = 306,

		KudzuCoatofGathering = 307,

		TigerskinFingerlessGlovesofGathering = 308,

		KudzuCulottesofGathering = 309,

		TigerskinBootsofGathering = 310,

		SuspendingMinnow = 311,

		BreamLure = 312,

		Silkworm = 313,

		#endregion RedGatherer61

		#region YellowGathererItems

		BlueBobbit = 400,

		StoneflyLarva = 401

		#endregion YellowGathererItems

#endif
	}
}
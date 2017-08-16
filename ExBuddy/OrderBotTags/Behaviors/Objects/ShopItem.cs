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

        #region RedCrafter58

        BlueCrafterToken = 100,

        GoblinCup = 101,

        SweetCreamMilk = 102,

        SweetCreamMilkHq = 103,

        StoneCheese = 104,

        StoneCheeseHq = 105,

        HeavensEgg = 106,

        HeavensEggHq = 107,

        CarbonFiber = 108,

        CarbonFiberHq = 109,

        LoaghtanFilet = 110,

        LoaghtanFiletHq = 111,

        GoldenApple = 112,

        GoldenAppleHq = 113,

        SolsticeGarlic = 114,

        SolsticeGarlicHq = 115,

        MatureOliveOil = 116,

        MatureOliveOilHq = 117,

        PowderedMermanHorn = 118,

        PowderedMermanHornHq = 119,

        BouillonCube = 120,

        BouillonCubeHq = 121,

        OrientalSoySauce = 122,

        OrientalSoySauceHq = 123,

        OrientalMisoPaste = 124,

        OrientalMisoPasteHq = 125,

        HeavenlyKukuruPowder = 126,

        HeavenlyKukuruPowderHq = 127,

        AdeptsHat = 128,

        AdeptsGown = 129,

        AdeptsGloves = 130,

        AdeptsHose = 131,

        AdeptsThighboots = 132,

        #endregion RedCrafter58

        #region RedCrafter61

        DomanIronHalfheartSaw = 200,

        DomanIronClawHammer = 201,

        DomanIronLumpHammer = 202,

        DomanIronFile = 203,

        DomanIronRaisingHammer = 204,

        DomanIronPliers = 205,

        DuriumTextureHammer = 206,

        SlateGrindingWheel = 207,

        DomanIronHeadKnife = 208,

        DomanIronAwl = 209,

        DzoHornNeedle = 210,

        PineSpinningWheel = 211,

        DomanIronAlembic = 212,

        DomanIronMortar = 213,

        DomanIronFrypan = 214,

        DomanIronCulinaryKnife = 215,

        KudzuCapofCrafting = 216,

        KudzuRobeofCrafting = 217,

        DuriumChaplets = 218,

        KudzuCulottesofCrafting = 219,

        TigerskinBootsofCrafting = 220,

        #endregion RedCrafter61

        #region YellowCrafterItems

        KoshuPork = 300,

        TeaBrick = 301,

        #endregion YellowCrafterItems

        #region RedGatherer50

        HiCordial = 400,

        CommercialSurvivalManual = 401,

        GiantCraneFly = 402,

        BruteLeech = 403,

        FiendWorm = 404,

        MagmaWorm = 405,

        RedBalloon = 406,

        GuerdonIV = 407,

        GuerdonV = 408,

        GuileIV = 409,

        GuileV = 410,

        GraspIV = 411,

        GraspV = 412,

        #endregion RedGatherer50

        #region RedGatherer58

        BlueGatherToken = 500,

        GoblinDice = 501,

        TrailblazersScarf = 502,

        TrailblazersVest = 503,

        TrailblazersWristguards = 504,

        TrailblazersSlops = 505,

        TrailblazersShoes = 506,

        CrownTrout = 507,

        CrownTroutHq = 508,

        RetributionStaff = 509,

        RetributionStaffHq = 510,

        ThiefBetta = 511,

        ThiefBettaHq = 512,

        GoldsmithCrab = 513,

        GoldsmithCrabHq = 514,

        Pterodactyl = 515,

        PterodactylHq = 516,

        Eurhinosaur = 517,

        EurhinosaurHq = 518,

        GemMarimo = 519,

        GemMarimoHq = 520,

        Sphalerite = 521,

        SphaleriteHq = 522,

        WindSilk = 523,

        CloudCottonBoll = 524,

        CloudCottonBollHq = 525,

        DinosaurLeather = 526,

        RoyalMistletoe = 527,

        RoyalMistletoeHq = 528,

        #endregion RedGatherer58

        #region RedGatherer61

        FolkloreGatherToken = 600,

        DomanIronPickaxe = 601,

        DomanIronSledgehammer = 602,

        DomanIronHatchet = 603,

        DomanIronScythe = 604,

        PineFishingRod = 605,

        TigerskinCapofGathering = 606,

        KudzuCoatofGathering = 607,

        TigerskinFingerlessGlovesofGathering = 608,

        KudzuCulottesofGathering = 609,

        TigerskinBootsofGathering = 610,

        SuspendingMinnow = 611,

        BreamLure = 612,

        Silkworm = 613,

        #endregion RedGatherer61

        #region YellowGathererItems

        BlueBobbit = 700,

        StoneflyLarva = 701

        #endregion YellowGathererItems

#endif
    }
}
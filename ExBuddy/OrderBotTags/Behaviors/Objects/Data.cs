namespace ExBuddy.OrderBotTags.Behaviors.Objects
{
	using Clio.Utilities;
	using ExBuddy.GameObjects.Npcs;
	using ExBuddy.Interfaces;
	using System.Collections.Generic;
	using System.Linq;

	internal static class Data
	{
#if RB_CN
		public static readonly Dictionary<Locations, IList<INpc>> NpcMap = new Dictionary<Locations, IList<INpc>>
		{
			{
				Locations.MorDhona,
				new INpc[]
				{
					new MasterPieceSupply
					{
						AetheryteId = 24,
						ZoneId = 156,
						Location = new Vector3("50.33948, 31.13618, -737.4532"),
						NpcId = 1013396
					},
					new ShopExchangeCurrency
					{
						AetheryteId = 24,
						ZoneId = 156,
						Location = new Vector3("47.34875, 31.15659, -737.4838"),
						NpcId = 1013397
					}
				}
			},
			{
				Locations.Idyllshire,
				new INpc[]
				{
					new MasterPieceSupply
					{
						AetheryteId = 75,
						ZoneId = 478,
						Location = new Vector3("-18.29561, 206.5211, 45.12088"),
						NpcId = 1012300
					},
					new ShopExchangeCurrency
					{
						AetheryteId = 75,
						ZoneId = 478,
						Location = new Vector3("-20.6455, 206.5211, 47.25714"),
						NpcId = 1012301
					}
				}
			},
			{
				Locations.LimsaLominsaLowerDecks,
				new INpc[]
				{
					new FreeCompanyChest
					{
						AetheryteId = 8,
						ZoneId = 129,
						Location = new Vector3("-200, 17.04425, 58.76245"),
						NpcId = 2000470,
						Name = "Company Chest"
					}
				}
			},
			{
				Locations.UldahStepsOfNald,
				new INpc[]
				{
					new FreeCompanyChest
					{
						AetheryteId = 9,
						ZoneId = 130,
						Location = new Vector3("-149.3096, 4.53186, -91.38635"),
						NpcId = 2000470,
						Name = "Company Chest"
					}
				}
			}
		};
#else

		public static readonly Dictionary<Locations, IList<INpc>> NpcMap = new Dictionary<Locations, IList<INpc>>
		{
			{
				Locations.LimsaLominsaLowerDecks,
				new INpc[]
				{
					new FreeCompanyChest
					{
						AetheryteId = 8,
						ZoneId = 129,
						Location = new Vector3("-200, 17.04425, 58.76245"),
						NpcId = 2000470,
						Name = "Company Chest"
					}
				}
			},
			{
				Locations.UldahStepsOfNald,
				new INpc[]
				{
					new FreeCompanyChest
					{
						AetheryteId = 9,
						ZoneId = 130,
						Location = new Vector3("-149.3096, 4.53186, -91.38635"),
						NpcId = 2000470,
						Name = "Company Chest"
					}
				}
			},
			{
				Locations.RhalgrsReach,
				new INpc[]
				{
					new MasterPieceSupply
					{
						AetheryteId = 104,
						ZoneId = 635,
						Location = new Vector3("-67.64739, 0.00999999, 63.51791"),
						NpcId = 1019457
					},
					new ShopExchangeCurrency
					{
						AetheryteId = 104,
						ZoneId = 635,
						Location = new Vector3("-67.64739, 0.00999999, 63.51791"),
						NpcId = 1019458
					}
				}
			}
		};

#endif

		public static readonly Dictionary<ShopItem, ShopItemInfo> ShopItemMap = new Dictionary<ShopItem, ShopItemInfo>
		{
#if RB_CN

			#region BlueCrafter

        {
			ShopItem.BlueCrafterToken,
			new ShopItemInfo
			{
				Index = (int) ShopItem.BlueCrafterToken,
				ShopType = ShopType.BlueCrafter,
				ItemId = 12839,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.CommercialEngineeringManual,
			new ShopItemInfo
			{
				Index = (int) ShopItem.CommercialEngineeringManual,
				ShopType = ShopType.BlueCrafter,
				ItemId = 12667,
				Cost = 45,
				Yield = 1
			}
		},
		{
			ShopItem.SweetCreamMilk,
			new ShopItemInfo
			{
				Index = (int) ShopItem.SweetCreamMilk,
				ShopType = ShopType.BlueCrafter,
				ItemId = 16734,
				Cost = 16,
				Yield = 1
			}
		},
		{
			ShopItem.StoneCheese,
			new ShopItemInfo
			{
				Index = (int) ShopItem.StoneCheese,
				ShopType = ShopType.BlueCrafter,
				ItemId = 16735,
				Cost = 16,
				Yield = 1
			}
		},
		{
			ShopItem.HeavensEgg,
			new ShopItemInfo
			{
				Index = (int) ShopItem.HeavensEgg,
				ShopType = ShopType.BlueCrafter,
				ItemId = 15652,
				Cost = 16,
				Yield = 1
			}
		},
		{
			ShopItem.CarbonFiber,
			new ShopItemInfo
			{
				Index = (int) ShopItem.CarbonFiber,
				ShopType = ShopType.BlueCrafter,
				ItemId = 5339,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.LoaghtanFilet,
			new ShopItemInfo
			{
				Index = (int) ShopItem.LoaghtanFilet,
				ShopType = ShopType.BlueCrafter,
				ItemId = 14145,
				Cost = 10,
				Yield = 1
			}
		},
		{
			ShopItem.GoldenApple,
			new ShopItemInfo
			{
				Index = (int) ShopItem.GoldenApple,
				ShopType = ShopType.BlueCrafter,
				ItemId = 14142,
				Cost = 10,
				Yield = 1
			}
		},
		{
			ShopItem.SolsticeGarlic,
			new ShopItemInfo
			{
				Index = (int) ShopItem.SolsticeGarlic,
				ShopType = ShopType.BlueCrafter,
				ItemId = 14143,
				Cost = 10,
				Yield = 1
			}
		},
		{
			ShopItem.MatureOliveOil,
			new ShopItemInfo
			{
				Index = (int) ShopItem.MatureOliveOil,
				ShopType = ShopType.BlueCrafter,
				ItemId = 14144,
				Cost = 10,
				Yield = 1
			}
		},
		{
			ShopItem.PowderedMermanHorn,
			new ShopItemInfo
			{
				Index = (int) ShopItem.PowderedMermanHorn,
				ShopType = ShopType.BlueCrafter,
				ItemId = 14937,
				Cost = 12,
				Yield = 1
			}
		},
		{
			ShopItem.BouillonCube,
			new ShopItemInfo
			{
				Index = (int) ShopItem.BouillonCube,
				ShopType = ShopType.BlueCrafter,
				ItemId = 12905,
				Cost = 8,
				Yield = 1
			}
		},
		{
			ShopItem.BeanSauce,
			new ShopItemInfo
			{
				Index = (int) ShopItem.BeanSauce,
				ShopType = ShopType.BlueCrafter,
				ItemId = 12906,
				Cost = 30,
				Yield = 1
			}
		},
		{
			ShopItem.BeanPaste,
			new ShopItemInfo
			{
				Index = (int) ShopItem.BeanPaste,
				ShopType = ShopType.BlueCrafter,
				ItemId = 12907,
				Cost = 30,
				Yield = 1
			}
		},
		{
			ShopItem.KukuruPowder,
			new ShopItemInfo
			{
				Index = (int) ShopItem.KukuruPowder,
				ShopType = ShopType.BlueCrafter,
				ItemId = 12886,
				Cost = 16,
				Yield = 1
			}
		},
		{
			ShopItem.AdeptsHat,
			new ShopItemInfo
			{
				Index = (int) ShopItem.AdeptsHat,
				ShopType = ShopType.BlueCrafter,
				ItemId = 11958,
				Cost = 120,
				Yield = 1
			}
		},
		{
			ShopItem.AdeptsGown,
			new ShopItemInfo
			{
				Index = (int) ShopItem.AdeptsGown,
				ShopType = ShopType.BlueCrafter,
				ItemId = 11963,
				Cost = 270,
				Yield = 1
			}
		},
		{
			ShopItem.AdeptsGloves,
			new ShopItemInfo
			{
				Index = (int) ShopItem.AdeptsGloves,
				ShopType = ShopType.BlueCrafter,
				ItemId = 11968,
				Cost = 120,
				Yield = 1
			}
		},
		{
			ShopItem.AdeptsHose,
			new ShopItemInfo
			{
				Index = (int) ShopItem.AdeptsHose,
				ShopType = ShopType.BlueCrafter,
				ItemId = 11976,
				Cost = 105,
				Yield = 1
			}
		},
		{
			ShopItem.AdeptsThighboots,
			new ShopItemInfo
			{
				Index = (int) ShopItem.AdeptsThighboots,
				ShopType = ShopType.BlueCrafter,
				ItemId = 11981,
				Cost = 105,
				Yield = 1
			}
		},
		{
			ShopItem.CrpDelineation,
			new ShopItemInfo
			{
				Index = (int) ShopItem.CrpDelineation,
				ShopType = ShopType.BlueCrafter,
				ItemId = 12659,
				Cost = 25,
				Yield = 1
			}
		},
		{
			ShopItem.BsmDelineation,
			new ShopItemInfo
			{
				Index = (int) ShopItem.BsmDelineation,
				ShopType = ShopType.BlueCrafter,
				ItemId = 12660,
				Cost = 25,
				Yield = 1
			}
		},
		{
			ShopItem.ArmDelineation,
			new ShopItemInfo
			{
				Index = (int) ShopItem.ArmDelineation,
				ShopType = ShopType.BlueCrafter,
				ItemId = 12661,
				Cost = 25,
				Yield = 1
			}
		},
		{
			ShopItem.GsmDelineation,
			new ShopItemInfo
			{
				Index = (int) ShopItem.GsmDelineation,
				ShopType = ShopType.BlueCrafter,
				ItemId = 12662,
				Cost = 25,
				Yield = 1
			}
		},
		{
			ShopItem.LtwDelineation,
			new ShopItemInfo
			{
				Index = (int) ShopItem.LtwDelineation,
				ShopType = ShopType.BlueCrafter,
				ItemId = 12663,
				Cost = 25,
				Yield = 1
			}
		},
		{
			ShopItem.WvrDelineation,
			new ShopItemInfo
			{
				Index = (int) ShopItem.WvrDelineation,
				ShopType = ShopType.BlueCrafter,
				ItemId = 12664,
				Cost = 25,
				Yield = 1
			}
		},
		{
			ShopItem.AlcDelineation,
			new ShopItemInfo
			{
				Index = (int) ShopItem.AlcDelineation,
				ShopType = ShopType.BlueCrafter,
				ItemId = 12665,
				Cost = 25,
				Yield = 1
			}
		},
		{
			ShopItem.CulDelineation,
			new ShopItemInfo
			{
				Index = (int) ShopItem.CulDelineation,
				ShopType = ShopType.BlueCrafter,
				ItemId = 12666,
				Cost = 25,
				Yield = 1
			}
		},

			#endregion BlueCrafter

			#region RedCrafter

        {
			ShopItem.SoulOfTheCrafter,
			new ShopItemInfo
			{
				Index = 100 + (int) ShopItem.SoulOfTheCrafter,
				ShopType = ShopType.RedCrafter,
				ItemId = 10336,
				Cost = 480,
				Yield = 1
			}
		},
		{
			ShopItem.RedCrafterToken,
			new ShopItemInfo
			{
				Index = 100 + (int) ShopItem.RedCrafterToken,
				ShopType = ShopType.RedCrafter,
				ItemId = 12838,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.GoblinCup,
			new ShopItemInfo
			{
				Index = 100 + (int) ShopItem.GoblinCup,
				ShopType = ShopType.RedCrafter,
				ItemId = 14104,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.CompetenceIV,
			new ShopItemInfo
			{
				Index = 100 + (int) ShopItem.CompetenceIV,
				ShopType = ShopType.RedCrafter,
				ItemId = 5702,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.CunningIV,
			new ShopItemInfo
			{
				Index = 100 + (int) ShopItem.CunningIV,
				ShopType = ShopType.RedCrafter,
				ItemId = 5707,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.CommandIV,
			new ShopItemInfo
			{
				Index = 100 + (int) ShopItem.CommandIV,
				ShopType = ShopType.RedCrafter,
				ItemId = 5712,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.CompetenceV,
			new ShopItemInfo
			{
				Index = 100 + (int) ShopItem.CompetenceV,
				ShopType = ShopType.RedCrafter,
				ItemId = 5703,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.CunningV,
			new ShopItemInfo
			{
				Index = 100 + (int) ShopItem.CunningV,
				ShopType = ShopType.RedCrafter,
				ItemId = 5708,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.CommandV,
			new ShopItemInfo
			{
				Index = 100 + (int) ShopItem.CommandV,
				ShopType = ShopType.RedCrafter,
				ItemId = 5713,
				Cost = 400,
				Yield = 1
			}
		},

			#endregion RedCrafter

			#region BlueGatherer

        {
			ShopItem.BlueGatherToken,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.BlueGatherToken,
				ShopType = ShopType.BlueGatherer,
				ItemId = 12841,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.HiCordial,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.HiCordial,
				ShopType = ShopType.BlueGatherer,
				ItemId = 12669,
				Cost = 33,
				Yield = 1
			}
		},
		{
			ShopItem.CommercialSurvivalManual,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.CommercialSurvivalManual,
				ShopType = ShopType.BlueGatherer,
				ItemId = 12668,
				Cost = 75,
				Yield = 1
			}
		},
		{
			ShopItem.TrailblazersScarf,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.TrailblazersScarf,
				ShopType = ShopType.BlueGatherer,
				ItemId = 11986,
				Cost = 200,
				Yield = 1
			}
		},
		{
			ShopItem.TrailblazersVest,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.TrailblazersVest,
				ShopType = ShopType.BlueGatherer,
				ItemId = 11991,
				Cost = 270,
				Yield = 1
			}
		},
		{
			ShopItem.TrailblazersWristguards,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.TrailblazersWristguards,
				ShopType = ShopType.BlueGatherer,
				ItemId = 11996,
				Cost = 150,
				Yield = 1
			}
		},
		{
			ShopItem.TrailblazersSlops,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.TrailblazersSlops,
				ShopType = ShopType.BlueGatherer,
				ItemId = 12004,
				Cost = 100,
				Yield = 1
			}
		},
		{
			ShopItem.TrailblazersShoes,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.TrailblazersShoes,
				ShopType = ShopType.BlueGatherer,
				ItemId = 12009,
				Cost = 100,
				Yield = 1
			}
		},
		{
			ShopItem.BruteLeech,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.BruteLeech,
				ShopType = ShopType.BlueGatherer,
				ItemId = 12711,
				Cost = 1,
				Yield = 1
			}
		},
		{
			ShopItem.CraneFly,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.CraneFly,
				ShopType = ShopType.BlueGatherer,
				ItemId = 12712,
				Cost = 1,
				Yield = 1
			}
		},
		{
			ShopItem.FiendWorm,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.FiendWorm,
				ShopType = ShopType.BlueGatherer,
				ItemId = 12710,
				Cost = 1,
				Yield = 1
			}
		},
		{
			ShopItem.MagmaWorm,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.MagmaWorm,
				ShopType = ShopType.BlueGatherer,
				ItemId = 12709,
				Cost = 1,
				Yield = 1
			}
		},
		{
			ShopItem.RedBalloon,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.RedBalloon,
				ShopType = ShopType.BlueGatherer,
				ItemId = 12708,
				Cost = 1,
				Yield = 1
			}
		},
		{
			ShopItem.CrownTrout,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.CrownTrout,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13737,
				Cost = 10,
				Yield = 1
			}
		},
		{
			ShopItem.CrownTroutHQ,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.CrownTroutHQ,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13737,
				Cost = 25,
				Yield = 1
			}
		},
		{
			ShopItem.RetributionStaff,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.RetributionStaff,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13738,
				Cost = 20,
				Yield = 1
			}
		},
		{
			ShopItem.RetributionStaffHQ,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.RetributionStaffHQ,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13738,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.ThiefBetta,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.ThiefBetta,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13739,
				Cost = 10,
				Yield = 1
			}
		},
		{
			ShopItem.ThiefBettaHQ,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.ThiefBettaHQ,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13739,
				Cost = 25,
				Yield = 1
			}
		},
		{
			ShopItem.GoldsmithCrab,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.GoldsmithCrab,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13740,
				Cost = 10,
				Yield = 1
			}
		},
		{
			ShopItem.GoldsmithCrabHQ,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.GoldsmithCrabHQ,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13740,
				Cost = 25,
				Yield = 1
			}
		},
		{
			ShopItem.Pterodactyl,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.Pterodactyl,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13733,
				Cost = 40,
				Yield = 1
			}
		},
		{
			ShopItem.PterodactylHQ,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.PterodactylHQ,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13733,
				Cost = 100,
				Yield = 1
			}
		},
		{
			ShopItem.Eurhinosaur,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.Eurhinosaur,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13734,
				Cost = 10,
				Yield = 1
			}
		},
		{
			ShopItem.EurhinosaurHQ,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.EurhinosaurHQ,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13734,
				Cost = 25,
				Yield = 1
			}
		},
		{
			ShopItem.GemMarimo,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.GemMarimo,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13736,
				Cost = 20,
				Yield = 1
			}
		},
		{
			ShopItem.GemMarimoHQ,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.GemMarimoHQ,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13736,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.Sphalerite,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.Sphalerite,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13750,
				Cost = 20,
				Yield = 1
			}
		},
		{
			ShopItem.SphaleriteHQ,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.SphaleriteHQ,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13750,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.WindSilk,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.WindSilk,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13744,
				Cost = 150,
				Yield = 1
			}
		},
		{
			ShopItem.CloudCottonBoll,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.CloudCottonBoll,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13753,
				Cost = 20,
				Yield = 1
			}
		},
		{
			ShopItem.CloudCottonBollHQ,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.CloudCottonBollHQ,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13753,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.DinosaurLeather,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.DinosaurLeather,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13745,
				Cost = 150,
				Yield = 1
			}
		},
		{
			ShopItem.RoyalMistletoe,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.RoyalMistletoe,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13752,
				Cost = 20,
				Yield = 1
			}
		},
		{
			ShopItem.RoyalMistletoeHQ,
			new ShopItemInfo
			{
				Index = 200 + (int) ShopItem.RoyalMistletoeHQ,
				ShopType = ShopType.BlueGatherer,
				ItemId = 13752,
				Cost = 50,
				Yield = 1
			}
		},

			#endregion BlueGatherer

			#region RedGatherer

		{
			ShopItem.RedGatherToken,
			new ShopItemInfo
			{
				Index = 300 + (int) ShopItem.RedGatherToken,
				ShopType = ShopType.RedGatherer,
				ItemId = 12840,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.GoblinDice,
			new ShopItemInfo
			{
				Index = 300 + (int) ShopItem.GoblinDice,
				ShopType = ShopType.RedGatherer,
				ItemId = 14105,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.GuerdonIV,
			new ShopItemInfo
			{
				Index = 300 + (int) ShopItem.GuerdonIV,
				ShopType = ShopType.RedGatherer,
				ItemId = 5687,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.GuileIV,
			new ShopItemInfo
			{
				Index = 300 + (int) ShopItem.GuileIV,
				ShopType = ShopType.RedGatherer,
				ItemId = 5692,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.GraspIV,
			new ShopItemInfo
			{
				Index = 300 + (int) ShopItem.GraspIV,
				ShopType = ShopType.RedGatherer,
				ItemId = 5697,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.GuerdonV,
			new ShopItemInfo
			{
				Index = 300 + (int) ShopItem.GuerdonV,
				ShopType = ShopType.RedGatherer,
				ItemId = 5688,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.GuileV,
			new ShopItemInfo
			{
				Index = 300 + (int) ShopItem.GuileV,
				ShopType = ShopType.RedGatherer,
				ItemId = 5693,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.GraspV,
			new ShopItemInfo
			{
				Index = 300 + (int) ShopItem.GraspV,
				ShopType = ShopType.RedGatherer,
				ItemId = 5698,
				Cost = 400,
				Yield = 1
			}
		}

			#endregion RedGatherer

#else

			#region RedCrafter50

        {
			ShopItem.SoulOfTheCrafter,
			new ShopItemInfo
			{
				Index = (int) ShopItem.SoulOfTheCrafter,
				ShopType = ShopType.RedCrafter50,
				ItemId = 10336,
				Cost = 480,
				Yield = 1
			}
		},
		{
			ShopItem.CommercialEngineeringManual,
			new ShopItemInfo
			{
				Index = (int) ShopItem.CommercialEngineeringManual,
				ShopType = ShopType.RedCrafter50,
				ItemId = 12667,
				Cost = 30,
				Yield = 1
			}
		},
		{
			ShopItem.CrpDelineation,
			new ShopItemInfo
			{
				Index = (int) ShopItem.CrpDelineation,
				ShopType = ShopType.RedCrafter50,
				ItemId = 12659,
				Cost = 15,
				Yield = 1
			}
		},
		{
			ShopItem.BsmDelineation,
			new ShopItemInfo
			{
				Index = (int) ShopItem.BsmDelineation,
				ShopType = ShopType.RedCrafter50,
				ItemId = 12660,
				Cost = 15,
				Yield = 1
			}
		},
		{
			ShopItem.ArmDelineation,
			new ShopItemInfo
			{
				Index = (int) ShopItem.ArmDelineation,
				ShopType = ShopType.RedCrafter50,
				ItemId = 12661,
				Cost = 15,
				Yield = 1
			}
		},
		{
			ShopItem.GsmDelineation,
			new ShopItemInfo
			{
				Index = (int) ShopItem.GsmDelineation,
				ShopType = ShopType.RedCrafter50,
				ItemId = 12662,
				Cost = 15,
				Yield = 1
			}
		},
		{
			ShopItem.LtwDelineation,
			new ShopItemInfo
			{
				Index = (int) ShopItem.LtwDelineation,
				ShopType = ShopType.RedCrafter50,
				ItemId = 12663,
				Cost = 15,
				Yield = 1
			}
		},
		{
			ShopItem.WvrDelineation,
			new ShopItemInfo
			{
				Index = (int) ShopItem.WvrDelineation,
				ShopType = ShopType.RedCrafter50,
				ItemId = 12664,
				Cost = 15,
				Yield = 1
			}
		},
		{
			ShopItem.AlcDelineation,
			new ShopItemInfo
			{
				Index = (int) ShopItem.AlcDelineation,
				ShopType = ShopType.RedCrafter50,
				ItemId = 12665,
				Cost = 15,
				Yield = 1
			}
		},
		{
			ShopItem.CulDelineation,
			new ShopItemInfo
			{
				Index = (int) ShopItem.CulDelineation,
				ShopType = ShopType.RedCrafter50,
				ItemId = 12666,
				Cost = 15,
				Yield = 1
			}
		},
		{
			ShopItem.CompetenceIV,
			new ShopItemInfo
			{
				Index = (int) ShopItem.CompetenceIV,
				ShopType = ShopType.RedCrafter50,
				ItemId = 5702,
				Cost = 25,
				Yield = 1
			}
		},
		{
			ShopItem.CompetenceV,
			new ShopItemInfo
			{
				Index = (int) ShopItem.CompetenceV,
				ShopType = ShopType.RedCrafter50,
				ItemId = 5703,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.CunningIV,
			new ShopItemInfo
			{
				Index = (int) ShopItem.CunningIV,
				ShopType = ShopType.RedCrafter50,
				ItemId = 5707,
				Cost = 25,
				Yield = 1
			}
		},
		{
			ShopItem.CunningV,
			new ShopItemInfo
			{
				Index = (int) ShopItem.CunningV,
				ShopType = ShopType.RedCrafter50,
				ItemId = 5708,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.CommandIV,
			new ShopItemInfo
			{
				Index = (int) ShopItem.CommandIV,
				ShopType = ShopType.RedCrafter50,
				ItemId = 5712,
				Cost = 25,
				Yield = 1
			}
		},
		{
			ShopItem.CommandV,
			new ShopItemInfo
			{
				Index = (int) ShopItem.CommandV,
				ShopType = ShopType.RedCrafter50,
				ItemId = 5713,
				Cost = 400,
				Yield = 1
			}
		},

			#endregion RedCrafter50

			#region RedCrafter61

		{
			ShopItem.DomanIronHalfheartSaw,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DomanIronHalfheartSaw - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19527,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.DomanIronClawHammer,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DomanIronClawHammer - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19538,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.DomanIronLumpHammer,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DomanIronLumpHammer - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19528,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.DomanIronFile,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DomanIronFile - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19539,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.DomanIronRaisingHammer,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DomanIronRaisingHammer - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19529,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.DomanIronPliers,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DomanIronPliers - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19540,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.DuriumTextureHammer,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DuriumTextureHammer - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19530,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.SlateGrindingWheel,
			new ShopItemInfo
			{
				Index = (int) ShopItem.SlateGrindingWheel - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19541,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.DomanIronHeadKnife,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DomanIronHeadKnife - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19531,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.DomanIronAwl,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DomanIronAwl - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19542,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.DzoHornNeedle,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DzoHornNeedle - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19532,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.PineSpinningWheel,
			new ShopItemInfo
			{
				Index = (int) ShopItem.PineSpinningWheel - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19543,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.DomanIronAlembic,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DomanIronAlembic - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19533,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.DomanIronMortar,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DomanIronMortar - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19544,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.DomanIronFrypan,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DomanIronFrypan - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19534,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.DomanIronCulinaryKnife,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DomanIronCulinaryKnife - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19545,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.KudzuCapofCrafting,
			new ShopItemInfo
			{
				Index = (int) ShopItem.KudzuCapofCrafting - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19632,
				Cost = 180,
				Yield = 1
			}
		},
		{
			ShopItem.KudzuRobeofCrafting,
			new ShopItemInfo
			{
				Index = (int) ShopItem.KudzuRobeofCrafting - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19633,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.DuriumChaplets,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DuriumChaplets - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19634,
				Cost = 180,
				Yield = 1
			}
		},
		{
			ShopItem.KudzuCulottesofCrafting,
			new ShopItemInfo
			{
				Index = (int) ShopItem.KudzuCulottesofCrafting - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19635,
				Cost = 160,
				Yield = 1
			}
		},
		{
			ShopItem.TigerskinBootsofCrafting,
			new ShopItemInfo
			{
				Index = (int) ShopItem.TigerskinBootsofCrafting - 100,
				ShopType = ShopType.RedCrafter61,
				ItemId = 19636,
				Cost = 160,
				Yield = 1
			}
		},

			#endregion RedCrafter61

		#region YellowGathererItems

		{
			ShopItem.KoshuPork,
			new ShopItemInfo
			{
				Index = (int) ShopItem.KoshuPork - 200,
				ShopType = ShopType.YellowCrafterItems,
				ItemId = 19876,
				Cost = 15,
				Yield = 1
			}
		},
		{
			ShopItem.TeaBrick,
			new ShopItemInfo
			{
				Index = (int) ShopItem.TeaBrick - 200,
				ShopType = ShopType.YellowCrafterItems,
				ItemId = 19840,
				Cost = 15,
				Yield = 1
			}
		},

		#endregion YellowGathererItems

			#region RedGatherer50

		{
			ShopItem.HiCordial,
			new ShopItemInfo
			{
				Index = (int) ShopItem.HiCordial - 300,
				ShopType = ShopType.RedGatherer50,
				ItemId = 12669,
				Cost = 20,
				Yield = 1
			}
		},
		{
			ShopItem.CommercialSurvivalManual,
			new ShopItemInfo
			{
				Index = (int) ShopItem.CommercialSurvivalManual - 300,
				ShopType = ShopType.RedGatherer50,
				ItemId = 12668,
				Cost = 30,
				Yield = 1
			}
		},
		{
			ShopItem.GiantCraneFly,
			new ShopItemInfo
			{
				Index = (int) ShopItem.GiantCraneFly - 300,
				ShopType = ShopType.RedGatherer50,
				ItemId = 12712,
				Cost = 1,
				Yield = 1
			}
		},
		{
			ShopItem.BruteLeech,
			new ShopItemInfo
			{
				Index = (int) ShopItem.BruteLeech - 300,
				ShopType = ShopType.RedGatherer50,
				ItemId = 12711,
				Cost = 1,
				Yield = 1
			}
		},
		{
			ShopItem.FiendWorm,
			new ShopItemInfo
			{
				Index = (int) ShopItem.FiendWorm - 300,
				ShopType = ShopType.RedGatherer50,
				ItemId = 12710,
				Cost = 1,
				Yield = 1
			}
		},
		{
			ShopItem.MagmaWorm,
			new ShopItemInfo
			{
				Index = (int) ShopItem.MagmaWorm - 300,
				ShopType = ShopType.RedGatherer50,
				ItemId = 12709,
				Cost = 1,
				Yield = 1
			}
		},
		{
			ShopItem.RedBalloon,
			new ShopItemInfo
			{
				Index = (int) ShopItem.RedBalloon - 300,
				ShopType = ShopType.RedGatherer50,
				ItemId = 12708,
				Cost = 1,
				Yield = 1
			}
		},
		{
			ShopItem.GuerdonIV,
			new ShopItemInfo
			{
				Index = (int) ShopItem.GuerdonIV - 300,
				ShopType = ShopType.RedGatherer50,
				ItemId = 5687,
				Cost = 25,
				Yield = 1
			}
		},
		{
			ShopItem.GuerdonV,
			new ShopItemInfo
			{
				Index = (int) ShopItem.GuerdonV - 300,
				ShopType = ShopType.RedGatherer50,
				ItemId = 5688,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.GuileIV,
			new ShopItemInfo
			{
				Index = (int) ShopItem.GuileIV - 300,
				ShopType = ShopType.RedGatherer50,
				ItemId = 5692,
				Cost = 25,
				Yield = 1
			}
		},
		{
			ShopItem.GuileV,
			new ShopItemInfo
			{
				Index = (int) ShopItem.GuileV - 300,
				ShopType = ShopType.RedGatherer50,
				ItemId = 5693,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.GraspIV,
			new ShopItemInfo
			{
				Index = (int) ShopItem.GraspIV - 300,
				ShopType = ShopType.RedGatherer50,
				ItemId = 5697,
				Cost = 25,
				Yield = 1
			}
		},
		{
			ShopItem.GraspV,
			new ShopItemInfo
			{
				Index = (int) ShopItem.GraspV - 300,
				ShopType = ShopType.RedGatherer50,
				ItemId = 5698,
				Cost = 400,
				Yield = 1
			}
		},

			#endregion RedGatherer50

			#region RedGatherer61

		{
			ShopItem.FolkloreGatherToken,
			new ShopItemInfo
			{
				Index = (int) ShopItem.FolkloreGatherToken - 400,
				ShopType = ShopType.RedGatherer61,
				ItemId = 20260,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.DomanIronPickaxe,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DomanIronPickaxe - 400,
				ShopType = ShopType.RedGatherer61,
				ItemId = 19535,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.DomanIronSledgehammer,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DomanIronSledgehammer - 400,
				ShopType = ShopType.RedGatherer61,
				ItemId = 19546,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.DomanIronHatchet,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DomanIronHatchet - 400,
				ShopType = ShopType.RedGatherer61,
				ItemId = 19536,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.DomanIronScythe,
			new ShopItemInfo
			{
				Index = (int) ShopItem.DomanIronScythe - 400,
				ShopType = ShopType.RedGatherer61,
				ItemId = 19547,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.PineFishingRod,
			new ShopItemInfo
			{
				Index = (int) ShopItem.PineFishingRod - 400,
				ShopType = ShopType.RedGatherer61,
				ItemId = 19537,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.TigerskinCapofGathering,
			new ShopItemInfo
			{
				Index = (int) ShopItem.TigerskinCapofGathering - 400,
				ShopType = ShopType.RedGatherer61,
				ItemId = 19637,
				Cost = 300,
				Yield = 1
			}
		},
		{
			ShopItem.KudzuCoatofGathering,
			new ShopItemInfo
			{
				Index = (int) ShopItem.KudzuCoatofGathering - 400,
				ShopType = ShopType.RedGatherer61,
				ItemId = 19638,
				Cost = 400,
				Yield = 1
			}
		},
		{
			ShopItem.TigerskinFingerlessGlovesofGathering,
			new ShopItemInfo
			{
				Index = (int) ShopItem.TigerskinFingerlessGlovesofGathering - 400,
				ShopType = ShopType.RedGatherer61,
				ItemId = 19639,
				Cost = 200,
				Yield = 1
			}
		},
		{
			ShopItem.KudzuCulottesofGathering,
			new ShopItemInfo
			{
				Index = (int) ShopItem.KudzuCulottesofGathering - 400,
				ShopType = ShopType.RedGatherer61,
				ItemId = 19640,
				Cost = 150,
				Yield = 1
			}
		},
		{
			ShopItem.TigerskinBootsofGathering,
			new ShopItemInfo
			{
				Index = (int) ShopItem.TigerskinBootsofGathering - 400,
				ShopType = ShopType.RedGatherer61,
				ItemId = 19641,
				Cost = 150,
				Yield = 1
			}
		},
		{
			ShopItem.SuspendingMinnow,
			new ShopItemInfo
			{
				Index = (int) ShopItem.SuspendingMinnow - 400,
				ShopType = ShopType.RedGatherer61,
				ItemId = 20619,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.BreamLure,
			new ShopItemInfo
			{
				Index = (int) ShopItem.BreamLure - 400,
				ShopType = ShopType.RedGatherer61,
				ItemId = 20618,
				Cost = 50,
				Yield = 1
			}
		},
		{
			ShopItem.Silkworm,
			new ShopItemInfo
			{
				Index = (int) ShopItem.Silkworm - 400,
				ShopType = ShopType.RedGatherer61,
				ItemId = 20616,
				Cost = 5,
				Yield = 1
			}
		},

			#endregion RedGatherer61

		#region YellowGathererItems

		{
			ShopItem.BlueBobbit,
			new ShopItemInfo
			{
				Index = (int) ShopItem.BlueBobbit - 500,
				ShopType = ShopType.YellowGathererItems,
				ItemId = 20676,
				Cost = 5,
				Yield = 1
			}
		},
		{
			ShopItem.StoneflyLarva,
			new ShopItemInfo
			{
				Index = (int) ShopItem.StoneflyLarva - 500,
				ShopType = ShopType.YellowGathererItems,
				ItemId = 20675,
				Cost = 5,
				Yield = 1
			}
		}

		#endregion YellowGathererItems

#endif
		};

		public static IEnumerable<INpc> GetNpcsByLocation(Locations location)
		{
			IList<INpc> npcs;
			if (NpcMap.TryGetValue(location, out npcs))
			{
				return npcs;
			}

			return Enumerable.Empty<INpc>();
		}

		public static IEnumerable<T> GetNpcsByLocation<T>(Locations location) where T : INpc
		{
			return GetNpcsByLocation(location).OfType<T>();
		}
	}
}
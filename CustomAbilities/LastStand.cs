using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI;
using InscryptionAPI.Card;
using InscryptionAPI.Helpers;
using InscryptionCommunityPatch;

namespace PAScryption.CustomAbilities
{


	class LastStand
    {
		public static DiskCardGame.Ability LastStandAbility;

		public static void RegisterAbility()
        {
			AbilityInfo LastStandAbilityInfo = AbilityManager.New("Lumin.inscryption.Pascryption", "Last Stand",
				"When this creature's health reaches 1, it grows into a stronger form", typeof(LastStandBehaviour), "Sigil_Last_Stand.png")
				.SetDefaultPart1Ability();
			LastStandAbility = LastStandAbilityInfo.ability;
			LastStandBehaviour.ability = LastStandAbility;
        }
	}
	public class LastStandBehaviour : AbilityBehaviour
	{
		public override Ability Ability => ability;

		public static Ability ability;

		public bool EvolveInheritsInfoMods
        {
            get
            {
				return true;
            }
        }

		public float PostTransformWait
        {
			get
            {
				return 0.5f;
            }
        }
		
        public override bool RespondsToOtherCardDealtDamage(PlayableCard attacker, int amount, PlayableCard target)
        {
            return target == base.Card;
        }

		public override IEnumerator OnOtherCardDealtDamage(PlayableCard attacker, int amount, PlayableCard target)
		{
			int losthealth = (base.Card.Info.baseHealth - base.Card.Info.Health) * -1 - amount;
			if (losthealth <= 1) ;
			{
				CardInfo evolution = this.GetTransformCardInfo();
				if (this.EvolveInheritsInfoMods)
                {
					foreach (CardModificationInfo cardModificationInfo in base.Card.Info.Mods.FindAll((CardModificationInfo x)
						=> !x.nonCopyable))
                    {
						CardModificationInfo cardModificationInfo2 = (CardModificationInfo)cardModificationInfo.Clone();
						if (cardModificationInfo2.HasAbility(LastStandBehaviour.ability))
                        {
							evolution.mods.Add(cardModificationInfo2);
                        }
                    }
					yield return base.PreSuccessfulTriggerSequence();
					yield return base.Card.TransformIntoCard(evolution, new Action(this.RemoveTemporaryModsWithEvolve), null);
					yield return new WaitForSeconds(this.PostTransformWait);
					yield return base.LearnAbility(0.5f);
					evolution = null;
                }
				yield break;
			}

		}

		public CardInfo GetTransformCardInfo()
        {
			if (base.Card.Info.evolveParams == null)
            {
				return EvolveParams.GetDefaultEvolution(base.Card.Info);
            }
			return base.Card.Info.evolveParams.evolution.Clone() as CardInfo;
        }

		public void RemoveTemporaryModsWithEvolve()
        {
			if (!base.Card.Info.Abilities.Contains(LastStandBehaviour.ability))
            {
				for (CardModificationInfo temporaryEvolveMod = this.GetTemporaryEvolveMod(); temporaryEvolveMod != null;
					temporaryEvolveMod = this.GetTemporaryEvolveMod())
                {
					base.Card.RemoveTemporaryMod(temporaryEvolveMod, true);
                }
            }
        }

		private CardModificationInfo GetTemporaryEvolveMod()
        {
			return base.Card.TemporaryMods.Find((CardModificationInfo x) => x.abilities.Contains(LastStandBehaviour.ability));
        }


    }

}

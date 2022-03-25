using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI;
using InscryptionAPI.Card;
using InscryptionAPI.Ascension;
using InscryptionAPI.Helpers;
using InscryptionCommunityPatch;

namespace PAScryption.CustomAbilities
{
    public class JestarAbsorb : SpecialCardBehaviour
    {
        public SpecialTriggeredAbility SpecialAbility => specialAbility;

        public CardModificationInfo mod = new CardModificationInfo();

        public static SpecialTriggeredAbility specialAbility;
        public override bool RespondsToOtherCardDie(PlayableCard card, CardSlot deathSlot, bool fromCombat, PlayableCard killer)
        {
            return fromCombat && base.Card == killer;
        }

        public override IEnumerator OnOtherCardDie(PlayableCard card, CardSlot deathSlot, bool fromCombat, PlayableCard killer)
        {
            killer.TemporaryMods.Add(new CardModificationInfo(1, 1));
            yield break;
        }
    }
}

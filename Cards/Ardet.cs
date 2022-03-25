using System;
using System.Collections.Generic;
using System.Text;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;
using InscryptionAPI.Ascension;
using InscryptionAPI.Helpers;
using InscryptionCommunityPatch;
using InscryptionAPI.Guid;


namespace PAScryption.Cards
{
    public class Ardet
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Ardet", "Ardet", 1, 1, "This bloodlust... Be careful with this one.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 3)
                .SetPortrait("Ardet.png", "Ardet_Emission.png")
                .AddAbilities(Ability.GainAttackOnKill, Ability.BloodGuzzler)
                .AddTribes(SquareTribe.Square)
                .SetRare();
            CardManager.Add("pas_", newCard);
        }
    }
}

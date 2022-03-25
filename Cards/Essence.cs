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
    public class Essence
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Essence", "Essence", 1, 1, "I don't often pity small creatures like these.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 2)
                .SetPortrait("Essence.png", "Essence_Emission.png")
                .AddAbilities(Ability.AllStrike);
            CardManager.Add("pas_", newCard);
        }
    }
}

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
    public class Orea
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Orea", "Orea", 0, 5, "I often wonder how creatures so large have such a small face.")
                .SetDefaultPart1Card()
                .SetCost(energyCost: 4)
                .SetPortrait("Orea.png", "Orea_Emission.png")
                .AddAbilities(Ability.Sharp);
            CardManager.Add("pas_", newCard);
        }
    }
}

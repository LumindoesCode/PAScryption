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
    public class Dyson
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Dyson", "Dyson", 0, 1, "A reckless star, he'd much rather have fun instead of working.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 1)
                .SetPortrait("Dyson.png", "Dyson_Emission.png")
                .SetPixelPortrait("Pixel_Dyson.png")
                .AddAbilities(Ability.Brittle);
            CardManager.Add("pas_", newCard);
        }
    }
}

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
    public class Prominia
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Prominia", "Prominia", 2, 1, "This star does not know rest, she is always busy.")
                .SetDefaultPart1Card()
                .SetCost(bonesCost: 4)
                .SetPortrait("Prominia.png", "Prominia_Emission.png")
                .SetPixelPortrait("Pixel_Prominia.png")
                .AddAbilities(Ability.StrafePush);
            CardManager.Add("pas_", newCard);
        }
    }
}

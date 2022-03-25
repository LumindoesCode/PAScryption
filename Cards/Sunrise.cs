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
    public class Sunrise
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Sunrise", "Sunrise", 2, 3, "Ah, A Navigator Star. I have only heard legends of them.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 2)
                .SetPortrait("Sunrise.png", "Sunrise_Emission.png")
                .SetPixelPortrait("Pixel_Sunrise.png")
                .SetEvolve("pas_Eclipse", 1);
            CardManager.Add("pas_", newCard);
        }
    }
}

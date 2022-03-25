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
    public class Shapes
    {
        public static readonly CardMetaCategory SIDE_DECK_CATEGORY = GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.sidedecks", "SideDeck");
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Shapes", "Shapes", 0, 1, "")
                .SetPortrait("Shapes.png")
                .SetPixelPortrait("Pixel_Shapes.png")
                .AddMetaCategories(SIDE_DECK_CATEGORY)
                .AddTribes(SquareTribe.Square);
            CardManager.Add("pas_", newCard);
        }
    }
}

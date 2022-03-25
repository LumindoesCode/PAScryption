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
    public class Eclipse
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Eclipse", "Eclipse", 4, 3, "This bloodlust... Be careful with this one.")
                .SetCost(bloodCost: 3)
                .SetPortrait("Eclipse.png", "Eclipse_Emission.png")
                .AddMetaCategories(CardMetaCategory.TraderOffer);
            CardManager.Add("pas_", newCard);
        }
    }
}

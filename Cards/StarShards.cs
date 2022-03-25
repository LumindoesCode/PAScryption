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
    public class StarShards
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_StarShards", "Star Shards", 0, 2, "The remains of a deceased star, use them wisely.")
                .SetDefaultPart1Card()
                .SetCost(bonesCost: 5)
                .SetPortrait("Star_Shards.png", "Star_Shards_Emission.png")
                .AddAbilities(Ability.Sharp, Ability.TripleBlood);
            CardManager.Add("pas_", newCard);
        }
    }
}

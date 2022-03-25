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
    public class SussySquare
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_SussySquare", "Sussy Square", 0, 2, "I have no words for this vile, suspicious beast.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 1)
                .SetPortrait("Among_Us_Square.png", "Among_Us_Square_Emission.png")
                .AddTribes(SquareTribe.Square)
                .AddAbilities(Ability.Sentry);
            CardManager.Add("pas_", newCard);
        }
    }
}

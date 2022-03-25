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
    public class Trech
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Trech", "Trech", 1, 2, "I do not have much to say about this demon.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 1)
                .SetPortrait("Trech.png", "Trech_Emission.png")
                .AddTribes(SquareTribe.Square)
                .AddAbilities(Ability.SplitStrike);
            CardManager.Add("pas_", newCard);
        }
    }
}

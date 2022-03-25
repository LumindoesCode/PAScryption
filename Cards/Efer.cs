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
    public class Efer
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Efer", "Efer", 2, 1, "This beast seems to never run out of time for joy.")
                .SetDefaultPart1Card()
                .SetCost(energyCost: 3)
                .SetPortrait("Efer.png", "Efer_Emission.png")
                .AddAbilities(Ability.Brittle)
                .AddTribes(SquareTribe.Square);
            CardManager.Add("pas_", newCard);
        }
    }
}

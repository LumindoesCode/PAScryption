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
    public class Bond
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Bond", "Bond", 1, 1, "Be wary at night, for ghosts with guns loom.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 1)
                .SetPortrait("Bond.png", "Bond_Emission.png")
                .AddAbilities(Ability.Sniper);
            CardManager.Add("pas_", newCard);
        }
    }
}

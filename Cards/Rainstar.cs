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
    public class Rainstar
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Rainstar", "Rainstar", 2, 2, "Despite its name, it does not have the colors of the rainbow.")
                .SetDefaultPart1Card()
                .SetCost(energyCost: 4)
                .SetPortrait("Rainstar.png", "Rainstar_Emission.png")
                .AddAbilities(Ability.ExplodeOnDeath);
            CardManager.Add("pas_", newCard);
        }
    }
}

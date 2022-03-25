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
    public class Nautilus
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Nautilus", "Nautilus", 2, 3, "A mere cube, although he does have a song named after him.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 2)
                .SetPortrait("Nautilus.png", "Nautilus_Emission.png")
                .AddTribes(SquareTribe.Square)
                .AddAbilities(Ability.Submerge);
            CardManager.Add("pas_", newCard);
        }
    }
}

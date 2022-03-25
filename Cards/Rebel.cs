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
    public class Rebel
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Rebel", "Rebel", 1, 2, "A UFO, he does not know of the chaos he is going to cause.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 1)
                .SetPortrait("rebel.png", "Rebel_Emission.png")
                .AddAbilities(Ability.Flying);
            CardManager.Add("pas_", newCard);
        }
    }
}

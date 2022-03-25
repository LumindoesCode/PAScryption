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
    public class Trip
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Trip", "Trip", 2, 1, "A wild and chaotic creature of light, beyond any reason.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 3)
                .SetPortrait("Trip.png", "Trip_Emission.png")
                .AddAbilities(CustomAbility.GetCustomAbility(
                    "org.memez4life.inscryption.customsigils", "Asleep"),
                Ability.TriStrike);
            CardManager.Add("pas_", newCard);
        }
    }
}

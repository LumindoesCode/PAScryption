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
    public class Maxxenon
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Maxxenon", "Maxxenon", 1, 4, "This creature has tried to steal my knees several times.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 3)
                .SetPortrait("Maxxenon.png", "Maxxenon_Emission.png")
                .AddAbilities(Ability.GainAttackOnKill, Ability.BuffNeighbours)
                .SetRare();
            CardManager.Add("pas_", newCard);
        }
    }
}

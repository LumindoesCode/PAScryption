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
    public class Predator
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Predator", "Predator", 2, 3, "It may not look like much, but it holds a dark secret.")
                .SetCost(bloodCost: 3)
                .SetPortrait("Predator.png", "Predator_Emission.png")
                .AddAbilities(Ability.AllStrike, Ability.DebuffEnemy)
                .SetRare();
            CardManager.Add("pas_", newCard);
        }
    }
}

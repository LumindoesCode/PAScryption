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
    public class Jestar
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Jestar", "Jestar", 1, 1, "Few succeed to appease this malevolent creature. Those who fail are met with a terrible fate.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 2)
                .SetPortrait("Jestar.png", "Jestar_Emission.png")
                .AddAbilities()
                .AddSpecialAbilities(CustomAbilities.JestarAbsorb.specialAbility)
                .SetRare();
            CardManager.Add("pas_", newCard);
        }
    }
}

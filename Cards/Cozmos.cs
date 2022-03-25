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
    public class Cozmos
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Cozmos", "Cozmos", 1, 2, "Is it a hexagon, or a fox? I think it is a bat.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 1)
                .SetPortrait("Cozmos.png", "Cozmos_Emission.png")
                .AddAbilities(CustomAbility.GetCustomAbility(
                    "extraVoid.inscryption.voidSigils", "Retaliate"));
            CardManager.Add("pas_", newCard);
        }
    }
}

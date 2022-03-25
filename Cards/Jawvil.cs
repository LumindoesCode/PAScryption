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
    public class Jawvil
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Jawvil", "Jawvil", 1, 2, "A demonic presence, although not an imposing one.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 2)
                .SetPortrait("Jawvil.png", "Jawvil_Emission.png")
                .AddAbilities(CustomAbility.GetCustomAbility(
                    "extraVoid.inscryption.voidSigils", "Predator"));
            CardManager.Add("pas_", newCard);
        }
    }
}

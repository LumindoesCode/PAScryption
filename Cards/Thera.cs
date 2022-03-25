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
    public class Thera
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Thera", "Thera", 2, 2, "What a colorful, yet cowardly creature.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 1)
                .SetPortrait("Thera.png", "Thera_Emission.png")
                .AddAbilities(CustomAbility.GetCustomAbility(
                    "extraVoid.inscryption.voidSigils", "Cowardly"));
            CardManager.Add("pas_", newCard);
        }
    }
}

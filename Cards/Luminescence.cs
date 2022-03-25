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
    public class Luminescence
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Luminescence", "Luminescence", 1, 3, "It isn't often I see a living star...")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 2)
                .SetPortrait("LuminScryption.png", "LuminScryption_Emission.png")
                .AddAbilities(Ability.AllStrike, CustomAbility.GetCustomAbility(
                    "extraVoid.inscryption.voidSigils", "Haste"))
                .SetRare();
            CardManager.Add("pas_", newCard);
        }
    }
}

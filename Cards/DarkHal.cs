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
    public class DarkHal
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_DarkHal", "Dark Hal", 2, 3, "Similar to another beast, yet different in every other way.")
                .SetDefaultPart1Card()
                .SetCost(bonesCost: 3)
                .SetPortrait("Dark_Hal.png", "Dark_Hal_Emission.png")
                .AddAbilities(Ability.PreventAttack, CustomAbility.GetCustomAbility(
                    "org.memez4life.inscryption.customsigils", "Warper"))
                .AddTribes(SquareTribe.Square);
            CardManager.Add("pas_", newCard);
        }
    }
}

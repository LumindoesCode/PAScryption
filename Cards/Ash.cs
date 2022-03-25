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
    public class Ash
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Ash", "Ash", 1, 2, "Fire became this spider's greatest friend, how ironic.")
                .SetDefaultPart1Card()
                .SetGBCPlayable(CardTemple.Nature)
                .SetCost(bloodCost: 2)
                .SetPortrait("Ash.png", "Ash_Emission.png")
                .SetPixelPortrait("Pixel_Ash.png")
                .AddAbilities(CustomAbility.GetCustomAbility(
                    "extraVoid.inscryption.voidSigils", "Firestarter")
                , CustomAbility.GetCustomAbility(
                    "extraVoid.inscryption.voidSigils", "Frightful"));
            CardManager.Add("pas_", newCard);
        }
    }
}

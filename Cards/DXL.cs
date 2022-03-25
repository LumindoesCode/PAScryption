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
    public class DXL
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_DXL", "DXL", 2, 3, "This square shows great potential, although they are easily swayed.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 1)
                .SetPortrait("DXL.png", "DXL_Emission.png")
                .AddAbilities(CustomAbility.GetCustomAbility(
                    "extraVoid.inscryption.voidSigils", "Recoil"))
                .AddTribes(SquareTribe.Square);
            CardManager.Add("pas_", newCard);
        }
    }
}

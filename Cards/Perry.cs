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
    public class Perry
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Perry", "Perry", 1, 1, "It may not look like much, but it holds a dark secret.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 3)
                .SetPortrait("Perry.png", "Perry_Emission.png")
                .AddAbilities(Ability.IceCube, CustomAbility.GetCustomAbility(
                    "extraVoid.inscryption.voidSigils", "Cowardly"), 
                    CustomAbility.GetCustomAbility("extraVoid.inscryption.voidSigils", "Pathetic Sacrifice"))
                .SetIceCube("pas_Corpse")
                .SetRare();
            CardManager.Add("pas_", newCard);
        }
    }
}

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
    public class Corpse
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Corpse", "Corpse", 0, 1, "This bloodlust... Be careful with this one.")
                .SetCost(bloodCost: 3)
                .SetPortrait("Corpse.png", "Corpse_Emission.png")
                .AddAbilities(Ability.Evolve, CustomAbility.GetCustomAbility(
                    "extraVoid.inscryption.voidSigils", "Pathetic Sacrifice"))
                .SetEvolve("pas_Predator", 2)
                .AddTribes(SquareTribe.Square);
            CardManager.Add("pas_", newCard);
        }
    }
}

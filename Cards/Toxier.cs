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
    public class Toxier
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Toxier", "Toxier", 0, 1, "This creature has tried to steal my knees several times.")
                .SetCost(energyCost: 3)
                .SetPortrait("Toxier.png", "Toxier_Emission.png")
                .AddAbilities(Ability.Transformer, Ability.Deathtouch)
                .SetEvolve("pas_MetalShell", 1);
            CardManager.Add("pas_", newCard);
        }
    }
}

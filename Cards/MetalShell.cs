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
    public class MetalShell
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_MetalShell", "Metal Shell", 0, 1, "...Hmmm, did it mess with my cards?")
                .SetDefaultPart1Card()
                .SetCost(energyCost: 3)
                .SetPortrait("MetalShell.png", "MetalShell_Emission.png")
                .AddAbilities(Ability.Transformer, Ability.DeathShield)
                .SetEvolve("pas_Toxier", 1);
            CardManager.Add("pas_", newCard);
        }
    }
}

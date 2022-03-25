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
    public class NanoShell
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_NanoShell", "Nano Shell", 0, 3, "Surprisingly speedy for its size...")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 2)
                .SetPortrait("Nano_Shell.png", "Nano_Shell_Emission.png")
                .AddAbilities(Ability.Transformer, Ability.DeathShield)
                .AddTribes(SquareTribe.Square)
                .SetEvolve("pas_Python", 1);
            CardManager.Add("pas_", newCard);
        }
    }
}

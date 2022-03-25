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
    public class Python
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Python", "Python", 1, 3, "Surprisingly speedy for its size...")
                .SetCost(bloodCost: 2)
                .SetPortrait("Python.png", "Python_Emission.png")
                .AddAbilities(Ability.Transformer, Ability.TriStrike)
                .AddTribes(SquareTribe.Square)
                .SetEvolve("pas_NanoShell", 1);
            CardManager.Add("pas_", newCard);
        }
    }
}

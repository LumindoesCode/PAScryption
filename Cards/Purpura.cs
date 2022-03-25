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
    public class Purpura
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Purpura", "Purpura", 3, 1, "They often call this square 'smug,' I haven't a clue what that means.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 2)
                .AddTribes(SquareTribe.Square)
                .SetPortrait("Purpura.png", "Purpura_Emission.png");
            CardManager.Add("pas_", newCard);
        }
    }
}

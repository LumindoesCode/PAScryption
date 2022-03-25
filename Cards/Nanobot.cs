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
    public class Nanobot
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Nanobot", "Nanobot", 1, 1, "The life of this creature depends heavily on outside forces.")
                .SetDefaultPart1Card()
                .SetCost(bonesCost: 3)
                .SetPortrait("Nanobot.png", "Nanobot_Emission.png")
                .AddAbilities(CustomAbility.GetCustomAbility("extraVoid.inscryption.voidSigils", "Agile"))
                .AddTribes(SquareTribe.Square);
            CardManager.Add("pas_", newCard);
        }
    }
}

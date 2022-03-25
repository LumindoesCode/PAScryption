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
    public class Aura
    {
        public static void AddCard()
        {
            CardInfo newCard = CardManager.New("pas", "pas_Aura", "Aura", 1, 2, "An average witch, a song seems to be named after her, though.")
                .SetDefaultPart1Card()
                .SetCost(bloodCost: 1)
                .SetPortrait("Aura.png", "Aura_Emission.png")
                .AddAbilities(CustomAbility.GetCustomAbility(
                    "org.memez4life.inscryption.customsigils", "Imbuing"));
            CardManager.Add("pas_", newCard);
        }
    }
}

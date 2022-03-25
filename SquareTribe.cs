using System;
using System.Collections.Generic;
using System.Text;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI;
using InscryptionAPI.Card;
using InscryptionAPI.Helpers;
namespace PAScryption
{
    class SquareTribe
    {
        public static Tribe Square;

        public static void NewTribe()
        {
            var NewTribeInfo = TribeManager.Add("Lumin.inscryption.Pascryption", "Square", TextureHelper.GetImageAsTexture("Square_Tribe.png"), true, TextureHelper.GetImageAsTexture("Square_Cardback.png"));
            Square = NewTribeInfo;
        }
    }
}

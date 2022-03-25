using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI;
using InscryptionAPI.Card;
using InscryptionAPI.Helpers;
using PAScryption.Cards;
using InscryptionAPI.Boons;

namespace PAScryption
{
    class CustomAbility
    {
        public static Ability GetCustomAbility(string GUID, string rulebookname)
        {
            return InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>(GUID, rulebookname);

        }
        
    }

    
}

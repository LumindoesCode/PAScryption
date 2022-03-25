using BepInEx;
using BepInEx.Logging;
using BepInEx.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.IO;
using DiskCardGame;
using HarmonyLib;
using UnityEngine;
using APIPlugin;
using InscryptionAPI;
using InscryptionAPI.Ascension;
using InscryptionAPI.Guid;
using PAScryption.Cards;
using PAScryption.CustomAbilities;
using InscryptionAPI.Card;
using InscryptionAPI.Encounters;
using InscryptionAPI.Helpers;
using InscryptionAPI.Saves;
using Infiniscryption.PackManagement;
using BepInEx.Bootstrap;

namespace PAScryption
{

    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("extraVoid.inscryption.voidSigils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency(StarterdeckGUID, BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
    {
        public const string PluginGuid = "Lumin.inscryption.Pascryption";
        private const string PluginName = "PAScryption";
        private const string PluginVersion = "1.0.0.0";
        public const string StarterdeckGUID = "zorro.inscryption.infiniscryption.sidedecks";

        internal static ManualLogSource manualLog;
        public static string Directory;

        internal static ConfigEntry<bool> configEphemeralCollab;

        public static void CreatePack()
        {
            PackInfo incrediPack = PackManager.GetPackInfo("pas_");
            incrediPack.Title = "PAScryption";
            incrediPack.SetTexture(TextureHelper.GetImageAsTexture("PAScryption_Cover.png"));
            incrediPack.Description = "A card pack filled with Project Arrhythmia Workshop characters!";
            incrediPack.ValidFor.Add(PackInfo.PackMetacategory.LeshyPack);
        }


        private void Awake()
        {
            configEphemeralCollab = Config.Bind("Encounters", "Ephemeral Collab", true, "Turn the encounter off or on?");

            Harmony harmony = new(PluginGuid);
            harmony.PatchAll();


            Directory = this.Info.Location.Replace($"{PluginName}.dll", "");
            manualLog = this.Logger;
            manualLog.LogMessage($"Loaded {PluginName}!");

            SquareTribe.NewTribe();

            CustomAbilities.LastStand.RegisterAbility();
            CustomAbilities.JestarAbsorb.specialAbility = SpecialTriggeredAbilityManager.Add(
                "Lumin.inscryption.Pascryption", "Jestar Absorption", typeof(JestarAbsorb)).Id;

            Ardet.AddCard();
            Ash.AddCard();
            Aura.AddCard();
            Bond.AddCard();
            Corpse.AddCard();
            Cozmos.AddCard();
            DarkHal.AddCard();
            DXL.AddCard();
            Dyson.AddCard();
            Eclipse.AddCard();
            Efer.AddCard();
            Essence.AddCard();
            Jawvil.AddCard();
            Jestar.AddCard();
            Luminescence.AddCard();
            Maxxenon.AddCard();
            MetalShell.AddCard();
            Nanobot.AddCard();
            NanoShell.AddCard();
            Nautilus.AddCard();
            Orea.AddCard();
            Perry.AddCard();
            Predator.AddCard();
            Prominia.AddCard();
            Purpura.AddCard();
            Python.AddCard();
            Rainstar.AddCard();
            Rebel.AddCard();
            Shapes.AddCard();
            StarShards.AddCard();
            Sunrise.AddCard();
            SussySquare.AddCard();
            Thera.AddCard();
            Toxier.AddCard();
            Trech.AddCard();
            Trip.AddCard();

            StarterDeckManager.New("Lumin.inscryption.Pascryption", "Compass", "Compass_Deck_Icon.png", new string[] { "pas_Prominia", "pas_Dyson", "pas_Sunrise" });

        }

        private void Start()
        {
            if (Chainloader.PluginInfos.ContainsKey("zorro.inscryption.infiniscryption.packmanager"))
            {
                CreatePack();
            }

            if (configEphemeralCollab.Value)
            {
                Encounters.EphemeralCollab.AddEncounter();
            }
        
        }
        


    }

}

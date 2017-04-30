﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrapYard
{
    public class SaveSpecificSettings : GameParameters.CustomParameterNode
    {
        public override GameParameters.GameMode GameMode
        {
            get
            {
                return GameParameters.GameMode.ANY;
            }
        }

        public override bool HasPresets //we should integrate KCT into this...
        {
            get
            {
                return false; //for now lets not have presets
            }
        }

        public override string Section
        {
            get
            {
                return "ScrapYard";
            }
        }

        public override int SectionOrder
        {
            get
            {
                return 1; //I think? I'm not 100% sure what this is for
            }
        }

        public override string Title
        {
            get
            {
                return "ScrapYard";
            }
        }

        [GameParameters.CustomParameterUI("Mod Enabled", toolTip = "Uncheck this to disable ScrapYard for this save.")]
        public bool ModEnabled = true;

        [GameParameters.CustomParameterUI("Enable Inventory", toolTip = "Uncheck this to disable the part inventory entirely.")]
        public bool UseInventory = true;

        [GameParameters.CustomParameterUI("Enable Part Tracker", toolTip = "Uncheck this to disable the part tracker entirely.")]
        public bool UseTracker = true;

        [GameParameters.CustomParameterUI("Override Funds", toolTip = "Enable this to make it so pulling parts from the inventory reduces costs, but recovery costs funds.",
            gameMode = GameParameters.GameMode.CAREER)]
        public bool OverrideFunds = false;
        

    }
}
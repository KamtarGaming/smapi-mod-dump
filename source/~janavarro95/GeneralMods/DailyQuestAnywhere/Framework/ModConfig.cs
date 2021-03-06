﻿namespace Omegasis.DailyQuestAnywhere.Framework
{
    /// <summary>The mod configuration.</summary>
    internal class ModConfig
    {
        /// <summary>The key which shows the menu.</summary>
        public string KeyBinding { get; set; } = "H";

        /// <summary>
        /// The chance for a daily quest to actually happen.
        /// </summary>
        public float chanceForDailyQuest { get; set; } = .75f;
    }
}

// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Game.Graphics.UserInterfaceV2;
using osu.Game.Overlays.Settings;
using osu.Game.Rulesets.Typing.Configuration;

namespace osu.Game.Rulesets.Typing
{
    public partial class TypingSettingsSubsection : RulesetSettingsSubsection
    {
        private const string ruleset_hit_sounds_hint_text = "Play the ruleset's note-hit sound instead of the skin's hit sound.";

        public TypingSettingsSubsection(TypingRuleset ruleset)
            : base(ruleset)
        {
        }

        [BackgroundDependencyLoader]
        private void load()
        {
            var config = (TypingRulesetConfigManager)Config;

            Children = new Drawable[]
            {
                new SettingsItemV2(new FormCheckBox
                {
                    Caption = "Use ruleset hit sound",
                    HintText = ruleset_hit_sounds_hint_text,
                    Current = config.GetBindable<bool>(TypingRulesetSetting.UseRulesetHitSounds)
                })
            };
        }
    }
}

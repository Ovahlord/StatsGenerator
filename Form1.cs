namespace statsGenerator
{

    public partial class Form1 : Form
    {
        public class Stats
        {
            public int str = 0;
            public int agi = 0;
            public int sta = 0;
            public int inte = 0;
            public int spi = 0;
        }

        public Form1()
        {
            InitializeComponent();
            classDropdown.SelectedIndex = 0;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            GenerateOutput();
        }

        public enum ClassIds : int
        {
            CLASS_NONE          = 0,
            CLASS_WARRIOR       = 1,
            CLASS_PALADIN       = 2,
            CLASS_HUNTER        = 3,
            CLASS_ROGUE         = 4,
            CLASS_PRIEST        = 5,
            CLASS_DEATH_KNIGHT  = 6,
            CLASS_SHAMAN        = 7,
            CLASS_MAGE          = 8,
            CLASS_WARLOCK       = 9,
            CLASS_DRUID         = 11,
        }

        private int GetClassIdForDropdownIndex(int index)
        {
            switch (index)
            {
                case 0: return (int)ClassIds.CLASS_WARRIOR;
                case 1: return (int)ClassIds.CLASS_PALADIN;
                case 2: return (int)ClassIds.CLASS_HUNTER;
                case 3: return (int)ClassIds.CLASS_ROGUE;
                case 4: return (int)ClassIds.CLASS_PRIEST;
                case 5: return (int)ClassIds.CLASS_DEATH_KNIGHT;
                case 6: return (int)ClassIds.CLASS_SHAMAN;
                case 7: return (int)ClassIds.CLASS_MAGE;
                case 8: return (int)ClassIds.CLASS_WARLOCK;
                case 9: return (int)ClassIds.CLASS_DRUID;
                default:
                    return 0;
            }
        }

        private void GenerateOutput()
        {
            List<Stats> stats = new();
            Stats offsets = new()
            {
                str = int.Parse(strOffset.Text),
                agi = int.Parse(agiOffset.Text),
                sta = int.Parse(staOffset.Text),
                inte = int.Parse(intOffset.Text),
                spi = int.Parse(spiOffset.Text)
            };

            foreach (string line in inputTextBox.Lines)
            {
                if (line.Contains("Strength"))
                {
                    stats.Add(new Stats());
                    stats[^1].str = int.Parse(line.Replace("Strength", "")) + offsets.str;
                }

                if (line.Contains("Agility"))
                    stats[^1].agi = int.Parse(line.Replace("Agility", "")) + offsets.agi;

                if (line.Contains("Stamina"))
                    stats[^1].sta = int.Parse(line.Replace("Stamina", "")) + offsets.sta;

                if (line.Contains("Intellect"))
                    stats[^1].inte = int.Parse(line.Replace("Intellect", "")) + offsets.inte;

                if (line.Contains("Spirit"))
                {
                    stats[^1].spi = int.Parse(line.Replace("Spirit", "")) + offsets.spi;

                    // The human spirit racial passive adds 3% spirit to the base spirit stat, so we have 103% that we want to reduce to 100% instead
                    if (humanRacialCheckBox.Checked)
                        stats[^1].spi = (int)(MathF.Ceiling(stats[^1].spi / 103.0f * 100));
                }
            }

            int lineIndex = 3;
            string[] output = new string[stats.Count + 3];
            output[0] = $"SET @CLASS := {GetClassIdForDropdownIndex(classDropdown.SelectedIndex)}; -- {(ClassIds)GetClassIdForDropdownIndex(classDropdown.SelectedIndex)}";
            output[1] = "DELETE FROM `player_classlevelstats` WHERE `class`= @CLASS;";
            output[2] = "INSERT INTO `player_classlevelstats` (`class`, `level`, `str`, `agi`, `sta`, `inte`, `spi`) VALUES";
            int level = int.Parse(startLevel.Text);
            foreach (Stats stat in stats)
            {
                output[lineIndex] = $"(@CLASS, {level}, {stat.str}, {stat.agi}, {stat.sta}, {stat.inte}, {stat.spi}),";
                ++lineIndex;
                ++level;
            }

            output[^1] = output[^1].Replace("),", ");");

            outputTextBox.Lines = output;
        }
    }
}

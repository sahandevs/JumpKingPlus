using LanguageJK;
using System;
using JumpKing;
using JumpKing.SaveThread;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace JumpKingPlus
{
    public class Cheats
    {
        // if cheats are checked then no achievements
        // jump%
        // no falls
        // teleport to location

        public Cheats()
        {
            achievementsAcc = true;
            jumpPerc = false;
            noFalls = false;
            tpOption = false;
        }

        public string[] location = { 
            //nb
            language.LOCATION_REDCROWN_WOODS,
            language.LOCATION_COLOSSAL_DRAIN,
            language.LOCATION_FALSE_KINGS_KEEP,
            language.LOCATION_BARGAINBURG,
            language.LOCATION_GREAT_FRONTIER,
            language.LOCATION_WINDSWEPT_BLUFF,
            language.LOCATION_STORMWALL_PASS,
            language.LOCATION_CHAPEL_PERILOUS,
            language.LOCATION_BLUE_RUIN,
            language.LOCATION_THE_TOWER,
            "Main Babe's Screen",
            //nbp
            "Room of the Imp",
            language.LOCATION_BRIGHTCROWN_WOODS,
            language.LOCATION_COLOSSAL_DUNGEON,
            language.LOCATION_FALSE_KINGS_CASTLE,
            language.LOCATION_UNDERBURG,
            language.LOCATION_LOST_FRONTIER,
            language.LOCATION_HIDDEN_KINGDOM,
            language.LOCATION_BLACK_SANCTUM,
            language.LOCATION_DEEP_RUIN,
            language.LOCATION_THE_DARK_TOWER,
            "New Babe Plus' Screen",
            //gotb
            language.LOCATION_PHILOSOPHERS_FOREST,
            "Hole",
            language.LOCATION_BOG,
            language.LOCATION_MOULDING_MANOR,
            language.LOCATION_BUGSTALK,
            language.LOCATION_HOUSE_OF_NINE_LIVES,
            language.LOCATION_THE_PHANTOM_TOWER,
            language.LOCATION_HALTED_RUIN,
            language.LOCATION_THE_TOWER_OF_ANTUMBRA,
            "Ghost of the Babe's Screen"
        };

        public Vector3 playerLocation;

        public void SetTeleport(Vector2 position, int screen)
        {
            playerLocation = new Vector3(position.X, position.Y, screen);
        }

        public void SetToDefault()
        {
            playerLocation = Vector3.Zero;
        }

        public void TeleportToSavedLocation()
        {
            if (playerLocation == Vector3.Zero)
            {
                return;
            }
            TeleportToLocation(playerLocation.X, playerLocation.Y, (int)playerLocation.Z);
            JumpKing.MusicManager.Play(JKContentManager.Audio.Menu.Select);
        }

        public static void TeleportToLocation(float pX, float pY, int locInt)
        {
            SaveManager.instance.m_player.m_body.position.X = pX;
            SaveManager.instance.m_player.m_body.position.Y = pY;
            SaveManager.instance.m_player.m_body.m_last_screen = locInt;
            SaveManager.instance.m_player.m_body.velocity = Vector2.Zero;
            Camera.UpdateCamera(SaveManager.instance.m_player.m_body.GetHitbox().Center);
        }
        public void BestScreenAssignment()
        {
            if (Camera.CurrentScreen > bestScreen)
            {
                bestScreen = Camera.CurrentScreen;
            }
        }

        public int LocationsUnlocked()
        {
            switch (bestScreen)
            {
                case int n when (n >= 0 && n <= 4 || n >= 44 && n <= 45 || n >= 155 && n <= 159):
                    return 0;

                case int n when (n >= 5 && n <= 9 || n >= 46 && n <= 51 || n >= 160 && n <= 163):
                    return 1;

                case int n when (n >= 10 && n <= 13 || n >= 52 && n <= 58 || n >= 101 && n <= 107):
                    return 2;

                case int n when (n >= 14 && n <= 18 || n >= 59 && n <= 62 || n >= 108 && n <= 115):
                    return 3;

                case int n when (n >= 19 && n <= 24 || n >= 63 && n <= 69 || n >= 116 && n <= 122):
                    return 4;

                case int n when (n >= 26 && n <= 31 || n >= 70 && n <= 76 || n >= 123 && n <= 129):
                    return 5;

                case int n when (n >= 32 && n <= 35 || n >= 77 && n <= 82 || n >= 130 && n <= 138):
                    return 6;

                case int n when (n >= 36 && n <= 38 || n >= 83 && n <= 88 || n >= 139 && n <= 146):
                    return 7;

                case int n when (n >= 39 && n <= 41 || n >= 89 && n <= 93 || n >= 147 && n <= 152):
                    return 8;

                case int n when (n == 42 || n >= 94 && n <= 98 || n == 153):
                    return 9;

                case 99:
                    return 10;

                default:
                    return 5;
            }
        }

        public int[] locInt = { 
            0, 5, 10, 14, 19, 25, 26, 32, 36, 39, 42,
            44, 46, 52, 59, 63, 70, 77, 83, 89, 94, 99,
            155, 163, 101, 108, 116, 123, 130, 139, 147, 153
        };
        public int[] locX = {
            //nb
            231, 251, 340, 150, 222, 216, 223, 426, 410, 435, 150, 
            //nbp
            171, 377, 295, 105, 415, 242, 360, 210, 170, 288, 140,
            //gotb
            16, 32, 79, 183, 163, 329, 333, 204, 292, 302
        };
        public int[] locY = { 
            //nb
            302, -1498, -3282, -4738, -6594, -8714, -9074, -11202, -12658, -13722, -14802,
            //nbp
            -15570, -16274, -18426, -20922, -22362, -24898, -27402, -29578, -31786, -33554, -35314,
            //gotb
            -55714, -58434, -36074, -38602, -41442, -43970, -46530, -49794, -52626, -54770
        };

        private bool achievementsAcc;
        private bool jumpPerc;
        private bool noFalls;
        private bool tpOption;
        private int bestScreen = 0;
        private float jumpTimer = 0f;
        private int lastJump = 0;

        public bool AchievementAccess { get { return achievementsAcc; } set { achievementsAcc = value; ToggleCheatAction(); } }
        public bool JumpPercentage { get { return jumpPerc; } set { jumpPerc = value; } }
        public bool NoFalls { get { return noFalls; } set{ noFalls = value; } }
        public bool TeleportOption { get { return tpOption; } set { tpOption = value; } }
        public int BestScreen { get { return bestScreen; } set { bestScreen = value; } }
        public float JumpTimer { get { return jumpTimer; } set { jumpTimer = value; } }
        public int LastJump { get { return lastJump; } set { lastJump = value; } }

        public int RoundPercent(float currentjump, float jumptime)
        {
            var value = (currentjump / jumptime) * 100;
            value = (float)Math.Round(value);
            return Convert.ToInt32(value);
        }

        public List<int> GetAllBabeScreens(int target, int startingPoint = 0)
        {
            // starting point must be x + 1 !!!!
            target += 1;
            DiscordLocations.Location[] locs = DiscordLocations._discordLocation.locations;
            bool addList = false;
            List<int> allLocs = new List<int>();
            if (startingPoint == 0) { addList = true; }

            foreach (DiscordLocations.Location loc in locs)
            {
                if (startingPoint != 0 && (loc.start == startingPoint || loc.end == startingPoint))
                {
                    addList = true;
                    continue;
                }
                if (addList && loc.start != target && loc.end != target)
                {
                    for (int i = loc.start - 1; i < loc.end; i++)
                    {
                        allLocs.Add(i);
                    }
                }
                if (loc.start == target || loc.end == target)
                {
                    break;
                }
            }

            return allLocs;
        }

        public string GamePercent(int currentScreen)
        {
            EndingFix babeScreens = new EndingFix();
            babeScreens.Default();
            List<int> screens = new List<int>() {
                babeScreens.Main,
                babeScreens.NBP,
                babeScreens.Owl
            };

            /*List<int> main = GetAllBabeScreens(babeScreens.Main);
            List<int> nbp = GetAllBabeScreens(babeScreens.NBP, babeScreens.Main + 1);
            List<int> owl = GetAllBabeScreens(babeScreens.Owl, babeScreens.NBP + 1);*/


            int subtract = 0;
            foreach (int babes in screens)
            {
                if (currentScreen <= babes)
                {

                    List<int> allScreens = GetAllBabeScreens(babes, subtract);
                    var current = allScreens.IndexOf(currentScreen);
                    float value = (float)(current) / (float)(allScreens.Count);
                    value *= 100f;
                    return value.ToString("0.00");
                }
                subtract = babes + 1;
            }   
            return "???";
        }
        public string GamePercent(int currentScreen, int customScreen)
        {
            if (currentScreen <= customScreen)
            {
                float value = (float)currentScreen / (float)(customScreen - 1);
                value *= 100f;
                return value.ToString("0.00");
            }
            return "???";
        }

        public void ToggleCheatAction()
        {
            if (AchievementAccess)
            {
                JumpPercentage = false;
                NoFalls = false;
                TeleportOption = false;
            }
        }
    }
}

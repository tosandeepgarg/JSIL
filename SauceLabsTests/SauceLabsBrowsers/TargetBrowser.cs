using System;
using System.Collections.Generic;

namespace JSIL.SauceLabsTests.SauceLabsBrowsers
{
    public class TargetBrowser
    {
        public static IEnumerable<TargetBrowser> Browsers = new TargetBrowser[]
            {
                new TargetBrowser(Platform.OsX10_9, Browser.IPhone, string.Empty),
                new TargetBrowser(Platform.OsX10_9, Browser.IPhone, "7.1"),
                new TargetBrowser(Platform.OsX10_9, Browser.IPhone, "7.0"),

                new TargetBrowser(Platform.OsX10_8, Browser.IPhone, string.Empty),
                new TargetBrowser(Platform.OsX10_8, Browser.IPhone, "6.1"),
                new TargetBrowser(Platform.OsX10_8, Browser.IPhone, "6.0"),
                new TargetBrowser(Platform.OsX10_8, Browser.IPhone, "5.1"),

                new TargetBrowser(Platform.OsX10_6, Browser.IPhone, string.Empty),
                new TargetBrowser(Platform.OsX10_8, Browser.IPhone, "5.0"),
                new TargetBrowser(Platform.OsX10_8, Browser.IPhone, "4"),

                new TargetBrowser(Platform.OsX10_9, Browser.IPad, string.Empty),
                new TargetBrowser(Platform.OsX10_9, Browser.IPad, "7.1"),
                new TargetBrowser(Platform.OsX10_9, Browser.IPad, "7.0"),

                new TargetBrowser(Platform.OsX10_8, Browser.IPad, string.Empty),
                new TargetBrowser(Platform.OsX10_8, Browser.IPad, "6.1"),
                new TargetBrowser(Platform.OsX10_8, Browser.IPad, "6.0"),
                new TargetBrowser(Platform.OsX10_8, Browser.IPad, "5.1"),

                new TargetBrowser(Platform.OsX10_6, Browser.IPad, string.Empty),
                new TargetBrowser(Platform.OsX10_8, Browser.IPad, "5.0"),
                new TargetBrowser(Platform.OsX10_8, Browser.IPad, "4"),

                new TargetBrowser(Platform.Linux, Browser.Android, string.Empty),
                new TargetBrowser(Platform.Linux, Browser.Android, "4.3"),
                new TargetBrowser(Platform.Linux, Browser.Android, "4.2"),
                new TargetBrowser(Platform.Linux, Browser.Android, "4.1"),
                new TargetBrowser(Platform.Linux, Browser.Android, "4.0"),

                new TargetBrowser(Platform.Win8_1, Browser.Firefox, string.Empty),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "30"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "29"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "28"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "27"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "26"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "25"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "24"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "23"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "22"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "21"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "20"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "19"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "18"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "17"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "16"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "15"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "14"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "13"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "12"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "11"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "10"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "9"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "8"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "7"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "6"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "5"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "4"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "3.6"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "3.5"),
                new TargetBrowser(Platform.Win8_1, Browser.Firefox, "3.0"),

                new TargetBrowser(Platform.Win8_1, Browser.Chrome, string.Empty),
                new TargetBrowser(Platform.Win8_1, Browser.Chrome, "beta"),
                new TargetBrowser(Platform.Win8_1, Browser.Chrome, "35"),
                new TargetBrowser(Platform.Win8_1, Browser.Chrome, "34"),
                new TargetBrowser(Platform.Win8_1, Browser.Chrome, "33"),
                new TargetBrowser(Platform.Win8_1, Browser.Chrome, "32"),
                new TargetBrowser(Platform.Win8_1, Browser.Chrome, "31"),
                new TargetBrowser(Platform.Win8_1, Browser.Chrome, "30"),
                new TargetBrowser(Platform.Win8_1, Browser.Chrome, "29"),
                new TargetBrowser(Platform.Win8_1, Browser.Chrome, "28"),
                new TargetBrowser(Platform.Win8_1, Browser.Chrome, "27"),
                new TargetBrowser(Platform.Win8_1, Browser.Chrome, "26"),

                new TargetBrowser(Platform.Win8_1, Browser.IE, string.Empty),
                new TargetBrowser(Platform.Win8_1, Browser.IE, "11"),

                new TargetBrowser(Platform.Win8, Browser.Firefox, string.Empty),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "30"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "29"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "28"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "27"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "26"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "25"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "24"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "23"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "22"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "21"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "20"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "19"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "18"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "17"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "16"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "15"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "14"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "13"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "12"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "11"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "10"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "9"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "8"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "7"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "6"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "5"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "4"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "3.6"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "3.5"),
                new TargetBrowser(Platform.Win8, Browser.Firefox, "3.0"),

                new TargetBrowser(Platform.Win8, Browser.Chrome, string.Empty),
                new TargetBrowser(Platform.Win8, Browser.Chrome, "beta"),
                new TargetBrowser(Platform.Win8, Browser.Chrome, "35"),
                new TargetBrowser(Platform.Win8, Browser.Chrome, "34"),
                new TargetBrowser(Platform.Win8, Browser.Chrome, "33"),
                new TargetBrowser(Platform.Win8, Browser.Chrome, "32"),
                new TargetBrowser(Platform.Win8, Browser.Chrome, "31"),
                new TargetBrowser(Platform.Win8, Browser.Chrome, "30"),
                new TargetBrowser(Platform.Win8, Browser.Chrome, "29"),
                new TargetBrowser(Platform.Win8, Browser.Chrome, "28"),
                new TargetBrowser(Platform.Win8, Browser.Chrome, "27"),
                new TargetBrowser(Platform.Win8, Browser.Chrome, "26"),

                new TargetBrowser(Platform.Win8, Browser.IE, string.Empty),
                new TargetBrowser(Platform.Win8, Browser.IE, "10"),

                new TargetBrowser(Platform.Win7, Browser.Firefox, string.Empty),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "30"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "29"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "28"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "27"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "26"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "25"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "24"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "23"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "22"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "21"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "20"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "19"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "18"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "17"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "16"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "15"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "14"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "13"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "12"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "11"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "10"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "9"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "8"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "7"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "6"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "5"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "4"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "3.6"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "3.5"),
                new TargetBrowser(Platform.Win7, Browser.Firefox, "3.0"),

                new TargetBrowser(Platform.Win7, Browser.Chrome, string.Empty),
                new TargetBrowser(Platform.Win7, Browser.Chrome, "beta"),
                new TargetBrowser(Platform.Win7, Browser.Chrome, "35"),
                new TargetBrowser(Platform.Win7, Browser.Chrome, "34"),
                new TargetBrowser(Platform.Win7, Browser.Chrome, "33"),
                new TargetBrowser(Platform.Win7, Browser.Chrome, "32"),
                new TargetBrowser(Platform.Win7, Browser.Chrome, "31"),
                new TargetBrowser(Platform.Win7, Browser.Chrome, "30"),
                new TargetBrowser(Platform.Win7, Browser.Chrome, "29"),
                new TargetBrowser(Platform.Win7, Browser.Chrome, "28"),
                new TargetBrowser(Platform.Win7, Browser.Chrome, "27"),
                new TargetBrowser(Platform.Win7, Browser.Chrome, "26"),

                new TargetBrowser(Platform.Win7, Browser.IE, string.Empty),
                new TargetBrowser(Platform.Win7, Browser.IE, "11"),
                new TargetBrowser(Platform.Win7, Browser.IE, "10"),
                new TargetBrowser(Platform.Win7, Browser.IE, "9"),
                new TargetBrowser(Platform.Win7, Browser.IE, "8"),

                new TargetBrowser(Platform.Win7, Browser.Opera, string.Empty),
                new TargetBrowser(Platform.Win7, Browser.Opera, "12"),
                new TargetBrowser(Platform.Win7, Browser.Opera, "11"),

                new TargetBrowser(Platform.Win7, Browser.Safari, string.Empty),
                new TargetBrowser(Platform.Win7, Browser.Safari, "5"),

                new TargetBrowser(Platform.WinXp, Browser.Firefox, string.Empty),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "30"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "29"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "28"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "27"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "26"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "25"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "24"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "23"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "22"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "21"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "20"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "19"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "18"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "17"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "16"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "15"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "14"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "13"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "12"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "11"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "10"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "9"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "8"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "7"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "6"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "5"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "4"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "3.6"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "3.5"),
                new TargetBrowser(Platform.WinXp, Browser.Firefox, "3.0"),

                new TargetBrowser(Platform.WinXp, Browser.Chrome, string.Empty),
                new TargetBrowser(Platform.WinXp, Browser.Chrome, "beta"),
                new TargetBrowser(Platform.WinXp, Browser.Chrome, "35"),
                new TargetBrowser(Platform.WinXp, Browser.Chrome, "34"),
                new TargetBrowser(Platform.WinXp, Browser.Chrome, "33"),
                new TargetBrowser(Platform.WinXp, Browser.Chrome, "32"),
                new TargetBrowser(Platform.WinXp, Browser.Chrome, "31"),
                new TargetBrowser(Platform.WinXp, Browser.Chrome, "30"),
                new TargetBrowser(Platform.WinXp, Browser.Chrome, "29"),
                new TargetBrowser(Platform.WinXp, Browser.Chrome, "28"),
                new TargetBrowser(Platform.WinXp, Browser.Chrome, "27"),
                new TargetBrowser(Platform.WinXp, Browser.Chrome, "26"),

                new TargetBrowser(Platform.WinXp, Browser.IE, string.Empty),
                new TargetBrowser(Platform.WinXp, Browser.IE, "11"),
                new TargetBrowser(Platform.WinXp, Browser.IE, "10"),
                new TargetBrowser(Platform.WinXp, Browser.IE, "9"),
                new TargetBrowser(Platform.WinXp, Browser.IE, "8"),

                new TargetBrowser(Platform.WinXp, Browser.Opera, string.Empty),
                new TargetBrowser(Platform.WinXp, Browser.Opera, "12"),
                new TargetBrowser(Platform.WinXp, Browser.Opera, "11"),

                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, string.Empty),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "30"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "29"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "28"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "27"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "26"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "25"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "24"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "23"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "22"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "21"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "20"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "19"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "18"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "17"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "16"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "15"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "14"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "13"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "12"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "11"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "10"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "9"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "8"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "7"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "6"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "5"),
                new TargetBrowser(Platform.OsX10_9, Browser.Firefox, "4"),

                new TargetBrowser(Platform.OsX10_9, Browser.Chrome, string.Empty),
                new TargetBrowser(Platform.OsX10_9, Browser.Chrome, "35"),
                new TargetBrowser(Platform.OsX10_9, Browser.Chrome, "34"),
                new TargetBrowser(Platform.OsX10_9, Browser.Chrome, "33"),
                new TargetBrowser(Platform.OsX10_9, Browser.Chrome, "32"),
                new TargetBrowser(Platform.OsX10_9, Browser.Chrome, "31"),

                new TargetBrowser(Platform.OsX10_9, Browser.Safari, string.Empty),
                new TargetBrowser(Platform.OsX10_9, Browser.Safari, "7"),

                new TargetBrowser(Platform.OsX10_8, Browser.Chrome, string.Empty),
                new TargetBrowser(Platform.OsX10_8, Browser.Chrome, "beta"),
                new TargetBrowser(Platform.OsX10_8, Browser.Chrome, "35"),
                new TargetBrowser(Platform.OsX10_8, Browser.Chrome, "35"),
                new TargetBrowser(Platform.OsX10_8, Browser.Chrome, "34"),
                new TargetBrowser(Platform.OsX10_8, Browser.Chrome, "33"),
                new TargetBrowser(Platform.OsX10_8, Browser.Chrome, "32"),
                new TargetBrowser(Platform.OsX10_8, Browser.Chrome, "31"),
                new TargetBrowser(Platform.OsX10_8, Browser.Chrome, "28"),
                new TargetBrowser(Platform.OsX10_8, Browser.Chrome, "27"),

                new TargetBrowser(Platform.OsX10_9, Browser.Safari, string.Empty),
                new TargetBrowser(Platform.OsX10_9, Browser.Safari, "6"),

                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, string.Empty),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "30"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "29"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "28"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "27"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "26"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "25"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "24"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "23"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "22"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "21"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "20"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "19"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "18"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "17"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "16"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "15"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "14"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "13"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "12"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "11"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "10"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "9"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "8"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "7"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "6"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "5"),
                new TargetBrowser(Platform.OsX10_6, Browser.Firefox, "4"),

                new TargetBrowser(Platform.OsX10_6, Browser.Chrome, string.Empty),
                new TargetBrowser(Platform.OsX10_6, Browser.Chrome, "beta"),
                new TargetBrowser(Platform.OsX10_6, Browser.Chrome, "35"),
                new TargetBrowser(Platform.OsX10_6, Browser.Chrome, "35"),
                new TargetBrowser(Platform.OsX10_6, Browser.Chrome, "34"),
                new TargetBrowser(Platform.OsX10_6, Browser.Chrome, "33"),
                new TargetBrowser(Platform.OsX10_6, Browser.Chrome, "32"),
                new TargetBrowser(Platform.OsX10_6, Browser.Chrome, "31"),
                new TargetBrowser(Platform.OsX10_6, Browser.Chrome, "28"),
                new TargetBrowser(Platform.OsX10_6, Browser.Chrome, "27"),

                new TargetBrowser(Platform.OsX10_9, Browser.Safari, string.Empty),
                new TargetBrowser(Platform.OsX10_9, Browser.Safari, "5"),

                new TargetBrowser(Platform.Linux, Browser.Firefox, string.Empty),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "30"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "29"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "28"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "27"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "26"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "25"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "24"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "23"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "22"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "21"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "20"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "19"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "18"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "17"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "16"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "15"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "14"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "13"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "12"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "11"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "10"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "9"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "8"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "7"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "6"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "5"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "4"),
                new TargetBrowser(Platform.Linux, Browser.Firefox, "3"),

                new TargetBrowser(Platform.Linux, Browser.Chrome, string.Empty),
                new TargetBrowser(Platform.Linux, Browser.Chrome, "35"),
                new TargetBrowser(Platform.Linux, Browser.Chrome, "35"),
                new TargetBrowser(Platform.Linux, Browser.Chrome, "34"),
                new TargetBrowser(Platform.Linux, Browser.Chrome, "33"),
                new TargetBrowser(Platform.Linux, Browser.Chrome, "32"),
                new TargetBrowser(Platform.Linux, Browser.Chrome, "31"),
                new TargetBrowser(Platform.Linux, Browser.Chrome, "30"),
                new TargetBrowser(Platform.Linux, Browser.Chrome, "29"),
                new TargetBrowser(Platform.Linux, Browser.Chrome, "28"),
                new TargetBrowser(Platform.Linux, Browser.Chrome, "27"),
                new TargetBrowser(Platform.Linux, Browser.Chrome, "26"),

                new TargetBrowser(Platform.Linux, Browser.Opera, string.Empty),
                new TargetBrowser(Platform.Linux, Browser.Opera, "12"),
            };

        private TargetBrowser(Platform platform, Browser browser, string version)
        {
            Platform = platform;
            Browser = browser;
            Version = version;
        }

        public Platform Platform { get; private set; }
        public Browser Browser { get; private set; }
        public string Version { get; private set; }

        public override string ToString()
        {
            string platform = string.Empty;
            switch (Platform)
            {
                case Platform.OsX10_9:
                    platform = "OS X 10.9";
                    break;
                case Platform.OsX10_8:
                    platform = "OS X 10.8";
                    break;
                case Platform.OsX10_6:
                    platform = "OS X 10.6";
                    break;
                case Platform.Linux:
                    platform = "Linux";
                    break;
                case Platform.Win8_1:
                    platform = "Windows 8.1";
                    break;
                case Platform.Win8:
                    platform = "Windows 8";
                    break;
                case Platform.Win7:
                    platform = "Windows 7";
                    break;
                case Platform.WinXp:
                    platform = "Windows XP";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            string browser = string.Empty;
            switch (Browser)
            {
                case Browser.IPhone:
                    browser = "IPHONE";
                    break;
                case Browser.IPad:
                    browser = "IPAD";
                    break;
                case Browser.Android:
                    browser = "ANDROID";
                    break;
                case Browser.Firefox:
                    browser = "FIREFOX";
                    break;
                case Browser.Chrome:
                    browser = "FIREFOX";
                    break;
                case Browser.IE:
                    browser = "CHROME";
                    break;
                case Browser.Opera:
                    browser = "OPERA";
                    break;
                case Browser.Safari:
                    browser = "SAFARI";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return string.Format("[\"{0}\", \"{1}\", \"{2}\"]", platform, browser, Version);
        }
    }
}
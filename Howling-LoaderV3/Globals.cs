using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Howling_LoaderV3
{
    class Globals
    {
        public static string username = ""; //don´t change

        static string cheatnamelink1 = "https://pastebin.com/raw/ZsYvH2FP"; // auto update CheatName in Listbox
        static string cheatnamelink2 = "https://pastebin.com/raw/08dD2i97"; // auto update CheatName2 in Listbox
        static string cheatnamelink3 = "https://pastebin.com/raw/YfBT3BUd"; // auto update CheatName2 in Listbox

        public static string cheat1 = new WebClient().DownloadString(cheatnamelink1); //Gets the value of your cheatnamelink1.txt and saves it as a string named cheat1
        public static string cheat2 = new WebClient().DownloadString(cheatnamelink2); //Gets the value of your cheatnamelink2.txt and saves it as a string named cheat2
        public static string cheat3 = new WebClient().DownloadString(cheatnamelink3); //Gets the value of your cheatnamelink2.txt and saves it as a string named cheat2

        public static string Auth = "http://ssense.ml/check.php"; //The link to check.php so you can authenticate
        public static string CheatName = "Cheat.dll"; // Cheat name
        public static string supportemail = "Mememem@gmail.com"; //Support email, only gmail (change port for other)
        public static string informationlink = "https://pastebin.com/raw/eLucATjS";
        public static bool helper = false; // Don´t change
        public static string UpdateLink = "https://pastebin.com/raw/hTB1usuQ"; // your Upade Link: https://imgur.com/a/7GAgcW8 (as RAW)
        public static decimal version = 1.0m;

        static string downloadlinklink1 = "https://pastebin.com/raw/KcfBWCmk"; // auto update DownLink1
        static string downloadlinklink2 = "https://pastebin.com/raw/zXy1HAGm"; // auto update DownLink2
        static string downloadlinklink3 = "https://pastebin.com/raw/jwM5JsQW"; // auto update DownLink2

        public static string DownLink = new WebClient().DownloadString(downloadlinklink1); // get your download link
        public static string DownLink2 = new WebClient().DownloadString(downloadlinklink2); // get your download link2
        public static string DownLink3 = new WebClient().DownloadString(downloadlinklink3); // get your download link2

        public static string credical_user = ""; // Your Gmail Username
        public static string credical_pass = ""; // Your Gmail Password

    }
}

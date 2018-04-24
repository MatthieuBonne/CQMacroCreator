﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace CQMacroCreator
{
    public class AppSettings
    {
        public string KongregateId { get; set; }
        public string token { get; set; }
        public int? actionOnStart { get; set; }
        public string defaultLowerLimit { get; set; }
        public string defaultUpperLimit { get; set; }
        public List<string> LoCLineup { get; set; }
        public List<string> MOAKLineup { get; set; }
        public List<string> defaultDQLineup { get; set; }
        public bool? DQSoundEnabled { get; set; }
        public bool? autoBestDQEnabled { get; set; }
        public bool? autoDQEnabled { get; set; }
        public bool? autoPvPEnabled { get; set; }
        public bool? autoChestEnabled { get; set; }
        public bool? autoWBEnabled { get; set; }
        public int? pvpLowerLimit { get; set; }
        public int? pvpUpperLimit { get; set; }
        public List<int> WBsettings { get; set; }

        public static AppSettings loadSettings()
        {            
            System.IO.StreamReader sr = new System.IO.StreamReader(Form1.SettingsFilename);
            AppSettings a = JsonConvert.DeserializeObject<AppSettings>(sr.ReadToEnd());
            sr.Close();
            return a;
        }

        public void saveSettings()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(Form1.SettingsFilename);
            sw.Write(json);
            sw.Close();
        }
    }
}
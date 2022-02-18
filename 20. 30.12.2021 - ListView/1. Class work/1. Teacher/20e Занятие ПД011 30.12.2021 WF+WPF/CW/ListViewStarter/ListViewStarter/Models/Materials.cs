using System.Collections.Generic;

namespace ListViewStarter.Models
{
    internal static class Materials
    {
        // справочник материалов 
        public static Dictionary<string, MaterialViewModel> Data = new Dictionary<string, MaterialViewModel>()
        {
            ["steel"]     = new MaterialViewModel {Name="нержавеющая сталь", Density=7850.0, ImageFile="steel.png"}, 
            ["copper"]    = new MaterialViewModel {Name="медь",              Density=8933.0, ImageFile="copper.png"}, 
            ["water_ice"] = new MaterialViewModel {Name="водяной лед",       Density= 916.7, ImageFile="water_ice.png"}, 
            ["granite"]   = new MaterialViewModel {Name="гранит",            Density=2600.0, ImageFile="granite.png"}, 
        };
    } // class Materials
}

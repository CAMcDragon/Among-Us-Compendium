using UnityEngine;

namespace Compendium
{
  public static class RainbowSkin
  {
    public static void Load()
    {
      var array = new[]
      {
        "RED",
        "BLUE",
        "GREEN",
        "PINK",
        "ORANGE",
        "YELLOW",
        "BLACK",
        "WHITE",
        "PURPLE",
        "BROWN",
        "CYAN",
        "LIME",
        "MELON",
        "CHOCOLATE",
        "LIGHTBLUE",
        "BEIGE",
        "LIGHTPINK",
        "TURQUOISE",
        "RAINBOW",
        "GALAXY",
        "FIRE",
      };
      
      var array2 = new[]
      {
        new Color32(198, 17, 17, byte.MaxValue),            // Red
        new Color32(19, 46, 210, byte.MaxValue),            // Blue
        new Color32(17, 128, 45, byte.MaxValue),            // Green
        new Color32(238, 84, 187, byte.MaxValue),           // Pink
        new Color32(240, 125, 13, byte.MaxValue),           // Orange
        new Color32(246, 246, 87, byte.MaxValue),           // Yellow
        new Color32(63, 71, 78, byte.MaxValue),             // Black
        new Color32(215, 225, 241, byte.MaxValue),          // White
        new Color32(107, 47, 188, byte.MaxValue),           // Purple
        new Color32(113, 73, 30, byte.MaxValue),            // Brown
        new Color32(56, byte.MaxValue, 221, byte.MaxValue), // Cyan
        new Color32(80, 240, 57, byte.MaxValue),            // Lime
        new Color32(168, 50, 62, byte.MaxValue),            // Melon
        new Color32(60, 48, 44, byte.MaxValue),             // Chocolate
        new Color32(61, 129, 255, byte.MaxValue),           // Light Blue
        new Color32(240, 211, 165, byte.MaxValue),          // Beige
        new Color32(236, 61, 255, byte.MaxValue),           // Light Pink
        new Color32(61, 255, 181, byte.MaxValue),           // Turquoise
        new Color32(0, 0, 0, byte.MaxValue),                // Rainbow
        new Color32(0, 0, 0, byte.MaxValue),                // Galaxy
        new Color32(0, 0, 0, byte.MaxValue),                // Fire
      };
      
      var array3 = new[]
      {
         new Color32(122, 8, 56, byte.MaxValue),      // Red
			    new Color32(9, 21, 142, byte.MaxValue),     // Blue
			    new Color32(10, 77, 46, byte.MaxValue),     // Green
			    new Color32(172, 43, 174, byte.MaxValue),   // Pink
			    new Color32(180, 62, 21, byte.MaxValue),    // Orange
			    new Color32(195, 136, 34, byte.MaxValue),   // Yellow
			    new Color32(30, 31, 38, byte.MaxValue),     // Black
			    new Color32(132, 149, 192, byte.MaxValue),  // White
			    new Color32(59, 23, 124, byte.MaxValue),    // Purple
			    new Color32(94, 38, 21, byte.MaxValue),     // Brown
			    new Color32(36, 169, 191, byte.MaxValue),   // Cyan
			    new Color32(21, 168, 66, byte.MaxValue),    // Lime
			    new Color32(168, 50, 62, byte.MaxValue),    // Melon
			    new Color32(60, 48, 44, byte.MaxValue),     // Chocolate
			    new Color32(61, 129, 255, byte.MaxValue),   // Light Blue
			    new Color32(240, 211, 165, byte.MaxValue),  // Beige
			    new Color32(236, 61, 255, byte.MaxValue),   // Light Pink
			    new Color32(61, 255, 181, byte.MaxValue),   // Turquoise
			    new Color32(0, 0, 0, byte.MaxValue),        // Rainbow
			    new Color32(0, 0, 0, byte.MaxValue),        // Galaxy
			    new Color32(0, 0, 0, byte.MaxValue),        // Fire
      };
      
      var array4 = new string[]
      {
        "Red",
        "Blue",
        "Green",
        "Pink",
        "Orange",
        "Yellow",
        "Black",
        "White",
        "Purple",
        "Brown",
        "Cyan",
        "Lime",
        "Watermelon",
        "Chocolate",
        "Sky Blue",
        "Beige",
        "Hot Pink",
        "Turquoise",
        "Rainbow",
        "Galaxy",
        "Fire"
      };
      
      ShortColorNames = array;
      PlayerColors = array2;
      ShadowColors = array3;
      MedScanColorNames = array4;
    }
  }
}

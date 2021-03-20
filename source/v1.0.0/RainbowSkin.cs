using HarmonyLib;
using System;
using UnityEngine;

namespace Compendium
{
  public static class PalettePatch
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
	
	[HarmonyPatch(typeof(PlayerTab), nameof(PlayerTab.OnEnable))]
	public class PlayerTabPatch
	{
		public static void Postfix(PlayerTab __instance)
		{
			foreach(var chip in __instance.Field_8)
			{
				chip.transform.localScale *= 0.65f;
			}
		}
	}
	
	public class RainbowBehavior : NomoBehavior
	{
		public Renderer Renderer;
		public int Id;
	}
	
	public class RainbowUtilities
	{
		private static readonly int BackColor = Shader.PropertyToID("_BackColor");
		private static readonly int BodyColor = Shader.PropertyToID("_BodyColor");
		private static readonly int VisorColor = Shader.PropertyToID("_VisorColor");
		
		public static Color Rainbow => new HSBColor(PP(0, 1, 0.8f), 1, 1).ToColor();
		public static Color RainbowShadow => Shadow(Rainbow);
		
		public static Color Galaxy => new HSBColor(PP(0.5f, 0.87f, 0.4f), 1, 1).ToColor();
		public static Color GalaxyShadow => Shadow(Galaxy);
		
		public static Color Fire => new HSBColor(PP(0f, 0.17f, 0.4f), 1, 1).ToColor();
		public static Color FireShadow => Shadow(Fire);
		
		public static float PP(float min, float max, float mul)
		{
			return min + Mathf.PingPong(Time.time * mul, max - min);
		}
		
		public static Color Shadow(Color color)
		{
			return new Color(color.r - 0.3f, color.g - 0.3f, color.b - 0.3f);
		}
		
		public static void SetRainbow(Renderer rend)
		{
			rend.material.SetColor(BackColor, RainbowShadow);
			rend.material.SetColor(BodyColor, Rainbow);
			rend.material.SetColor(VisorColor, Palette.VisorColor);
		}
		
		public static void SetGalaxy(Renderer rend)
		{
			rend.material.SetColor(BackColor, GalaxyShadow);
			rend.material.SetColor(BodyColor, Galaxy);
			rend.material.SetColor(VisorColor, Palette.VisorColor);
		}
		
		public static void SetFire(Renderer rend)
		{
			rend.material.SetColor(BackColor, FireShadow);
			rend.material.SetColor(BodyColor, Fire);
			rend.material.SetColor(VisorColor, Palette.VisorColor);
		}
		
		public static bool IsRainbow(int id)
		{
			return Palette.ShortColorNames[id] == "RAINBOW";
		}
		
		public static bool IsFire(int id)
		{
			return Palette.ShortColorNames[id] == "FIRE";
		}
	}
	
	[Serializable]
	public struct HSBColor
	{
		public float h;
		public float s;
		public float b;
		public float a;
		
		public HSBColor(float h, float s, float b, float a)
		{
			this.h = h;
			this.s = s;
			this.b = b;
			this.a = a;
		}
		
		public HSBColor(float h, float s, float b)
		{
			this.h = h;
			this.s = s;
			this.b = b;
			a = 1f;
		}
		
		public HSBColor(Color color)
		{
			var temp = FromColor(color);
			h = temp.h;
			s = temp.s;
			b = temp.b;
			a = temp.a;
		}
		
		public static HSBColor FromColor(Color color)
		{
			var ret = new HSBColor(0f, 0f, 0f, color.a);
			var r = color.r;
			var g = color.g;
			var b = color.b;
			var max = Mathf.Max(r, Mathf.Max(g, b));
			
			if(max <= 0)
			{
				return ret;
			}
			
			var min = Mathf.Min(r, Mathf.Min(g, b));
			var dif = max - min;
			
			if(max > min)
			{
				if(g == max)
				{
					ret.h = (b - r) / dif * 60f + 120f;
				}
				else if(b == max)
				{
					ret.h = (r - g) / dif * 60f + 240f;
				}
				else if(b > g)
				{
					ret.h = (g - b) / dif * 60f + 360f;
				}
				else
				{
					ret.h = (g - b) / dif * 60f;
				}
				
				if(ret.h < 0)
				{
					ret.h = ret.h + 360f;
				}
			}
			else
			{
				ret.h = 0;
			}
			
			ret.h *= 1f / 360f;
			ret.s = (dif / max) * 1f;
			ret.b = max;
			
			return ret;
		}
		
		public static Color ToColor(HSBColor hsbColor)
		{
			var r = hsbColor.b;
			var g = hsbColor.b;
			var b = hsbColor.b;
			
			if(hsbColor.s != 0)
			{
				var max = hsbColor.b;
				var dif = hsbColor.b * hsbColor.s;
				var min = hsbColor.b - dif;
				var h = hsbColor.h * 360f;
				
				if(h < 60f)
				{
					r = max;
					g = h * dif / 60f + min;
					b = min;
				}
				else if(h < 120f)
				{
					r = -(h - 120f) * dif / 60f + min;
					g = max;
					b = min;
				}
				else if(h < 180f)
				{
					r = min;
					g = max;
					b = (h - 120f) * dif / 60f + min;
				}
				else if(h < 240f)
				{
					r = min;
					g = -(h - 240f) * dif / 60f + min;
					b = max;
				}
				else if(h < 300f)
				{
					r = (h - 240f) * dif / 60f + min;
					g = min;
					b = max;
				}
				else if(h <= 360f)
				{
					r = max;
					g = min;
					b = -(h - 360f) * dif / 60 + min;
				}
				else
				{
					r = 0;
					g = 0;
					b = 0;
				}
			}
			
			return new Color(Mathf.Clamp01(r), Mathf.Clamp01(g), Mathf.Clamp01(b), hsbColor.a);
		}
		
		public Color ToColor()
		{
			return ToColor(this);
		}
		
		public override string ToString()
		{
			return "H:" + h + " S:" + s + " B:" + b;
		}
		
		public static HSBColor Lerp(HSBColor a, HSBColor b, float t)
		{
			float h, s;
			
			if(a.b == 0)
			{
				h = b.h;
				s = b.s;
			}
			else if(b.b == 0)
			{
				h = a.h;
				s = a.s;
			}
			else
			{
				if(a.s == 0)
				{
					h = b.h;
				}
				else if(b.s == 0)
				{
					h = a.h;
				}
				else
				{
					var angle = Mathf.LerpAngle(a.h * 360f, b.h * 360f, t);
					
					while(angle < 0f)
					{
						angle += 360f;
					}
					
					while(angle > 360f)
					{
						angle -= 360f;
					}
					
					h = angle / 360f;
				}
				
				s = Mathf.Lerp(a.s, b.s, t)
			}
			
			return new HSBColor(h, s, Mathf.Lerp(a.b, b.b, t), Mathf.Lerp(a.a, b.a, t));
		}
		
		public static void Test()
		{
			var color = new HSBColor(Color.red);
			Debug.Log("red: " + color);

			color = new HSBColor(Color.green);
			Debug.Log("green: " + color);

			color = new HSBColor(Color.blue);
			Debug.Log("blue: " + color);

			color = new HSBColor(Color.grey);
			Debug.Log("grey: " + color);

			color = new HSBColor(Color.white);
			Debug.Log("white: " + color);

			color = new HSBColor(new Color(0.4f, 1f, 0.84f, 1f));
			Debug.Log("0.4, 1f, 0.84: " + color);

			Debug.Log("164,82,84   .... 0.643137f, 0.321568f, 0.329411f  :" + ToColor(new HSBColor(new Color(0.643137f, 0.321568f, 0.329411f))));
		}
	}
	
	[HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.SetPlayerMaterialColors), typeof(int), typeof(Renderer))]
	public class SetPlayerMaterialPatch
	{
		public static bool Prefix([HarmonyArgument(0)] int colorId, [HarmonyArgument(1)] Renderer rend)
		{
			var r = rend.gameObject.GetComponent<RainbowBehavior>();
			
			if(r == null)
			{
				r = rend.gameObject.AddComponent<RainbowBehavior>();
			}
			
			r.AddRend(rend, colorId);
			return !RainbowUtils.IsRainbow(colorId);
		}
	}
}

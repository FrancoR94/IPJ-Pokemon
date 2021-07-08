using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


public static class ReadPokemonFile
{
	public static Pokemon ReadPokemonFromFile(string path)
	{
		Pokemon P = new Pokemon();

		string[] lines = File.ReadAllLines(path);

		P.name = lines[0];
		P.level = Convert.ToInt32(lines[1]);

		string[] types = lines[2].Split(" ");
		for (int i = 0; i < types.Length; i++)
		{
			P.types.Add(Type.GetInstance().GetType(types[i]));
		}

		P.life = Convert.ToInt32(lines[3]);
		P.maxLife = Convert.ToInt32(lines[3]);
		P.attack = Convert.ToInt32(lines[4]);
		P.specialAttack = Convert.ToInt32(lines[5]);
		P.defense = Convert.ToInt32(lines[6]);
		P.specialDefense = Convert.ToInt32(lines[7]);
		P.speed = Convert.ToInt32(lines[8]);
		if (lines.Length >= 9)
		{
			P.moves.Add(MovementDatabase.GetMovement(lines[9]));
		}
		if (lines.Length >= 10)
		{
			P.moves.Add(MovementDatabase.GetMovement(lines[10]));
		}
		if (lines.Length >= 11)
		{
			P.moves.Add(MovementDatabase.GetMovement(lines[11]));
		}
		if (lines.Length >= 12)
		{
			P.moves.Add(MovementDatabase.GetMovement(lines[12]));
		}

		return P;
	}
	public static class MovementDatabase
	{
		public static Movement GetMovement(string movementName)
		{

			/*switch (movementName)
			{
				case "Latigo cepa":
					return new Latigocepa();
				case "Danza petalo":
				return new Placaje();
				case "Drenadoras":

				case "Tormenta floral":

				default: ACA IRIA EL RETURN
			}*/
					return GetMovement("");
		}		
			
		}
	}


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
		P.maxLife = Convert.ToInt32(lines[4]);
		P.attack = Convert.ToInt32(lines[5]);
		P.specialAttack = Convert.ToInt32(lines[6]);
		P.defense = Convert.ToInt32(lines[7]);
		P.specialDefense = Convert.ToInt32(lines[8]);
		P.speed = Convert.ToInt32(lines[9]);
		
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
		if (lines.Length >= 13)
		{
			P.moves.Add(MovementDatabase.GetMovement(lines[13]));
		}

		return P;
	}
	public static class MovementDatabase
	{
		public static Movement GetMovement(string movementName)
		{
			switch (movementName)
			{
				case "Latigo cepa":
					return new LatigoCepa();
				case "Danza petalo":
					return new Placaje();
				case "Drenadoras":
					return new Drenadoras();
				case "Tormenta floral":
					return new TormentaFloral();
				case "Tornado":
					return new Tornado();
				case "Psicorrayo":
					return new Psicorrayo();
				case "Viento plata":
					return new VientoPlata();
				case "Paralizador":
					return new Paralizador();
				case "Maldicion":
					return new Maldicion();
				case "Tinieblas":
					return new Tinieblas();
				case "Puno sombra":
					return new PunoSombra();
				case "Bola sombra":
					return new BolaSombra();
				case "Impactrueno":
					return new Impactrueno();
				case "Ataque rapido":
					return new AtaqueRapido();
				case "Colmillo rayo":
					return new ColmilloRayo();
				case "Onda trueno":
					return new OndaTrueno();
				case "Ascuas":
					return new Ascuas();
				case "Lanzallamas":
					return new Lanzallamas();
				case "Giro fuego":
					return new GiroFuego();
				case "Velo sagrado":
					return new VeloSagrado();
				case "Vendaval":
					return new Vendaval();
				case "Ataque ala":
					return new AtaqueAla();
				case "Ciclon":
					return new Ciclon();
				case "Burbuja":
					return new Burbuja();
				case "Hidrobomba":
					return new Hidrobomba();
				case "Defensa ferrea":
					return new DefensaFerrea();
				case "Pistola de agua":
					return new PistolaDeAgua();
				case "Hidrochorro":
					return new Hidrochorro(); 
				case "Acua cola":
					return new AcuaCola();
				case "Acua jet":
					return new AcuaJet();
				case "Rayo confuso":
					return new RayoConfuso();
				case "Rayo hielo":
					return new RayoHielo();
				case "Megacuerno":
					return new MegaCuerno();
				case "Cascada":
					return new Cascada();
				case "Agilidad":
					return new Agilidad();
				case "Puya nociva":
					return new PuyaNociva();
				case "Placaje":
					return new Placaje();
				case "Relajo":
					return new Relajo();
				case "Bostezo":
					return new Bostezo();
				case "Rayo burbuja":
					return new RayoBurbuja();
				case "Giro rapido":
					return new GiroRapido();
				default:
			return GetMovement("");
			}
		}
			
		}
	}


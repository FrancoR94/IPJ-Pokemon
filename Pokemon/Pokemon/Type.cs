using System;
using System.Collections.Generic;
using System.Text;

public enum Tipo { Fuego, Agua, Planta, Normal, Veneno, Volador, Electrico, Fantasma, Bicho, Hielo, Psiquico, Roca, Tierra, Error }

public class Type
{
    private Dictionary<string, Tipo> typesDatabase = new Dictionary<string, Tipo>();
    private static Type instance;
    public static Type GetInstance()
    {
        if (instance == null)
        {
            instance = new Type();
        }
        return instance;
    }
    private Type()
    {
        typesDatabase.Add("Fuego", Tipo.Fuego);
        typesDatabase.Add("Agua", Tipo.Agua);
        typesDatabase.Add("Planta", Tipo.Planta);
        typesDatabase.Add("Normal", Tipo.Normal);
        typesDatabase.Add("Veneno", Tipo.Veneno);
        typesDatabase.Add("Volador", Tipo.Volador);
        typesDatabase.Add("Electrico", Tipo.Electrico);
        typesDatabase.Add("Fantasma", Tipo.Fantasma);
        typesDatabase.Add("Bicho", Tipo.Bicho);
        typesDatabase.Add("Hielo", Tipo.Hielo);
        typesDatabase.Add("Psiquico", Tipo.Psiquico);
        typesDatabase.Add("Roca", Tipo.Roca);
        typesDatabase.Add("Tierra", Tipo.Tierra);
    }
    public Tipo GetType(string typeName)
    {
        if (typesDatabase.ContainsKey(typeName))
        {
            return typesDatabase[typeName];
        }
        else
        {
            Console.WriteLine("Error!");
            return Tipo.Error;
        }
    }
}

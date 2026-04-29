namespace misCabañas.Models;

public class Complejo
{
    Dictionary<int, Cabania> Cabanias;
    public Complejo()
    {
        Cabanias = new Dictionary<int, Cabania>();
        CargaManual();
    }
    
    public void CargaManual()
    {
        Cabania C1 = new Cabania(01, "LosPitufos", "Cabania ambientada en los bosques del Iguazú", 3, new List<string>("algo"), new List<string>("Cama doble", "Cocina equipada", "Salida directa al lago"));
        Cabania C2 = new Cabania(02, "T-Rexes", "Nacidos en el cretácico", 1, new List<string>("algo"), new List<string>("Cama simple", "Baño completo", "Cuadros históricos de dinosaurios"));
        Cabania C3 = new Cabania(03, "Botecrollers", "Salidos de los mares y habitados en las playas cilbestres", 6, new List<string>("algo"), new List<string>("Dos Triples literas", "Dos pisos", "Juegos de mesa incluidos"));
        Cabania C4 = new Cabania(04, "Chocorío", "Cabania ambientada en los bosques del Iguazú", 10, new List<string>("algo"), new List<string>("Nueve camas simples", "Cocina sin nada", "Jacuzzi, Metegol, Ping Pong y Bowling"));

        Cabanias.Add(C1.GetID(), C1);
        Cabanias.Add(C2.GetID(), C2);
        Cabanias.Add(C3.GetID(), C3);
        Cabanias.Add(C4.GetID(), C4);
    }

    public Dictionary<int, Cabania> DevolverCabanias()
    {
        return Cabanias;
    }
    public Cabania GetCabania(int ID)
    {
        if (Cabanias.ContainsKey(ID))
        {
            return Cabanias[ID];
        }
        return null;
    }
}


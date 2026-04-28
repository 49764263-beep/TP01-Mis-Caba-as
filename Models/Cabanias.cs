namespace misCabañas.Models;

public class Cabanias 
{
    private int ID;
    private string Nombre;
    private string Descripcion;
    private int Capacidad;
    private List<string> Fotos;
    private List<string> Ambientes;

    public Cabanias(int id, string nombre, string descripcion, int capacidad, List<string> fotos, List<string> ambientes) 
    {
        ID = id;
        Nombre = nombre;
        Descripcion = descripcion;
        Capacidad = capacidad;
        Fotos = fotos;
        Ambientes = ambientes;
    }

    public int GetDNI() 
    {
        return ID; 
    }
    public string GetNombre() 
    { 
        return Nombre; 
    }
    public string GetDescripcion() 
    {
        return Descripcion; 
    }
     public int GetCapacidad() 
    {
        return Capacidad; 
    }
    public List<string> GetFotos() 
    { 
        return Fotos; 
    }
    public List<string> GetAmbiente()
    { 
        return Ambientes; 
    }
}
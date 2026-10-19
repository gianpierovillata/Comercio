namespace Comercio.Domain.Entities;

public class Cliente
{
    public int Id  {get; set;}

    public string Nombre {get;set;} = string.Empty;

    public int Nivel {get;set;} = 1;
}
using ENTIDADES.Categoria;
using ENTIDADES.Estado;

namespace ENTIDADES;

public class Producto
{
    public int id {get; private set;}

    public string Nombre{get; set;}="";

    public string Descripcion {get; set;}= "";

    public decimal Precio {get; set;}

    public int Cantidad {get; set;}

    public CategoriaProducto Categoria {get; set;}

    public EstadoProducto Estado {get; set;}=EstadoProducto.Activo;
    public DateTime Fecharegistro {get; set;}= DateTime.Now;

    public decimal valorTotal => Precio * Cantidad;

    public override string ToString() => $"[{id}] {Nombre} ${Precio:N2} x {Cantidad} = ${valorTotal:N2}";
}
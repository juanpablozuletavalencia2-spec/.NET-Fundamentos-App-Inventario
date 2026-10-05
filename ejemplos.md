dotnet run -- Hola mundo
args[0]Hola
args[1]Mundo



tipoRetorno NombreMetodo(tipo parametro1, tipo parametro2){
    ccuerpo
    return 
};


int numeroGlobal=100;

void MetodoA(){
    int numerolocal = 5;
    WriteLine(numeroGlobal);
    WriteLine(numeroGlobal);
    return numeroLocal;
}
void MetodoB(){
    numeroLocalB=MetodoA();
    WriteLine(numeroGlobal)
}
//Uso
MetodoA();
MetodoB();

// Clases
class producto
{
    public int Id {get; set;}
    public string Nombre{get; set;} = "Productos"
    public decimal Precio{get; set;}
}
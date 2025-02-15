void saludar()
{
    Console.Write("Hola!");
}

int suma (int n1, int n2)
{
    int resultado = 0;
    resultado = n1+ n2;
    return resultado;
}
saludar();
int multi(int n3, int n4)
   
{
    
    int resultado = 0;
    resultado = n3 * n4;
    return resultado;
    
   
    
   

}
int param1;
int param2;
param1 = 10;
param2 = 20;
int respuesta = suma(5, 9);
int respuestaMul = multi(param1, param2);
respuesta = multi(5, 9);
Console.WriteLine($"La suma es:{respuesta}");


Console.WriteLine($"La multiplicacion es:{respuesta}");



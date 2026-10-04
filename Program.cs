using System;
using System.Diagnostics.CodeAnalysis;
namespace act9{
class Program
{
    static void Main()
    {
        // 1. leer nombre y apellido por separado e imprimir juntos.
        Console.WriteLine("consigna 1");
        Console.WriteLine("ingresa tu nombre: ");
        string datonombre = Console.ReadLine()!;
        Console.WriteLine("ingresa tu apellido: ");
        string datoapellido = Console.ReadLine()!;
        Console.WriteLine($"{datonombre} {datoapellido}");

        // 2. leer una oracion y contar cuantas letras tiene (sin espacios).
        Console.WriteLine("consigna 2");
        string textoentrada = "hansel y gretel";
        textoentrada = textoentrada.Replace(" ", "");
        Console.WriteLine($"cantidad de caracteres: {textoentrada.Length}");

        // 3. convertir texto a mayusculas y luego a minusculas.
        Console.WriteLine("consigna 3");
        string fraseoriginal = "profe aprobame porfavor el tp integrador es muy dificil";
        string textoenmayus = fraseoriginal.ToUpper();
        string textoenminus = fraseoriginal.ToLower();
        Console.WriteLine(fraseoriginal);
        Console.WriteLine(textoenmayus);
        Console.WriteLine(textoenminus);

        // 4. verificar si una palabra ingresada contiene la letra 'a'.
        Console.WriteLine("consigna 4");
        Console.WriteLine("escribe una palabra: ");
        string palabrabuscada = Console.ReadLine()!;
        if (palabrabuscada.Contains("a") == true)
        {
            Console.WriteLine("si tiene la letra a");
        }
        else
        {
            Console.WriteLine("no se encontro la letra a");
        }

        // 5. reemplazar todos los espacios de una frase por guiones.
        Console.WriteLine("consigna 5");
        string textoespacios = "Aprobando POO antes de GTA VI?";
        string textoguiones = textoespacios.Replace(" ", "-");
        Console.WriteLine("antes: " + textoespacios);
        Console.WriteLine("despues: " + textoguiones);

        // 6. separar una frase en palabras con split e imprimir cada una.
        Console.WriteLine("consigna 6");
        string titulooracion = "el eterno resplandor de una mente sin recuerdos";
        string[] arreglovector = titulooracion.Split(' ');
        Console.WriteLine("cadena base: " + titulooracion);
        for (int i = 0; i < arreglovector.Length; i++)
        {
            Console.WriteLine(arreglovector[i]);
        }

        // 7. verificar si dos strings son iguales ignorando mayusculas.
        Console.WriteLine("consigna 7");
        string texto1 = "mOrdecAI";
        string texto2 = "MorDecai";
        if (texto1.ToLower() == texto2.ToLower())
        {
            Console.WriteLine("son el mismo texto sin importar mayusculas");
        }
        else
        {
            Console.WriteLine("son textos distintos");
        }

        // 8. leer un numero como string y convertirlo a int con int.parse.
        Console.WriteLine("consigna 8");
        Console.WriteLine("ingresar un numero: ");
        string cadenaingresada = Console.ReadLine()!;
        int numeroentero = int.Parse(cadenaingresada);
        Console.WriteLine("cuando se suma la cadena con el entero yaconvertido en vez de calcular se terminan juntando los dos valores:");
        Console.WriteLine(cadenaingresada + numeroentero);

        // 9. crear un 'formulario' que pida nombre, edad y ciudad.
        Console.WriteLine("consigna 9");
        Console.WriteLine("ingresa tu nombre: ");
        string usuario = Console.ReadLine()!;
        Console.WriteLine("ingresa tu edad: ");
        string edadingresada = Console.ReadLine()!;
        Console.WriteLine("ingresa tu ciudad: ");
        string localidad = Console.ReadLine()!;
        Console.WriteLine($"nombre: {usuario}");
        Console.WriteLine($"edad: {edadingresada}");
        Console.WriteLine($"origen: {localidad}");

        // 10. verificar si un string es palindromo (igual al reves)
        Console.WriteLine("consigna 10");
        string fraseanalizar = "somos o no somos";
        string limpadirecto = fraseanalizar.ToLower().Replace(" ", "");
        string limpainvertido = "";
        for (int i = limpadirecto.Length - 1; i >= 0; i--)
        {
            limpainvertido = limpainvertido + limpadirecto[i];
        }
        Console.WriteLine(limpainvertido);
        if (limpainvertido == limpadirecto)
        {
            Console.WriteLine("es un palindromo perfecto");
        }
        else
        {
            Console.WriteLine("no se lee igual al reves");
        }
    }
}
}
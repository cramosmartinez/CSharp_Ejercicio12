//Crea un programa que pida por consola un numero del 1 al 1000 
//(validara que el numero introducido es correcto) y sume todos los números del 1 al numero 
//introducido, mostrando por consola el numero de la suma y la media.
Console.WriteLine("Ingrese un número del 1 al 1000:");
int numero124 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Número ingresado: " + numero124);
Console.WriteLine("Suma de los números del 1 al " + numero124 + ": " + (numero124 * (numero124 + 1) / 2));
Console.WriteLine("Media de los números del 1 al " + numero124 + ": " + (numero124 + 1) / 2);
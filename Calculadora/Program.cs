/* Abel Felix Tejada Barranco - 20250922*/

using System;

bool seguirEjecutando = true;

while (seguirEjecutando)
{

    try
    {
       
        Console.WriteLine("== CALCULADORA ==");
        Console.WriteLine("Seleccione la operacion que desea realizar");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicacion");
        Console.WriteLine("4. Division");
        Console.WriteLine("5: Calcular Aprobacion de un estudiante");
        Console.WriteLine("6: Salir");

        Console.WriteLine("Digite el numero de la operacion que desea realizar: ");
        int typedOption = Convert.ToInt32(Console.ReadLine());

        switch (typedOption)
        {
            case 1:
            case 2:
            case 3:
            case 4:

                Console.WriteLine("Digite el primer numero: ");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite el segundo numero: ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                double result;


                switch (typedOption)
                {
                    case 1:
                        result = firstNumber + secondNumber;
                        Console.WriteLine($"El resultado de la suma es: {result}");
                        break;
                    case 2:
                        result = firstNumber - secondNumber;
                        Console.WriteLine($"El resultado de la resta es: {result}");
                        break;
                    case 3:
                        result = firstNumber * secondNumber;
                        Console.WriteLine($"El resultado de la multiplicacion es: {result}");
                        break;
                    case 4:
                        if (secondNumber != 0)
                        {
                            result = firstNumber / secondNumber;
                            Console.WriteLine($"El resultado de la division es: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                        }
                        break;
                }
                break;

            case 5:
                Console.WriteLine("Digite la nota del estudiante: ");
                double studentGrade = Convert.ToDouble(Console.ReadLine());
                if (studentGrade >= 60)
                {
                    Console.WriteLine("El estudiante ha aprobado.");
                }
                else
                {
                    Console.WriteLine("El estudiante ha reprobado.");
                }
                break;

            case 6:
                seguirEjecutando = false;
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opcion no valida. Por favor, seleccione una opcion del 1 al 6.");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine($"Error: Ingrese un numero valido.");
        
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Error: No se puede dividir entre cero.");
    }
    catch (Exception)
    {
        Console.WriteLine("Error: Ocurrio un error inesperado.");
    }

    finally
    {
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadLine();
    }

}





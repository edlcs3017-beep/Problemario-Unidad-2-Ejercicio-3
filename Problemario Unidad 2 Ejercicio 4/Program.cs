// Se declaran las variables necesarias.
double temperatura, suma = 0, promedio;

// CICLO FOR: solicita las cinco temperaturas del motor.
for (int i = 1; i <= 5; i++)
{
    Console.Write($"Introduce la temperatura {i} del motor (°C): ");
    temperatura = Convert.ToDouble(Console.ReadLine());

    // Se acumulan las temperaturas ingresadas.
    suma += temperatura;
}

// Se calcula el promedio de las cinco mediciones.
promedio = suma / 5;

// Se muestra el promedio con su unidad.
Console.WriteLine($"Temperatura promedio: {promedio:F2} °C");

// Se determina el estado del motor.
Motor motor = new Motor();
motor.Temperatura = promedio;
motor.VerificarTemperatura();

// CLASE: representa un motor eléctrico.
class Motor
{
    // PROPIEDAD: almacena la temperatura promedio en °C.
    public double Temperatura { get; set; }

    // MÉTODO: verifica si la temperatura es normal o elevada.
    public void VerificarTemperatura()
    {
        if (Temperatura <= 70)
        {
            Console.WriteLine("Estado del motor: NORMAL");
        }
        else
        {
            Console.WriteLine("Estado del motor: ALERTA DE TEMPERATURA");
        }
    }
}

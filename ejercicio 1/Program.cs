Console.WriteLine("Ingrese el tipo de atencion que requiere el paciente \n1 Emergencia\n2 Consulta\n3 Pediatría\n4 Traumatología");
int opcion = int.Parse(Console.ReadLine());
Console.WriteLine("Edad:");
double edad = double.Parse(Console.ReadLine());
Console.WriteLine("Temperatura:");
double temp = double.Parse(Console.ReadLine());
Console.WriteLine("Saturación de oxígeno:");
double oxigeno = double.Parse(Console.ReadLine());
Console.WriteLine("Nivel de dolor (0-10):");
int dolor = int.Parse(Console.ReadLine());
Console.WriteLine("Presión sistólica:");
double presion = double.Parse(Console.ReadLine());
if (edad > 0 && edad <= 120 && temp >= 30 && temp <= 45 &&oxigeno >= 0 && oxigeno <= 100 &&dolor >= 0 && dolor <= 10 &&presion >= 50 && presion <= 250)
{
    Console.WriteLine("Datos correctos");
    Console.WriteLine("Procesando...");

    switch (opcion)
    {
        case 1:
            if (oxigeno < 90 || presion < 90 || presion > 140)
            {
                Console.WriteLine("Prioridad alta");
                Console.WriteLine("Acción sugerida: Reanimación inmediata");
            }
            else
            {
                if (temp >= 38.5 || temp < 35)
                {
                    Console.WriteLine("Prioridad alta");
                    Console.WriteLine("Acción sugerida: Evaluación médica urgente");
                }
                else if (dolor >= 5)
                {
                    Console.WriteLine("Prioridad media");
                    Console.WriteLine("Acción sugerida: Evaluación médica en breve");
                }
                else
                {
                    Console.WriteLine("Prioridad baja");
                    Console.WriteLine("Acción sugerida: Evaluación médica programada");
                }
            }
            break;
        case 2:
            if (oxigeno > 90 && oxigeno <= 100 && presion >= 90 && presion <= 120 && temp >= 35.5 && temp < 38)
            {
                Console.WriteLine("Oxigeno y presion dentro del rango normal");
                Console.WriteLine("Acción sugerida: Consulta general para chequo de salud");
            }
            else if (dolor > 5)
            {
                Console.WriteLine("Nivel de dolor medio");
                Console.WriteLine("Acción sugerida: Consulta médica para evaluación del dolor");
            }
            else
            {
                Console.WriteLine("pasar a emergencia");
            }

            break;
        case 3:
            if (edad < 12 && temp >= 38.5)
            {
                Console.WriteLine("Prioridad alta");
                Console.WriteLine("Acción sugerida: Evaluación médica urgente");
            }
                else if (edad < 12 && temp >= 37.5 && temp < 38.5)
                {
                    Console.WriteLine("Prioridad media");
                    Console.WriteLine("Acción sugerida: Evaluación médica en breve");
                }
                else
                {
                    Console.WriteLine("Prioridad baja");
                    Console.WriteLine("Acción sugerida: Evaluación médica programada");
            }
            break;

            case 4:
            if (edad >12  && dolor>6 )
            {
                Console.WriteLine("Prioridad alta");
                Console.WriteLine("Acción sugerida:atencion traumatologica urgente ");
            }
            else if (edad < 12 && dolor<0)
            {
                Console.WriteLine("Prioridad Alta");
                Console.WriteLine("Acción sugerida:atencion traumatologica urgente y llamar a un pediatra para revision general");
            }
            else
            {
                Console.WriteLine("Prioridad baja");
                Console.WriteLine("Acción sugerida: Evaluación médica programada");
            }
            break;
            default:
            Console.WriteLine("Opción no válida");
            break;
    }
}
else
{
    Console.WriteLine("Inicie nuevamente");
}

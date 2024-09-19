char caracter;
int verde = 0, azul = 0, rojo = 0;
bool is_finished = false;
do
{
    Console.Write("Ingrese el ultimo digito de la placa: ");
    caracter = Convert.ToChar(Console.ReadLine());
    switch (caracter)
    {
        case '1':
        case '2':
        case '3':
            verde++;
            break;
        case '4':
        case '5':
        case '6':
            azul++;
            break;
        case '7':
        case '8':
        case '9':
            rojo++;
            break;
        case 'f':
        case 'F':
            is_finished = true;
            break;
    }
} while (is_finished == false);

Console.WriteLine($"verde: {verde}");
Console.WriteLine($"azul: {azul}");
Console.WriteLine($"rojo: {rojo}");
string name;
double salarioBruto, ventas, years, totalGanado = 0;
double descuento = 0, salarioNeto;

Console.Write("Nombre: ");
name = Convert.ToString(Console.ReadLine());
Console.Write("Salario bruto: ");
salarioBruto = Convert.ToDouble(Console.ReadLine());
Console.Write("Ventas: ");
ventas = Convert.ToDouble(Console.ReadLine());
Console.Write("Años en empresa: ");
years = Convert.ToDouble(Console.ReadLine());

totalGanado += salarioBruto;

//sumando comision
if (ventas > 0 && ventas <=600)
{
    totalGanado += ventas * 0.05;
}
else if ( ventas > 600 && ventas <= 3000)
{
    totalGanado += ventas * 0.07;
}
else if (ventas > 3000)
{
    totalGanado += 300 + ventas * 0.06;
}

//descuento de impuestos
if (years <= 3)
{
    descuento = totalGanado * 0.065;
}
else if ( years >= 4)
{
    descuento = totalGanado * 0.045;
}

salarioNeto = totalGanado - descuento;

//output
Console.WriteLine($"Nombre: {name}");
Console.WriteLine($"Total ganado: S/{totalGanado}");
Console.WriteLine($"Descuento: S/{descuento}");
Console.WriteLine($"Salario neto: S/{salarioNeto}");
using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.Write("Ingrese el nombre del cliente: ");
string cliente = Console.ReadLine() ?? string.Empty;

Console.Write("Ingrese el número de cuenta: ");
string cuenta = Console.ReadLine() ?? string.Empty;

Console.Write("Ingrese el tipo de cuenta: ");
string tipo = Console.ReadLine() ?? string.Empty;

Console.Write("Ingrese el saldo actual: ");
string saldoInput = Console.ReadLine() ?? "0";
saldoInput = saldoInput.Replace("RD$", "", StringComparison.OrdinalIgnoreCase).Replace("$", "").Trim();

if (!decimal.TryParse(saldoInput, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal saldo))
{
    decimal.TryParse(saldoInput, NumberStyles.Any, CultureInfo.CurrentCulture, out saldo);
}

Console.WriteLine();
Console.WriteLine("==============================");
Console.WriteLine("       INFORMACIÓN CUENTA     ");
Console.WriteLine("==============================");
Console.WriteLine();
Console.WriteLine($"Cliente: {cliente}");
Console.WriteLine($"Cuenta: {cuenta}");
Console.WriteLine($"Tipo: {tipo}");
Console.WriteLine($"Saldo: RD${saldo.ToString("N2", CultureInfo.InvariantCulture)}");
Console.WriteLine();
Console.WriteLine("==============================");

// See https://aka.ms/new-console-template for more information
int idade, local;
Console.WriteLine("----- CENTRO DE ORTOPEDIA -----");
Console.WriteLine("- Digite seu nome e sua idade, respectivamente.");
string nome = Console.ReadLine();
idade = int.Parse(Console.ReadLine());
Console.WriteLine($"- Olá, {nome}! Digite seu sintoma e será redirecionado ao médico indicado. | 1 - Ossos. | 2 - Músculos e tendões. | 3 - Ligamentos e articulações. | 4 - Coluna vertebral. | 5 - Pés e mãos.");
local = int.Parse(Console.ReadLine());
if (local == 1)
{
    Console.WriteLine($"{local} - Conforme seus sintomas, te indicamos o Dr. Rafael, um ortopedista especializado em fraturas, osteoporose e deformidades congênitas.");
    if (local == 2)
    {
        Console.WriteLine($"{local} - Conforme seus sintomas, te indicamos o Dr. Ricardo, um ortopedista especializado em contraturas, tendinites e encurtamentos.");
    }
    else if (local == 3)
    {
        Console.WriteLine($"{local} - Conforme seus sintomas, te indicamos o Dr. Rogério, um ortopedista especializado em entorses, luxações, artrose e bursite.");
    }
}
else if (local == 4)
{
    Console.WriteLine($"{local} - Conforme seus sintomas, te indicamos o Dr. Rodrigo, um ortopedista especializado em hérnias de disco, escoliose, lordose e cifose.");
}
else if (local == 5)
{
    Console.WriteLine($"{local} - Conforme seus sintomas, te indicamos o Dr. Rodolfo, um ortopedista especializado em pés tortos, joelhos varos ou valgos, torcicolos e alterações anatômicas.");
}
else
{
    Console.WriteLine($"{local} - Conforme seus sintomas, que não estão registrados no Centro de Ortopedia, te indicamos o Dr. Renato, um médico clínico geral que irá fazer a sua avaliação completa, prescreverá tratamentos e te encaminhará para especialistas.");
}

using DelegatesEvents;

var figura = new FiguraGeometrica()
{
    Altura = 10,
    Largura = 10,
    Profundidade = 10
};

figura.Calcular += CalcularAreaQuadrado;
figura.Calcular += CalcularVolumeCubo;
figura.EventHandler();

static void CalcularAreaQuadrado(double altura, double largura, double profundidade)
{
    var area = altura * largura;
    Console.WriteLine("Evento disparado da classe cliente, calculo de área de um quadrado");
    Console.WriteLine(area);
}

static void CalcularVolumeCubo(double altura, double largura, double profundidade)
{
    var volume = altura * largura * profundidade;
    Console.WriteLine("Evento disparado da classe cliente, calculo do volume de um cubo");
    Console.WriteLine(volume);
}


using Modulo3;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Codenation.Challenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Quadrado_AbstracClass quadrado = new Quadrado_AbstracClass();
            quadrado.Lado = 10;
            quadrado.CalcularArea();
            quadrado.TrocarDescricao();
            LogComReflection.Log(quadrado);

            Triangulo_AbstractClass triangulo = new Triangulo_AbstractClass();
            triangulo.Base = 10;
            triangulo.LadoD = 10;
            triangulo.LadoE = 10;
            triangulo.Altura = 10;
            triangulo.CalcularArea();
            triangulo.TrocarDescricao();
            LogComReflection.Log(triangulo);

            Circulo_AbstractClass circulo = new Circulo_AbstractClass();
            circulo.Raio = 5;
            circulo.CalcularArea();
            circulo.CalcularPerimetro();
            LogComReflection.Log(circulo);

        }
    }
}
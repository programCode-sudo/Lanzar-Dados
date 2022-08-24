using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class JuegoLanzar
    {
        private Dado[] dado;

        public JuegoLanzar(int numeroDeDados)
        {
            dado = new Dado[numeroDeDados];
            dado[0] = new Dado();
            dado[1] = new Dado();
            maxValueOfA = dado[0].GetNumeroDeCaras();
            maxValueOfB = dado[0].GetNumeroDeCaras();
        }
        

        private int dadoA;
        private int dadoB;
        private int maxValueOfA;
        private int maxValueOfB;

        private int totalDePuntos;

        public void Jugar()
        {
            totalDePuntos = 0;
            int a;
            int b;
            Random Lanzamiento = new Random();
            a = Lanzamiento.Next(1, maxValueOfA);
            b= Lanzamiento.Next(1,maxValueOfB);
            totalDePuntos += a + b;
            dadoA = a;
            dadoB = b;
        }
       
        public string GetTotalDePuntos()
        {
            return totalDePuntos.ToString();
        }

        public int GetDadoA()
        {
            return dadoA;
        }

        public int GetDadoB()
        {
            return dadoB;
        }

        public string GetMaxValueOfA()
        {
            return maxValueOfA.ToString();
        }


    }
}

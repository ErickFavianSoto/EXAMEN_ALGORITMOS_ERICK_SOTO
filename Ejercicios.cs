using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EXAMEN_ALGORIMOS_ERICK_SOTO
{
    internal class Ejercicios
    {
        static void Main(string[] args)
        {
            /*Aqui inicia el ejercicio 1*/
            int[] muestraA = new int[3] {17,28,30};
            int[] muestraB = new int[3] {99,16,8};
            int contadorA = 0;
            int contadorB = 0;

            for (int i = 0; i < muestraA.Length; i++)
            {

                if (muestraA[i]<=100 && 1<=muestraA[i])
                {
                    if (muestraB[i] <= 100 && 1 <=muestraB[i])
                    {
                        if (muestraA[i]>muestraB[i])
                        {
                            contadorA=contadorA + 1;
                        }
                        else if (muestraA[i]<muestraB[i])
                        {
                            contadorB = contadorB + 1;
                        }
                    }
                }
            }
            int[] resultado = new int[2] {contadorA,contadorB};

            Console.WriteLine("El resultado del ejercicio 1 es: " + resultado[0]+" , " + resultado[1]+"\n\n");

            //aqui inicia el segundo ejercicio

            String texto = "Érase una vez una niñita que lucía una hermosa capa " +
                "de color rojo.Como la niña la usaba muy a menudo, todos la " +
                "llamaban Caperucita Roja. Un día, la mamá de Caperucita Roja la" +
                "llamó y le dijo: —Abuelita no se siente muy bien, he horneado" +
                "unas galletitas y quiero que tú se las lleves. —Claro que sí" +
                "—respondió Caperucita Roja, poniéndose su capa y llenando su" +
                "canasta de galletas recién horneadas.Antes de salir, su mamá" +
                "le dijo: — Escúchame muy bien, quédate en el camino y " +
                "hables con extraños. —Yo sé mamá —respondió Caperucita Roja y " +
                "salió inmediatamente hacia la casa de la abuelita.";
            
            string textoLimpio = texto.ToLower().Replace(",","").Replace(".","").Replace(";","").Replace(":","").Replace("¿","").Replace("?","").Replace("—", "");

            textoLimpio.ToCharArray();
            string palabra = "";
            int numPalabras = 0;
            for (int i = 0; i < textoLimpio.Length; i++)
            {
                if (textoLimpio[i].ToString() == " ")
                {
                    ++numPalabras;
                    palabra = "";
                }
                else if (i == textoLimpio.Length - 1)
                {
                    ++numPalabras;
                   }
                else
                {
                    palabra = palabra + textoLimpio[i].ToString();
                }
            }
            string[] palabrasOrdenadas = new string[numPalabras];
            numPalabras = 0;

            for (int x = 0; x < textoLimpio.Length; x++)
            {
                if (textoLimpio[x].ToString() == " ")
                {
                    ++numPalabras;
                    palabrasOrdenadas[numPalabras-1] = palabra;
                    palabra = "";
                }else if (x == textoLimpio.Length-1)
                {
                    ++numPalabras;
                    palabra = palabra + textoLimpio[textoLimpio.Length - 1];
                    palabrasOrdenadas[numPalabras - 1] = palabra;
                }
                else
                {
                    palabra = palabra + textoLimpio[x].ToString();
                }
            }
            int[] matrizRepeticiones = new int[numPalabras];
            string palabraRevision="";

            for (int y = 0; y < palabrasOrdenadas.Length; y++)
            {
                palabraRevision = palabrasOrdenadas[y];
                int repeticiones =0;
                
                for (int i = 0; i < palabrasOrdenadas.Length; i++)
                {
                    if (palabraRevision == palabrasOrdenadas[i])
                    {
                        repeticiones++;
                    }
                }
                matrizRepeticiones[y] = repeticiones;
            }

            int comas = palabrasOrdenadas.Length - 1;
            Console.Write("Resultado del segundo ejercicio \n{ ");
            for (int i = 0; i < palabrasOrdenadas.Length; i++)
            {
                Console.Write(palabrasOrdenadas[i]+" : " + matrizRepeticiones[i]);
                
                if (i!=comas)
                {
                    Console.Write(" , ");
                }
            }
            Console.Write(" }");

            Console.ReadKey();
            
        }
       
    }
}

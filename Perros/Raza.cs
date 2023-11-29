using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Perros
{
    public class Raza 
    {
        public string QueryMaxrazas(List<Perros> myList)
        {


            

             var razasCounting = myList.GroupBy(c => c.Raza)
                                   .Select(grupo => new
                                   {
                                       todasrazas = grupo.Key,
                                       cant_razas = grupo.Count()
                                   });
            /*

            var razasCounting = from d in myList
                                group d by d.Raza into totals
                                select new
                                {   
                                    todasrazas = totals.Key,
                                    cant_razas = totals.Count(),                                                               
                                 
                                };
            */
            var maximo = razasCounting.Where(m=>m.cant_razas >= 1).Max(d=>d.cant_razas);
           /* 
            foreach (var i in razasCounting)
           {
               if (i.cant_razas == maximo)
                {
                    Console.WriteLine($"Raza con mas perros es: {i.todasrazas} con una  " +
                                 $"cantidad de :{maximo}");
                }
                //Console.WriteLine($"Raza encontrada: {i.todasrazas} y cantidad de esta " +
                //               $"raza {i.cant_razas} Maximo de razas: {maximo}");
                //Console.WriteLine("Raza encontrada:" + i.Key);
            }
           */
            //Console.WriteLine($"\n");
            /*foreach (var i in razasCounting)
            {
                
                   Console.WriteLine($"Raza : {i.todasrazas} con una  " +
                                 $"cantidad de :{i.cant_razas}");
                               
            }
            */

            //List<string> hola = new List<string>();
            //hola.Add("denis");
            //hola.Add("que onda");
            //hola.Add("lombardo");
            //hola.Add("denis");

            //var raza =
            //    from i in hola
            //    where i == "denis"
            //    select  i;


            //foreach(string s in raza)
            //{
            //    Console.WriteLine(s + "  ");
            //}
            return maximo.ToString();
            

        }


        public List<seleccion> QueryListRazas(List<Perros> myList)
        {
            List<seleccion> valores = new List<seleccion>();


            var razasCounting = myList.GroupBy(c => c.Raza)
                                  .Select(grupo => new
                                  {
                                      todasrazas = grupo.Key,
                                      cant_razas = grupo.Count()
                                  });


            foreach (var i in razasCounting)
            {
                valores.Add(new seleccion
                {
                    Nombre = i.todasrazas,
                    cantidad = i.cant_razas,
                }) ;

            }

          



            /*

            var razasCounting = from d in myList
                                group d by d.Raza into totals
                                select new
                                {   
                                    todasrazas = totals.Key,
                                    cant_razas = totals.Count(),                                                               

                                };
            */

            /* foreach (var i in razasCounting)
             {
                 if (i.cant_razas == maximo)
                 {
                     Console.WriteLine($"Raza con mas perros es: {i.todasrazas} con una  " +
                                  $"cantidad de :{maximo}");
                 }
                 //Console.WriteLine($"Raza encontrada: {i.todasrazas} y cantidad de esta " +
                 //               $"raza {i.cant_razas} Maximo de razas: {maximo}");
                 //Console.WriteLine("Raza encontrada:" + i.Key);
             }
            */
            //
            //Console.WriteLine($"\n");


            /*foreach (var i in razasCounting)
            {

                Console.WriteLine($"Raza : {i.todasrazas} con una  " +
                              $"cantidad de :{i.cant_razas}");

            }
            */

            return valores;


        }




    }







}

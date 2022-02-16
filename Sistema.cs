using System.Collections.Generic;
using System;

namespace Parejas
{
    public class Sistema
    {
        public List<Persona> Personas { get; } = new()
        {
        new Persona("Julio",18,'M'),
         new Persona("Pablo",32,'M'),
         new Persona("Sara",60,'F'),
         new Persona("Irene",31,'F'),
         new Persona("Kek",23,'M'),
         new Persona("Pepe",45,'M'),
         new Persona("Elena",14,'F'),
         new Persona("Paco",53,'M'),
         new Persona("Juan Manuel Santamaria Ojeda",64,'M'),
         new Persona("Ñie",53,'F')
            
        };

        public bool AdmitenDescendencia(Persona a, Persona b)
        {
            
            if(a.sexo != b.sexo && Math.Abs(a.rangoEdad()-b.rangoEdad())<=1 && Math.Abs(a.edad-b.edad)<=12)
                return true;

        
            return false;
        }

        public List<(Persona, Persona)> PosibleParejas(List<Persona> personas)
        {

            var parejas = new List<(Persona, Persona)>();
        for(int i=0; i<personas.Count-1;i++){
                for (int j=i+1; j<personas.Count;j++){
                    if (AdmitenDescendencia(personas[i],personas[j]))
                        parejas.Add((personas[i],personas[j]));
                }
            }
           
            return parejas;
        }

        public string Saludo(string nombre) => $"Saludos {nombre}!";


    }
}
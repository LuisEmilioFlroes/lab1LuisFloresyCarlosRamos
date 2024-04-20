using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab1.ClasePadre.ClasesJuegos
{
    internal class JuegoDisparos : VideoJuego
    {

       //Campos privados
        
        private string nombrearma; 
        private int clasificacionedad;



        //Constructores
        public JuegoDisparos(string categoria, string nombrearma, int clasificacionedad)
        {
            
            
            this.nombrearma = nombrearma;
            this.clasificacionedad = clasificacionedad;

        }



        //Propiedades
        public string Nombre_Arma

            
        { 


           

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoB : Producto
    {

        private short alto;
        private short ancho;
        private short largo;



        public short Alto
        {
            get { return this.alto; }
        }

        public short Ancho
        {
            get { return this.ancho; }
        }

        public short Largo
        {
            get
            {
                return this.Alto;
            }
        }

        private int CalcularVolumen()
        {
            int resultado = 0;

            if(this.Alto != null && this.Ancho != null && this.Largo != null){


            resultado = this.Alto * this.Ancho;
            resultado = resultado * this.Largo;
            }
            


            return resultado;

        }


      //  public static int explicit operator int (ProductoB p){
        


        //return 10;
        
        
        //}



        public string Mostrar(){
        
        
            StringBuilder cadena = new StringBuilder();

            cadena.AppendFormat("Alto: {0} \n", this.Alto);
           cadena.AppendFormat("Ancho: {0} \n", this.Ancho);

           cadena.AppendFormat("Largo: {0} \n", this.Largo);

          cadena.AppendFormat("volumen: {0} \n", this.CalcularVolumen());

            return cadena.ToString();

        }


        public ProductoB()
        :base()
        {
        
        
        }


          
        public ProductoB(string descripcion, short largo, short alto, short ancho)
        :base(descripcion)
        {
        
            this.largo = largo;
            this.alto = alto;
            this.ancho = ancho;
        
        }


        public bool ValidarDimensiones(){
        bool retorno = false;
        int suma = this.alto + this.ancho + this.largo;

        if(suma <= 100){
        
            retorno = true;
        
        }
        
        return retorno;
        }

    }
}

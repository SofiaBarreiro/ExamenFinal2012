using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public enum Material
    {
        Plastico,
        Alumnio,
        Caucho,
    }

    public class ProductoA : Producto
    {

        private short diametro;
        private Material material;




        public short Diametro
        {
            get { return this.diametro; }
        }


        public Material Material
        {
            get { return this.material; }
            set { material = value; }
        }



        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendFormat("Diametro: {0} \n", this.Diametro);

            cadena.AppendFormat("Material: {1} \n", this.Material.ToString());

            return cadena.ToString();
        }
        public ProductoA()
        {


        }

        public ProductoA(string descripcion, short diametro, Material material)
            : base(descripcion)
        {

            this.diametro = diametro;
            this.material = material;


        }


        public bool ValidarDimensiones()
        {

            return true;
        }

        public bool ValidarMaterial(Material unmaterial) {

            bool retorno = false;
            if (unmaterial != null) {
            
            

           if(this.Diametro <= 10 && unmaterial == Material.Alumnio){
           
               retorno = true;
           
           }

            if(this.Diametro <= 15 && unmaterial == Material.Caucho){
            
                retorno = true;


            }

             if(unmaterial == Material.Plastico){
                
                retorno =  true;
              }



             if (retorno == false) {

                 string mensaje = "No se puede fabricar una pieza de " + this.Material.ToString() + " y diametro de " + this.Diametro + "\n";


                 throw new MaterialException(mensaje);
             }


            
            }


            return retorno;


        }

    }
}

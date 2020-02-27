using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        private List<Producto> productos;

       

        public List<Producto> Productos
        {
            get { return this.productos; }
            set { this.productos = value; }
        }


        public void FabricarPedido()
        {

            foreach (Producto aux in this.productos) {


                if (aux != null) {

                    //Thread hilo = new Thread();
                    //hilo.sleep(1000);

                    aux.Elaborar();


                }
            
            }
        }


        public static implicit operator String(Pedido unPedido)
        {

            StringBuilder cadena = new StringBuilder();
            if (unPedido != null) {


                if (unPedido.productos != null) {


                    foreach (Producto aux in unPedido.productos) {

                        if (aux != null) {

                            cadena.AppendFormat("Producto nro {1}: \n" + unPedido.productos.IndexOf(aux));
                            cadena.AppendFormat("Descripcion: {0}: \n", aux.Descripcion);

                        
                        }
                    
                    
                    }
                
                }


            }

            return cadena.ToString();

        }


        public static Pedido operator +(Pedido unPedido, Producto unProducto)
        {

        
            if (unPedido != null && unProducto != null)
            {
                if (unPedido.productos != null) {

                    if (unPedido.productos.Count() < 5)
                    {

                        unPedido.productos.Add(unProducto);
                    }
                
                }
                

            }

            return unPedido;

        }




        public Pedido()
        {

            this.productos = new List<Producto>();

        }


    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBusiness
{
    public static class ProductoVendidoBusiness
    {
        public static List<ProductoVendido> ListarProductosVendido()
        {
            return ProductoVendidoData.ListarProductosVendido();
        }
        public static void CrearProductoVendido(ProductoVendido productovendido)
        {
            ProductoVendidoData.CrearProductoVendido(productovendido);
        }

        public static void ModificarProductoVendido(ProductoVendido productovendido)
        {
            ProductoVendidoData.ModificarProductoVendido(productovendido);
        }

        public static void EliminarProductoVendido(int Id)
        {
            ProductoVendidoData.EliminarProductoVendido(Id);
        }

    }
}

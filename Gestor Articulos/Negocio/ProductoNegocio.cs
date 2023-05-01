﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Dominio;
namespace Negocio
{
    public class ProductoNegocio
    {
        public List<Producto> listar()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT A.id,A.codigo, A.Nombre, A.descripcion,M.descripcion as marca , C.descripcion as categoria, I.ImagenUrl, a.precio from ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I where A.IdMarca = M.Id and C.Id = A.IdCategoria and I.IdArticulo = A.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Id = (Int32)datos.Lector["Id"];
                    aux.CodArtículo = (string)datos.Lector["codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripción = (string)datos.Lector["Descripcion"];
                    aux.ImgArt = new ImagenArticulo();
                    aux.ImgArt.Imagen = (string)datos.Lector["ImagenUrl"];
                    decimal DosDecimal;
                    DosDecimal= (decimal)datos.Lector["precio"];
                    aux.Precio =Decimal.Parse( DosDecimal.ToString("0.00"));
                    aux.marca = new Marca();
                    aux.marca.Nombre = (string)datos.Lector["marca"];
                    aux.categoria = new Categoria();
                    aux.categoria.Nombre = (string)datos.Lector["categoria"];


                    lista.Add(aux);
                }

                return lista;

            }

            

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<ImagenArticulo> listarImgArt(Int32 id)
        {
            List<ImagenArticulo> lista = new List<ImagenArticulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select  a.Nombre, i.IdArticulo , i.ImagenUrl from imagenes as i inner join ARTICULOS as a on a.id = i.IdArticulo  where a.id=" + id);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    ImagenArticulo aux = new ImagenArticulo();
                    aux.producto = new Producto();
                    aux.producto.Id = (Int32)datos.Lector["IdArticulo"];
                    aux.producto.Nombre= (string)datos.Lector["Nombre"];
                    aux.Imagen = (string)datos.Lector["ImagenUrl"];


                    lista.Add(aux);
                }

                return lista;

            }



            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }






    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{// xd
    public class TrabajarUsuario
    {
        public static int contarProductos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            cnn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM producto";
            cmd.Connection = cnn;

            int count = (int)cmd.ExecuteScalar();
            return count;
        }

        public static int contarClientes()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            cnn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM cliente";
            cmd.Connection = cnn;

            int count = (int)cmd.ExecuteScalar();
            return count;
        }

        public static int buscarUltimoIDVenta()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Max(ven_Nro) FROM venta";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();
            int MaxId = Convert.ToInt32(cmd.ExecuteScalar());
            cnn.Close();
            return MaxId;
        }

        public static decimal buscarDetPrecio(string codProd)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT (prod_Precio) FROM producto WHERE prod_Codigo = @Codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Codigo", codProd);

            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            decimal value = 0;
            while(reader.Read()){
                value = Convert.ToDecimal(reader[0]);
            }
            
            cnn.Close();

            return value;
        }

        public static void insert_VentaDetalle(int nroVenta, string prod_Codigo, decimal det_Precio, decimal det_Cantidad, decimal det_Total)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO VentaDetalle(ven_Nro,prod_Codigo,det_Precio,det_Cantidad,det_Total) VALUES (@NumVenta,@CodigoProd,@PrecioDet,@CantidadDet,@TotalDet)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@NumVenta", nroVenta);
            cmd.Parameters.AddWithValue("@CodigoProd", prod_Codigo);
            cmd.Parameters.AddWithValue("@PrecioDet", det_Precio);
            cmd.Parameters.AddWithValue("@CantidadDet", det_Cantidad);
            cmd.Parameters.AddWithValue("@TotalDet", det_Total);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void insert_Venta(DateTime ven_Fecha, string cli_DNI)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Venta(ven_Fecha, cli_DNI) values(@Fecha,@CliDNI)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Fecha", ven_Fecha);
            cmd.Parameters.AddWithValue("@CliDNI", cli_DNI);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable list_roles() {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM rol";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable consultarUsuariosUserName(string userName)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM vw_listar_usuarios WHERE Username LIKE '%' + @Username + '%' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            //a
            cmd.Parameters.AddWithValue("@Username", userName);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void insert_Usuario(Usuario user){
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(usu_NombreUsuario, usu_Contraseña, usu_ApellidoNombre, rol_Codigo) values(@Nombre,@Contraseña,@Apellido,@RolID)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

 
            cmd.Parameters.AddWithValue("@Nombre",user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@Contraseña",user.Usu_Contrasenia);
            cmd.Parameters.AddWithValue("@Apellido",user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@RolID", user.Rol_Codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable list_users() {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM vw_listar_usuarios";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            
            return dt;
        }


        public static int count_of_users()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            cnn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM usuario";
            cmd.Connection = cnn;
            
            int count = (int)cmd.ExecuteScalar();
            return count;
        }


        public static DataTable list_ObraSocial()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM obrasocial";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static DataTable list_Productos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getProductos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void insert_Producto(Producto product)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Producto(prod_Codigo, prod_Categoria, prod_Descripcion, prod_Precio) values(@Codigo,@Categoria,@Descripcion,@Precio)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Codigo", product.Prod_Codigo);
            cmd.Parameters.AddWithValue("@Categoria", product.Prod_Categoria);
            cmd.Parameters.AddWithValue("@Descripcion", product.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@Precio", product.Prod_Precio);
            //abcd
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static void insert_Cliente(Cliente client)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Cliente(cli_DNI, cli_Apellido, cli_Nombre, cli_Direccion, cli_NroCarnet, OS_CUIT) values(@DNI,@Apellido,@Nombre,@Direccion,@NroCarnet,@OS_CUIT)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@DNI", client.Cli_DNI);
            cmd.Parameters.AddWithValue("@Apellido", client.Cli_Apellido);
            cmd.Parameters.AddWithValue("@Nombre", client.Cli_Nombre);
            cmd.Parameters.AddWithValue("@Direccion", client.Cli_Direccion);
            cmd.Parameters.AddWithValue("@NroCarnet", client.Cli_NroCarnet);
            cmd.Parameters.AddWithValue("@OS_CUIT", client.OS_CUIT);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static DataTable list_Cliente()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getClientes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscarCliApeDni(string apellido, string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM ";
            cmd.CommandText += " vw_listar_clientes WHERE Apellido LIKE '%' + @apellido + '%' AND DNI LIKE '%' + @dni + '%' ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            //a
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@dni", dni);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
      
        public static Boolean deleteUsuario(string userName)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " DELETE FROM usuario WHERE usu_NombreUsuario = @Username ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@Username", userName);
            cnn.Open();
            int valor= cmd.ExecuteNonQuery();
            cnn.Close();
            if (valor==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public static string deleteCliente(string dni, string apellido)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;


            DataTable dt = buscarVentaDNI(dni);
            if (dt.Rows.Count != 0)
            {
                return "venta";
            }
            else
            {
                cmd.CommandText = " DELETE FROM cliente WHERE cli_DNI = @DNI AND cli_Apellido = @Apellido ";
                cmd.Parameters.AddWithValue("@DNI", dni);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                //Almacena la cantidad de lineas afectadas por el comando
                int valor = cmd.ExecuteNonQuery();
                //Si se ven afectadas 0 lineas quiere decir que no se encontraron coincidencias
                if (valor == 0)
                {
                    return "false";
                }
                else
                {
                    return "true";
                }
            }
        }


        public static string deleteProducto(string codigo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@Codigo", codigo);

            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM ventaDetalle WHERE prod_Codigo = @codigo";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                return "venta";
            }
            else
            {
                cmd.CommandText = " DELETE FROM producto WHERE prod_Codigo = @Codigo";

                //Almacena la cantidad de lineas afectadas por el comando
                int valor = cmd.ExecuteNonQuery();
                //Si se ven afectadas 0 lineas quiere decir que no se encontraron coincidencias
                if (valor == 0)
                {
                    return "false";
                }
                else
                {
                    return "true";
                }
            }
        }

        public static Boolean comprobarDNI(string dni) {
            
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM cliente WHERE cli_DNI = @DNI;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@DNI", dni);
            Int32 valor = Convert.ToInt32( cmd.ExecuteScalar());
            if (valor!=0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Boolean comprobarCodigo(string codigo)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM producto WHERE prod_Codigo = @Codigo;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@Codigo", codigo);
            Int32 valor = Convert.ToInt32(cmd.ExecuteScalar());
            if (valor != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Boolean comprobarUsername(string username)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM usuario WHERE usu_NombreUsuario = @Username;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@Username", username);
            Int32 valor = Convert.ToInt32(cmd.ExecuteScalar());
            if (valor != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public static DataTable list_Ventas()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM vw_listar_ventas";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static DataTable buscarVentaDNI(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM venta WHERE cli_DNI LIKE '%' + @dni + '%' ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dni", dni);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscarVentaID(int ID)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM venta WHERE ven_Nro= @ID ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void editarUsuario(string username, string apellido, string contraseña,string nombre, int rol)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE usuario SET usu_Contraseña = @Contraseña , usu_ApellidoNombre = @Apellido , rol_codigo = @Rol , usu_NombreUsuario = @Nombre WHERE usu_NombreUsuario= @Username ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Apellido", apellido);
            cmd.Parameters.AddWithValue("@Contraseña", contraseña);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Rol", rol);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static Usuario devolverUsuario(string username)
        {
            Usuario usuarioAux = new Usuario();

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT (usu_ApellidoNombre) FROM usuario WHERE usu_NombreUsuario= @Username ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@Username", username);
            cnn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                usuarioAux.Usu_ApellidoNombre=Convert.ToString(reader[0]);
            }
            reader.Close();

            cmd.CommandText = "SELECT (usu_Contraseña) FROM usuario WHERE usu_NombreUsuario= @Username ";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                usuarioAux.Usu_Contrasenia = Convert.ToString(reader[0]);
            }
            reader.Close();

            cmd.CommandText = "SELECT (rol_Codigo) FROM usuario WHERE usu_NombreUsuario= @Username ";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                usuarioAux.Rol_Codigo = Convert.ToInt32(reader[0]);
            }
            reader.Close();

            cmd.CommandText = "SELECT (usu_ID) FROM usuario WHERE usu_NombreUsuario= @Username ";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                usuarioAux.Usu_ID = Convert.ToInt32(reader[0]);
            }
            reader.Close();

            return usuarioAux;
        }


        public static void editarCliente(string dni, string apellido, string nombre, string direccion, string cuit ,string nroCarnet, string dniAEditar)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE cliente SET cli_Apellido = @Apellido , cli_Nombre = @Nombre , cli_Direccion = @Direccion , OS_CUIT = @CUIT , cli_NroCarnet = @NroCarnet , cli_DNI = @DNIAEditar WHERE cli_DNI = @DNI ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@DNI", dni);
            cmd.Parameters.AddWithValue("@DNIAEditar", dniAEditar);
            cmd.Parameters.AddWithValue("@Apellido", apellido);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Direccion", direccion);
            cmd.Parameters.AddWithValue("@CUIT", cuit);
            cmd.Parameters.AddWithValue("@NroCarnet", nroCarnet);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static Cliente devolverCliente(string dni)
        {
            Cliente clienteAux = new Cliente();

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT (cli_Apellido) FROM cliente WHERE cli_DNI= @DNI ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@DNI", dni);
            cnn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clienteAux.Cli_Apellido = Convert.ToString(reader[0]);
            }
            reader.Close();

            cmd.CommandText = "SELECT (cli_Nombre) FROM cliente WHERE cli_DNI= @DNI ";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clienteAux.Cli_Nombre = Convert.ToString(reader[0]);
            }
            reader.Close();

            cmd.CommandText = "SELECT (cli_Direccion) FROM cliente WHERE cli_DNI= @DNI ";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clienteAux.Cli_Direccion = Convert.ToString(reader[0]);
            }
            reader.Close();

            cmd.CommandText = "SELECT (cli_ID) FROM cliente WHERE cli_DNI= @DNI ";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clienteAux.Cli_ID = Convert.ToInt32(reader[0]);
            }
            reader.Close();

            cmd.CommandText = "SELECT (OS_CUIT) FROM cliente WHERE cli_DNI= @DNI ";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clienteAux.OS_CUIT = Convert.ToString(reader[0]);
            }
            reader.Close();

            cmd.CommandText = "SELECT (cli_NroCarnet) FROM cliente WHERE cli_DNI= @DNI ";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clienteAux.Cli_NroCarnet = Convert.ToString(reader[0]);
            }
            reader.Close();

            return clienteAux;
        }


        public static void editarProducto(string codigoAEditar, string codigo, string categoria, string descripcion, decimal precio)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE producto SET prod_Categoria = @Categoria , prod_Descripcion = @Descripcion , prod_Precio = @Precio , prod_Codigo = @Codigo WHERE prod_Codigo = @CodigoAEditar ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@Codigo", codigo);
            cmd.Parameters.AddWithValue("@CodigoAEditar", codigoAEditar);
            cmd.Parameters.AddWithValue("@Categoria", categoria);
            cmd.Parameters.AddWithValue("@Descripcion", descripcion);
            cmd.Parameters.AddWithValue("@Precio", precio);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable list_Cliente_Apellido()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);
            
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "getClientesPorApellido";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static DataTable list_Productos_Categoria()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getProductosPorCategoria";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static DataTable list_Productos_Descripcion()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getProductosPorDescripcion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_Productos_Segun_Cliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getProductosSegunCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cliente",dni);
            cmd.Connection = cnn;
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static DataTable list_Productos_Vendidos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getProductosVendidos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static DataTable list_Productos_Segun_Fecha(DateTime fecha1, DateTime fecha2)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getProductosSegunRangoDeFechas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fecha1", fecha1);
            cmd.Parameters.AddWithValue("@fecha2", fecha2);
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_Ventas_Segun_Cliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getVentasSegunCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@clienteDNI", dni);
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static DataTable list_Ventas_Segun_Fecha(DateTime fecha1, DateTime fecha2)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getVentasSegunRangoDeFechas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fecha1", fecha1);
            cmd.Parameters.AddWithValue("@fecha2", fecha2);
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_Cliente_segun_ObraSocial(string obraSocial)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getClientesSegunOS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OS", obraSocial);
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscarCliApeDniNombre(string apellido, string dni, string nombre)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM ";
            cmd.CommandText += " vw_listar_clientes WHERE Apellido LIKE '%' + @apellido + '%' AND DNI LIKE '%' + @dni + '%'  AND Nombre LIKE '%' + @nombre + '%' ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            //
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static Boolean deleteVenta(string id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.OpticaConnectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " DELETE FROM ventaDetalle WHERE ven_Nro = @ID";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
            cmd.CommandText = " DELETE FROM venta WHERE ven_Nro = @ID";
            //Almacena la cantidad de lineas afectadas por el comando
            int valor = cmd.ExecuteNonQuery();
            //Si se ven afectadas 0 lineas quiere decir que no se encontraron coincidencias
            if (valor == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
    DataSet ds = new DataSet();

    SqlDataAdapter da;

    string conexion = ConfigurationManager.ConnectionStrings["conexionSQL"].ToString();

    public DataSet Insertar_usuario(string Cod_usuario, string nombre, string apellido, int edad, string sexo, string fechanac, string pais, string depto, string telefono, string email, string pasword, string fecharegistro)
    {
        da = new SqlDataAdapter("Insertar_usuario", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Cod_usuario", Cod_usuario);
        da.SelectCommand.Parameters.AddWithValue("@nombre", nombre);
        da.SelectCommand.Parameters.AddWithValue("@Apellido", apellido);
        da.SelectCommand.Parameters.AddWithValue("@Edad", edad);
        da.SelectCommand.Parameters.AddWithValue("@Sexo", sexo);
        da.SelectCommand.Parameters.AddWithValue("@Fecha_Nac", fechanac);
        da.SelectCommand.Parameters.AddWithValue("@Pais", pais);
        da.SelectCommand.Parameters.AddWithValue("@Depto", depto);
        da.SelectCommand.Parameters.AddWithValue("@Telefono", telefono);
        da.SelectCommand.Parameters.AddWithValue("@Email", email);
        da.SelectCommand.Parameters.AddWithValue("@Pasword", pasword);
        da.SelectCommand.Parameters.AddWithValue("@Fecharegistro", fecharegistro);
        da.Fill(ds, "Usuario Insertado");

        return ds;
    }

    public DataSet Modificar_Usuario(string Cod_usuario, string nombre, string apellido, int edad, string sexo, string fechanac, string pais, string depto, string telefono, string email, string pasword)
    {
        da = new SqlDataAdapter("Modificar_Usuario", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Cod_usuario", Cod_usuario);
        da.SelectCommand.Parameters.AddWithValue("@nombre", nombre);
        da.SelectCommand.Parameters.AddWithValue("@Apellido", apellido);
        da.SelectCommand.Parameters.AddWithValue("@Edad", edad);
        da.SelectCommand.Parameters.AddWithValue("@Sexo", sexo);
        da.SelectCommand.Parameters.AddWithValue("@Fecha_Nac", fechanac);
        da.SelectCommand.Parameters.AddWithValue("@Pais", pais);
        da.SelectCommand.Parameters.AddWithValue("@Depto", depto);
        da.SelectCommand.Parameters.AddWithValue("@Telefono", telefono);
        da.SelectCommand.Parameters.AddWithValue("@Email", email);
        da.SelectCommand.Parameters.AddWithValue("@Pasword", pasword);
        da.Fill(ds, "Usuario modificado");

        return ds;
    }

    public DataSet Eliminar_Usuario(string Cod_usuario)
    {
        da = new SqlDataAdapter("Eliminar_Usuario", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Cod_usuario", Cod_usuario);
        da.Fill(ds, "Usuario Eliminado");

        return ds;
    }

    public DataSet Consultar_Usuario()
    {
        da = new SqlDataAdapter("Consultar_Usuario", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.Fill(ds, "Data de usuario");

        return ds;
    }

    public DataSet Insertar_Tema(string nombre_tema)
    {
        da = new SqlDataAdapter("Insertar_Tema", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@nombre_tema", nombre_tema);
        da.Fill(ds, "Tema Insertado");

        return ds;
    }

    public DataSet Modificar_Tema(int ID_tema, string nombre_tema)
    {
        da = new SqlDataAdapter("Modificar_Tema", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@ID_tema",ID_tema );
        da.SelectCommand.Parameters.AddWithValue("@nombre_tema", nombre_tema);
        da.Fill(ds, "Tema Modificado");

        return ds;
    }

    public DataSet Eliminar_Tema(int ID_tema)
    {
        da = new SqlDataAdapter("Eliminar_Tema", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@ID_tema", ID_tema);
        da.Fill(ds, "Tema Eliminado");

        return ds;
    }

    public DataSet Consultar_tema()
    {
        da = new SqlDataAdapter("Consultar_", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.Fill(ds, "Data de Temas");

        return ds;
    }

    public DataSet Mostrar_Temas_xCursos(int ID_Curso)
    {
        da = new SqlDataAdapter("Mostrar_Temas_xCursos", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@ID_Curso",ID_Curso);
        da.Fill(ds,"Data de Temas por Curso");
        return ds;
    }

    public DataSet Insertar_curso(string nombre_curso, string estado, string ID_tema)
    {
        da = new SqlDataAdapter("Insertar_curso", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@nombre_curso", nombre_curso);
        da.SelectCommand.Parameters.AddWithValue("@Estado", estado);
        da.SelectCommand.Parameters.AddWithValue("@ID_tema", ID_tema);
        da.Fill(ds, "Curso Insertado"); 
        return ds;
    }

    public DataSet Modificar_curso(int id_curso, string nombre_curso, string estado, string ID_tema)
    {
        da = new SqlDataAdapter("Modificar_curso", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@id_curso", id_curso);
        da.SelectCommand.Parameters.AddWithValue("@nombre_curso", nombre_curso);
        da.SelectCommand.Parameters.AddWithValue("@Estado", estado);
        da.SelectCommand.Parameters.AddWithValue("@ID_tema", ID_tema);
        da.Fill(ds, "Curso Modificado");

        return ds;
    }

    public DataSet Eliminar_curso(int id_curso)
    {
        da = new SqlDataAdapter("Eliminar_curso", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@id_curso", id_curso);
        da.Fill(ds, "Curso Eliminado");

        return ds;
    }
    public DataSet Consultar_curso()
    {
        da = new SqlDataAdapter("Consultar_curso", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.Fill(ds, "Data de Cursos");

        return ds;
    }

    public DataSet Mostrar_Cursos_Usuario(int Id_usuario,int ID_categoria)
    {
        da = new SqlDataAdapter("Mostrar_Cursos_Usuario", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("ID_usuario",Id_usuario);
        da.SelectCommand.Parameters.AddWithValue("ID_categoria", ID_categoria);
        da.Fill(ds,"Data Cursos");
        return ds;
    }

    public DataSet Mostrar_Cursos_xCategoria(int ID_Categoria)
    {
        da = new SqlDataAdapter("Mostrar_Cursos_xCategoria", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("ID_Categoria", ID_Categoria);
        da.Fill(ds,"DataCursos");
        return ds;
    }

    #region Categoria

    public DataSet Insertar_Categorias(string nombre_cat)
    {
        da = new SqlDataAdapter("Insertar_Categorias", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@nombre_cat", nombre_cat);
        da.Fill(ds, "Categoria creada");

        return ds;
    }

    public DataSet Modificar_Categorias(int ID_Categoria, string nombre_cat)
    {
        da = new SqlDataAdapter("Modificar_Categorias", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@ID_cat", ID_Categoria);
        da.SelectCommand.Parameters.AddWithValue("@Nombre_cat", nombre_cat);
        da.Fill(ds, "Categoria modificada");

        return ds;
    }

    public DataSet Eliminar_Categoria(int ID_Categoria, string nombre_cat)
    {
        da = new SqlDataAdapter("Eliminar_Categoria", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@ID_Categoria", ID_Categoria);
        da.Fill(ds, "Categoria Eliminada");

        return ds;
    }

    public DataSet Buscar_Categoria(int ID_Categoria, string nombre_cat)
    {
        da = new SqlDataAdapter("Buscar_Categoria", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("ID_Cat", ID_Categoria);
        da.SelectCommand.Parameters.AddWithValue("Nombre_Cat", nombre_cat);
        da.Fill(ds, "Categoria Encontrada");
        return ds;
    }

    #endregion

     
    #region Cursos

    public DataSet Mostrar_Cursos()
    {
        da = new SqlDataAdapter("Mostrar_Cursos", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.Fill(ds, "DataContenidos");
        return ds;
    }

    public DataSet Insertar_Cursos(string nombre_curso, int ID_Categoria, int estado)
    {
        da = new SqlDataAdapter("Insertar_cursos", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@nombre_curso", nombre_curso);
        da.SelectCommand.Parameters.AddWithValue("@Estado", estado);
        da.SelectCommand.Parameters.AddWithValue("@ID_Categoria", ID_Categoria);
        da.Fill(ds, "Curso Insertado"); 
        return ds;
    }

    public DataSet Modificar_Cursos(int ID_Cursos, string Descripcion, int ID_Categoria,  int estado)
    {
        da = new SqlDataAdapter("Modificar_Cursos", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("ID_curso", ID_Cursos);
        da.SelectCommand.Parameters.AddWithValue("@nombre_curso", Descripcion);
        da.SelectCommand.Parameters.AddWithValue("@Estado", estado);
        da.SelectCommand.Parameters.AddWithValue("@ID_Categoria", ID_Categoria); 
        da.Fill(ds, "Contenido Modificado");
        return ds;
    }

    public DataSet Buscar_Cursos(int ID_Cursos, string nombre_curso)
    {
        da = new SqlDataAdapter("Buscar_Cursos", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("ID_Cursos", ID_Cursos);
        da.SelectCommand.Parameters.AddWithValue("Nombre_Curso", nombre_curso);
        da.Fill(ds, "Curso Encontrado");
        return ds;
    }

    #endregion


    #region Temas
    public DataSet Mostrar_Temas()
    {
        da = new SqlDataAdapter("Mostrar_Temas", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.Fill(ds, "DataContenidos");
        return ds;
    }

    public DataSet Insertar_Temas(string nombre_tema, int ID_Curso, int ID_Categoria)
    {
        da = new SqlDataAdapter("Insertar_temas", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@nombre_tema", nombre_tema); 
        da.SelectCommand.Parameters.AddWithValue("@ID_Categoria", ID_Categoria);
        da.SelectCommand.Parameters.AddWithValue("@ID_Curso", ID_Curso);
        da.Fill(ds, "Tema Insertado");
        return ds;
    } 

    public DataSet Modificar_Temas(int ID_tema,string nombre_tema, int ID_Curso, int ID_Categoria)
    {
        da = new SqlDataAdapter("Modificar_temas", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@ID_tema", ID_tema);
        da.SelectCommand.Parameters.AddWithValue("@nombre_tema", nombre_tema);
        da.SelectCommand.Parameters.AddWithValue("@ID_Categoria", ID_Categoria);
        da.SelectCommand.Parameters.AddWithValue("@ID_Curso", ID_Curso);
        da.Fill(ds, "tema modificado");

        return ds;
    }

    public DataSet Buscar_Temas(int ID_tema, string nombre_tema)
    {
        da = new SqlDataAdapter("Buscar_Temas", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("ID_tema", ID_tema);
        da.SelectCommand.Parameters.AddWithValue("Nombre_Tema", nombre_tema);
        da.Fill(ds, "Tema Encontrado");
        return ds;
    }

    #endregion

    #region Privilegio
    public DataSet Mostrar_Privilegios()
    {
        da = new SqlDataAdapter("Mostrar_Privilegios", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.Fill(ds, "DataContenidos");
        return ds;
    }

    public DataSet Insertar_Privilegio(string nombre_privilegio )
    {
        da = new SqlDataAdapter("Insertar_Privilegio", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@nombre_priv", nombre_privilegio); 
        da.Fill(ds, "Privilegio Insertado");
        return ds;
    }

    public DataSet Modificar_Privilegio(int ID_Privilegio, string nombre_Privilegio )
    {
        da = new SqlDataAdapter("Modificar_Privilegios", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@ID_priv", ID_Privilegio);
        da.SelectCommand.Parameters.AddWithValue("@nombre_priv", nombre_Privilegio); 
        da.Fill(ds, "Privilegio modificado");

        return ds;
    }

    public DataSet Buscar_Privilegio(int ID_priv, string nombre_priv)
    {
        da = new SqlDataAdapter("Buscar_Privilegio", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("ID_priv", ID_priv);
        da.SelectCommand.Parameters.AddWithValue("Nombre_priv", nombre_priv);
        da.Fill(ds, "Privilegio Encontrado");
        return ds;
    }

    #endregion


    public DataSet Mostrar_Categorias()
    {
        da = new SqlDataAdapter("Mostrar_Categorias", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.Fill(ds,"Data de Categorias");
        return ds;
    }

    public DataSet Insertar_Contenidos(string Descripcion, string tipo, int ID_Categoria, int ID_Curso, int ID_Tema, byte[] archivo)
    {
        da = new SqlDataAdapter("Insertar_Contenidos", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Descripcion",Descripcion);
        da.SelectCommand.Parameters.AddWithValue("@Tipo",tipo);
        da.SelectCommand.Parameters.AddWithValue("@ID_Categoria",ID_Categoria);
        da.SelectCommand.Parameters.AddWithValue("@ID_Curso",ID_Curso);
        da.SelectCommand.Parameters.AddWithValue("@ID_Tema",ID_Tema);
        da.SelectCommand.Parameters.AddWithValue("@Archivo",archivo);
        da.Fill(ds,"Contenido Insertado");
        return ds;
    }

    public DataSet Modificar_Contenidos(int ID_Contenido, string Descripcion, string tipo, int ID_Categoria, int ID_Curso, int ID_Tema, byte[] archivo)
    {
        da = new SqlDataAdapter("Modificar_Contenidos", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("ID_Contenido",ID_Contenido);
        da.SelectCommand.Parameters.AddWithValue("@Descripcion", Descripcion);
        da.SelectCommand.Parameters.AddWithValue("@Tipo", tipo);
        da.SelectCommand.Parameters.AddWithValue("@ID_Categoria", ID_Categoria);
        da.SelectCommand.Parameters.AddWithValue("@ID_Curso", ID_Curso);
        da.SelectCommand.Parameters.AddWithValue("@ID_Tema", ID_Tema);
        da.SelectCommand.Parameters.AddWithValue("@Archivo", archivo);
        da.Fill(ds, "Contenido Modificado");
        return ds;
    }

    public DataSet Mostrar_Contenidos()
    {
        da = new SqlDataAdapter("Mostrar_Contenidos", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.Fill(ds, "DataContenidos");
        return ds;
    }
    public DataSet Buscar_Contenidos(int ID_Contenido, string Descripcion)
    {
        da = new SqlDataAdapter("Buscar_Contenidos", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("ID_Contenido",ID_Contenido);
        da.SelectCommand.Parameters.AddWithValue("Descripcion",Descripcion);
        da.Fill(ds,"ContenidoEncontrado");
        return ds;
    }
    public DataSet Mostrar_Contenidos_XTemas(int ID_Tema)
    {
        da = new SqlDataAdapter("Mostrar_Contenido_XTema", conexion);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@ID_Tema",ID_Tema);
        da.Fill(ds,"Contenido de Tema");
        return ds;
    }

    public byte[] RetornarStringEnBytes(string valor)
    {
        byte[] cadena;
        cadena = System.Text.Encoding.UTF8.GetBytes(valor);
        return cadena;
    }

    public string RetornarByteEnString(byte[] valor)
    {
        string cadena;
        cadena = System.Text.Encoding.UTF8.GetString(valor);
        return cadena;
    }
}

using System;
using System.ServiceModel;
using System.Data;
using System.Drawing;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{

    [OperationContract]
    DataSet Insertar_usuario(string Cod_usuario, string nombre, string apellido, int edad, string sexo, string fechanac, string pais, string depto, string telefono, string email, string pasword, string fecharegistro);

    [OperationContract]
    DataSet Modificar_Usuario(string Cod_usuario, string nombre, string apellido, int edad, string sexo, string fechanac, string pais, string depto, string telefono, string email, string pasword);

    [OperationContract]
    DataSet Eliminar_Usuario(string Cod_usuario);

    [OperationContract]
    DataSet Consultar_Usuario();

    [OperationContract]
    DataSet Insertar_Tema(string nombre_tema);

    [OperationContract]
    DataSet Modificar_Tema(int ID_tema, string nombre_tema);

    [OperationContract]
    DataSet Eliminar_Tema(int ID_tema);

    [OperationContract]
    DataSet Consultar_tema();

    [OperationContract]
    DataSet Mostrar_Temas_xCursos(int ID_Curso);

    [OperationContract]
    DataSet Insertar_curso(string nombre_curso, string estado, string ID_tema);

    [OperationContract]
    DataSet Modificar_curso(int id_curso, string nombre_curso, string estado, string ID_tema); 

    [OperationContract]
    DataSet Eliminar_curso(int id_curso);

    [OperationContract]
    DataSet Consultar_curso();

    [OperationContract]
    DataSet Mostrar_Cursos_Usuario(int Id_usuario, int ID_categoria);

    [OperationContract]
    DataSet Mostrar_Cursos_xCategoria(int ID_Categoria);

    #region Categoria

        [OperationContract]
        DataSet Insertar_Categorias(string nombre_cat);

        [OperationContract]
        DataSet Modificar_Categorias(int ID_Categoria, string nombre_cat);

        [OperationContract]
        DataSet Eliminar_Categoria(int ID_Categoria, string nombre_cat);

        [OperationContract]
        DataSet Mostrar_Categorias();

        [OperationContract]
        DataSet Buscar_Categoria(int ID_Categoria, string nombre_cat);

    #endregion

    #region Contenidos

    [OperationContract]
    DataSet Insertar_Contenidos(string Descripcion, string tipo, int ID_Categoria, int ID_Curso, int ID_Tema, byte[] archivo);

    [OperationContract]
    DataSet Modificar_Contenidos(int ID_Contenido, string Descripcion, string tipo, int ID_Categoria, int ID_Curso, int ID_Tema, byte[] archivo);

    [OperationContract]
    DataSet Mostrar_Contenidos(); 

    [OperationContract]
    DataSet Buscar_Contenidos(int ID_Contenido, string Descripcion);

    #endregion

    #region Cursos

    [OperationContract]
    DataSet Mostrar_Cursos();

    [OperationContract]
    DataSet Insertar_Cursos(string nombre_curso,  int ID_Categoria, int estado);

    [OperationContract]
    DataSet Modificar_Cursos(int ID_Cursos,string nombre_curso, int ID_Categoria, int estado);

    [OperationContract]
    DataSet Buscar_Cursos(int ID_Categoria, string nombre_cat);

    #endregion


    #region Temas 

    [OperationContract]
    DataSet Mostrar_Temas();

    [OperationContract]
    DataSet Insertar_Temas( string nombre_tema, int ID_Curso, int ID_Categoria );

    [OperationContract]
    DataSet Modificar_Temas(int ID_tema, string nombre_tema, int ID_Curso, int ID_Categoria);

    [OperationContract]
    DataSet Buscar_Temas(int ID_tema, string nombre_tema);


    #endregion




    #region Privilegios
    [OperationContract]
    DataSet Mostrar_Privilegios();

    [OperationContract]
    DataSet Insertar_Privilegio(string nombre_privilegio);

    [OperationContract]
    DataSet Modificar_Privilegio(int ID_Privilegio, string nombre_Privilegio );

    [OperationContract]
    DataSet Buscar_Privilegio(int ID_priv, string nombre_priv);

    #endregion


    [OperationContract]
    DataSet Mostrar_Contenidos_XTemas(int ID_Tema);

    [OperationContract]
    Byte[] RetornarStringEnBytes(string valor);

    [OperationContract]
    string RetornarByteEnString(byte[] valor);

}

using System;
using System.ServiceModel;
using System.Data;

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



    [OperationContract]
    DataSet Insertar_Contenidos(string Descripcion, string tipo, int ID_Categoria, int ID_Curso, int ID_Tema, byte[] archivo);

    [OperationContract]
    DataSet Modificar_Contenidos(int ID_Contenido, string Descripcion, string tipo, int ID_Categoria, int ID_Curso, int ID_Tema, byte[] archivo);

    [OperationContract]
    DataSet Mostrar_Contenidos();

    [OperationContract]
    DataSet Buscar_Contenidos(int ID_Contenido, string Descripcion);

    [OperationContract]
    DataSet Mostrar_Contenidos_XTemas(int ID_Tema);

    [OperationContract]
    Byte[] RetornarStringEnBytes(string valor);

    [OperationContract]
    string RetornarByteEnString(byte[] valor);

}

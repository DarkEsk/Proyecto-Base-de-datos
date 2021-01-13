''Para trabajar con una base de datos en ORACLE
Imports Oracle.DataAccess.Client

Module Globales

    'Para trabajar con una base de datos ORACLE, es requerida
    ' para poder abrir y cerrar la BD

    Public cnx As OracleConnection

    'Estas variables son de MI AUTORIA, la razón para sarlas de manera global
    ' es que las uso en diferentes formularios, y así evito tener que definirlas
    ' o declararlas en cada formulario. la palabra clave para que trabaje como 
    ' global es Public, el tipo de datos, pues ya ustedes lo definen de acuerdo 
    ' a su necesidad

End Module

# API-REST-PATIENT
##1. Resumen del Proyecto

  ###"Esta es una API RESTful para la gestión de información de pacientes, como su nombre, edad y síntomas. Fue desarrollada como un proyecto de demostración utilizando C# y ASP.NET Core, siguiendo una arquitectura limpia que separa las responsabilidades de cada componente.
  ###La API almacena los datos de forma temporal en memoria, por lo que se perderán al reiniciar la aplicación."
  
##2. Requisitos Previos

 ### Para poder ejecutar esta API en tu máquina local, debes tener instalado el SDK de .NET.
    ####1)SDK de .NET 8.0: Puedes descargarlo e instalarlo desde el sitio oficial de Microsoft( https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-8.0.413-windows-x64-installer ).
    ####2)Después de la instalación, reinicia tu terminal o línea de comandos. Puedes verificar que el SDK se instaló correctamente ejecutando el siguiente comando:
     ** Bash: dotnet --version **

##3. Configuración y Ejecución
  ###Sigue estos pasos para clonar el repositorio y poner la API en funcionamiento:
    1)Clona el repositorio desde la terminal:
      -Bash:  git clone https://github.com/tu-usuario/API-REST-PATIENT.git
    2)Navega al directorio del proyecto:
      -Bash: cd API-REST-PATIENT
    3)Ejecuta la API en el entorno de desarrollo para poder acceder a la interfaz de Swagger:
      -Bash: dotnet run --environment Development
***Nota: Si la ejecución es exitosa, la terminal te mostrará las URLs donde la API está escuchando.***

4. Arquitectura del Proyecto
  La API fue diseñada bajo el patrón de diseño Modelo-Controlador-Servicio (MCS), un enfoque que promueve la separación de responsabilidades para un código más limpio y fácil de mantener.
    *Modelos (Models/): Contiene las clases POCO (Plain Old C# Object) que definen la estructura de los datos que la API maneja. En este caso, la clase Patient define los atributos de cada paciente.
    *Servicios (Services/): Esta capa contiene la lógica de negocio y se encarga de la manipulación de los datos. El PatientRepository implementa las operaciones CRUD (crear, leer) para los pacientes. Esta separación permite que el almacenamiento de datos pueda ser
     cambiado (por ejemplo, a una base de datos real) sin modificar el controlador.
    *Controladores (Controllers/): Son la interfaz de la API. Los controladores reciben las peticiones HTTP (GET, POST) y coordinan con el servicio (PatientRepository) para llevar a cabo la operación solicitada. Su única responsabilidad es manejar las solicitudes y
     devolver las respuestas HTTP.
5. Uso de la API (Endpoints)
  Una vez que la API está en ejecución, puedes probarla fácilmente utilizando la interfaz de Swagger, que actúa como una documentación interactiva y te permite realizar peticiones directamente.
    Abre tu navegador y navega a: http://localhost:5000/swagger
    ***NOTA: El número de puerto puede cambiar, para saber el numero de puerto lo puedes verificar en tu terminal***
  Endpoints Disponibles:
   ------------------------------------------------------------------------------- 
    |Método|	Ruta	      |               Descripción                            |
   -------------------------------------------------------------------------------
    | GET	 |/api/Patients	|Obtiene una lista con todos los pacientes registrados.|
   -------------------------------------------------------------------------------
    |POST	 |/api/Patients	|Registra un nuevo paciente.                           |
   -------------------------------------------------------------------------------

6.Casos de Prueba
  Aquí hay algunos ejemplos de peticiones que puedes realizar desde Swagger para verificar el funcionamiento de la API.
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
|Método	|   Ruta	      |                   Cuerpo de la Petición (JSON)	                        |                        Resultado Esperado                                 |
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
|  POST	|/api/Patients	|{ "name": "Ana García", "age": 30, "symptoms": "Fiebre y escalofríos" }	|201 Created. El servidor devuelve el objeto del paciente creado.           |
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
|  GET	|/api/Patients	|                    (no requiere)	                                      |200 OK. El servidor devuelve una lista que contiene el paciente registrado.|
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
|  POST	|/api/Patients	|{ "name": "Luis Vargas", "age": 55, "symptoms": "Dolor de pecho" }	      |201 Created. Se agrega un segundo paciente.                                |
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
|  GET	|/api/Patients	|                    (no requiere)	                                      |200 OK. El servidor devuelve una lista que contiene ambos pacientes.       |
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------





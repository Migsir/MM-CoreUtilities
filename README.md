
# MMUtilities

## Descripción
`MMUtilities` es una biblioteca de utilidades para la manipulación de archivos en C#. Provee métodos para copiar, mover, y listar archivos dentro de directorios, facilitando la gestión de archivos con soporte para búsquedas por extensión y opciones de sobreescritura.

## Instalación
Clona este repositorio en tu máquina local utilizando:
```
git clone https://github.com/Migsir/MM-CoreUtilities.git
```

## Uso
Para usar `MMUtilities`, incluye el archivo `FileOperations.cs` en tu proyecto de C# y asegúrate de importar el espacio de nombres `MMUtilities`:
```csharp
using MMUtilities;
```

### Ejemplo de Copiado de Archivos por Extensión
```csharp
var fileOps = new FileOperations();
fileOps.CopyFilesByExtension(@"C:\path	o\source", @"C:\path	o	arget", "txt", overwriteFiles: true, moveFiles: false);
```

### Ejemplo de Listado de Archivos
```csharp
var fileOps = new FileOperations();
fileOps.DisplayAllFiles(@"C:\path	o\your\directory");
```

## Contribución
Si deseas contribuir a `MMUtilities`, por favor haz un fork del repositorio y crea un pull request, o simplemente abre un issue con la etiqueta "enhancement".

## Licencia
Distribuido bajo la licencia MIT. Ver `LICENSE` para más información.

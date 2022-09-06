/***
 * Ejemplo de como invocar una clase dinámicamente por medio de una configuración almacenada en un archivo
 * de configuración
 ***/

using LlamadoDinamico;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;


string configPath = Directory.GetCurrentDirectory() + @"\Config.json";

if (File.Exists(configPath))
{
    //Obtención en bruto del archivo a texto
    string textConfiguration = File.ReadAllText(configPath);
    //de string a Jobject
    dynamic data = JObject.Parse((string)textConfiguration);
    string medio = data["Medio"];
    //se incluye la ruta del namespace completo más la clase
    string strclase = "LlamadoDinamico.FormasdeViaje." + medio;
    Iviajar viajar = (Iviajar)System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(strclase);
    bool resultado = viajar.ComienzoViaje("FarFaraway!");
    Console.ReadLine();
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Incubadora.Recursos {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Recursos_Sistema {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Recursos_Sistema() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Incubadora.Recursos.Recursos_Sistema", typeof(Recursos_Sistema).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Este campo es requerido.
        /// </summary>
        internal static string ERROR_CAMPO_REQUERIDO {
            get {
                return ResourceManager.GetString("ERROR_CAMPO_REQUERIDO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Ocurrió una exepción en el método eliminarProyecto del controlador Proyecto.
        /// </summary>
        internal static string ERROR_DELETE_PROYECTO_CONTROLADOR {
            get {
                return ResourceManager.GetString("ERROR_DELETE_PROYECTO_CONTROLADOR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Error no se pudo cargar la información..
        /// </summary>
        internal static string ERROR_LOAD_FILE_JSON {
            get {
                return ResourceManager.GetString("ERROR_LOAD_FILE_JSON", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Ocurrió una excepción en el método login (post) del controlador Account.
        /// </summary>
        internal static string ERROR_LOGIN_FAIL {
            get {
                return ResourceManager.GetString("ERROR_LOGIN_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El usuario ó la contraseña no son correctos verifique por favor..
        /// </summary>
        internal static string USUARIO_LOGIN_NULL {
            get {
                return ResourceManager.GetString("USUARIO_LOGIN_NULL", resourceCulture);
            }
        }
    }
}

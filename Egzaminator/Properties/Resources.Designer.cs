﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Egzaminator.Properties {
    using System;
    
    
    /// <summary>
    ///   Klasa zasobu wymagająca zdefiniowania typu do wyszukiwania zlokalizowanych ciągów itd.
    /// </summary>
    // Ta klasa została automatycznie wygenerowana za pomocą klasy StronglyTypedResourceBuilder
    // przez narzędzie, takie jak ResGen lub Visual Studio.
    // Aby dodać lub usunąć składową, edytuj plik ResX, a następnie ponownie uruchom narzędzie ResGen
    // z opcją /str lub ponownie utwórz projekt VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        /// Zwraca buforowane wystąpienie ResourceManager używane przez tę klasę.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Egzaminator.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Przesłania właściwość CurrentUICulture bieżącego wątku dla wszystkich
        ///   przypadków przeszukiwania zasobów za pomocą tej klasy zasobów wymagającej zdefiniowania typu.
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
        ///   Wyszukuje zlokalizowany zasób typu System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap background {
            get {
                object obj = ResourceManager.GetObject("background", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Wyszukuje zlokalizowany zasób typu System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap chair {
            get {
                object obj = ResourceManager.GetObject("chair", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Wyszukuje zlokalizowany zasób typu System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap chairs {
            get {
                object obj = ResourceManager.GetObject("chairs", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu 0----x1 0-1---- -----x- ---0--- -0----- ----2-1 x0----1.
        /// </summary>
        internal static string gridValues1 {
            get {
                return ResourceManager.GetString("gridValues1", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu 2----03 3-2---- -----0- ---x--- -3----- ----x-2 3x----0.
        /// </summary>
        internal static string gridValues2 {
            get {
                return ResourceManager.GetString("gridValues2", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu 1----3x 1-3---- -----2- ---1--- -1----- ----0-3 12----x.
        /// </summary>
        internal static string gridValues3 {
            get {
                return ResourceManager.GetString("gridValues3", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu x----12 x-0---- -----1- ---3--- -x----- ----1-0 21----2.
        /// </summary>
        internal static string gridValues4 {
            get {
                return ResourceManager.GetString("gridValues4", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu 3----20 2-x---- -----3- ---2--- -2----- ----3-x 03----3.
        /// </summary>
        internal static string gridValues5 {
            get {
                return ResourceManager.GetString("gridValues5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Wyszukuje zlokalizowany zasób typu System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap paper {
            get {
                object obj = ResourceManager.GetObject("paper", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}

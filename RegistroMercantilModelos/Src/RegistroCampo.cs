/*
    Este archivo forma parte del proyecto RegistroMercantilModelos(R).
    Copyright (c) 2020 Irene Solutions SL
    Autores: Manuel Diago García, Juan Bautista Garcia Traver.

    Este programa es software libre; lo puede distribuir y/o modificar
    según los terminos de la licencia GNU Affero General Public License
    versión 3 según su redacción de la Free Software Foundation con la
    siguiente condición añadida en la sección 15 según se establece en
    la sección 7(a):

    PARA CUALQUIER PARTE DEL CÓGIO PROPIEDAD DE IRENE SOLUTIONS. IRENE 
    SOLUTIONS NO SE HACE RESPONSABLE DE LA VULNERACIÓN DE DERECHOS 
    DE TERCEROS.

    Este programa se distribuye con la esperanza de que sea útil, pero
    SIN GARANTÍA DE NINGÚN TIPO; ni siquiera la derivada de un acuerdo
    comercial o utilización para un propósito particular.
   
    Para más información puede consultar la licencia GNU Affero General
    Public http://www.gnu.org/licenses o escribir a la Free Software 
    Foundation, Inc. , 51 Franklin Street, Fifth Floor,
    Boston, MA, 02110-1301 USA, o descargarla en la siguiente URL:
        http://www.irenesolutions.com/terms-of-use.pdf 

    Las interfaces de usuario con versiones del código fuente del presente 
    proyecto, modificado o no, o código de objeto del mismo, deben incluir
    de manera visible los correspondientes avisos legales exigidos en la
    sección 5 de la licencia GNU Affero General Public.
    
    Puede evitar el cumplimiento de lo establecido de lo establecido 
    anteriormente comprando una licencia comercial. 
    La compra de una licencia comercial es obligatoria
    desde el momento en que usted desarrolle software comercial incluyendo
    funcionalidades de AeatModelos sin la publicación del código fuente
    de sus propias aplicaciones.
    Estas actividades incluyen: La oferta de servicios de pago mediante
    aplicaciones web de cualquier tipo que incluyan la funcionalidad
    de AeatModelos.
    
    Para más información, contacte con la dirección: info@irenesolutions.com    
 */

using RegistroMercantilModelos.Configuración;
using RegistroMercantilModelos.Conversores;
using System;

namespace RegistroMercantilModelos
{
    /// <summary>
    /// Representa una casilla a rellenar
    /// para un modelo determinado.
    /// </summary>
    public class RegistroCampo : IEmpaquetable, ICasilla
    {
        #region Variables Privadas de Instancia

        /// <summary>
        /// Convierte datos obtenido de un archivo al formato
        /// utilizable por la aplicación y datos generados por
        /// la aplicación a formato para el archivo.
        /// </summary>
        IConversor _Conversor;

        /// <summary>
        /// Valor del campo.
        /// </summary>
        object _Valor;

        #endregion

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="pagina">Pagina del modelo que representa el fichero 
        /// en la que se encuentra la instancia de registro de campo definida
        /// en el diseño de registro correspondiente de la AEAT.</param>
        /// <param name="tipo">Cadena que representa el tipo de dato
        /// según la documentación del diseño de registro de la AEAT ('A',
        /// 'An', 'N'...)</param>
        /// <param name="descripcion">Descripción del campo en el diseño
        /// de registro de la AEAT.</param>
        /// <param name="clave">clave únivoca del campo en la página. Genralmente se utiliza como
        /// clave el número de casilla.</param>
        /// <param name="valor">Valor para el campo.</param>
        public RegistroCampo(int pagina, string tipo, string descripcion, string clave = null,
            string clavePersonalizada = null, object valor = null)
        {
            RegistroCampoTipo registroTipo;

            if (!Enum.TryParse(tipo, out registroTipo))
                throw new ArgumentException(
                    Errores.MostrarMensaje("RegistroCampo.000", tipo));

            Tipo = registroTipo;

            Pagina = pagina;
            Descripcion = descripcion;
            Clave = clave;
            ClavePersonalizada = clavePersonalizada;

            // Obtenemos el conversor mediante Reflection.
            string nombreTipoConversor = $"RegistroMercantilModelos.Conversores.{Tipo}";
            Type tipoConversor = RegistroMercantilModelosContexto.RegistroMercantilModelos.GetType(nombreTipoConversor);

            _Conversor = Activator.CreateInstance(tipoConversor, this) as IConversor;

            Valor = valor;
        }

        #endregion

        #region Indexadores

        /// <summary>
        /// Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.
        /// </summary>
        /// <param name="descripcion">Descripción del campo o clave si la tiene.</param>
        /// <returns>Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.</returns>
        public RegistroCampo this[string descripcion]
        {
            get
            {
                if (Descripcion == descripcion)
                    return this;

                if (ClavePersonalizada != null && ClavePersonalizada == descripcion)
                    return this;

                if (Clave != null && Clave == descripcion)
                    return this;

                return null;
            }
        }

        #endregion

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// Pagína del Registro
        /// </summary>
        public int Pagina { get; private set; }

        /// <summary>
        /// Descripción del campo.
        /// </summary>
        public string Descripcion { get; private set; }

        /// <summary>
        /// Clave unívoca del campo en la página. Se utiliza
        /// como clave el número de casilla en el modelo.
        /// </summary>
        public string Clave { get; private set; }

        /// <summary>
        /// Clave complementaria para apuntar al campo.
        /// </summary>
        public string ClavePersonalizada { get; private set; }

        /// <summary>
        /// Tipo de dato.
        /// </summary>
        public RegistroCampoTipo Tipo { get; private set; }

        /// <summary>
        /// Valor del campo.
        /// </summary>
        public object Valor
        {
            get
            {
                return _Valor;
            }
            set
            {
                _Valor = _Conversor.EstableceValor(value);
            }
        }

        /// <summary>
        /// Valor del campo.
        /// </summary>
        public string ValorFormateado
        {
            get
            {
                return _Conversor.ValorFormateado();
            }
        }

        #endregion

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Representación textual de la instancia.
        /// </summary>
        /// <returns>Representación textual de la instancia.</returns>
        public override string ToString()
        {
            return $"{Valor}, {Descripcion}";
        }

        /// <summary>
        /// Implementación del IComparable.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            return 0;
        }

        #endregion
    }
}

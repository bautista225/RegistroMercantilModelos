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

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace RegistroMercantilModelos
{

    /// <summary>
    /// Representa un formulario de declaración del Registro Mercantil.
    /// </summary>
    public interface IModelo
    {
        #region Propiedades Públicas de Instancia

        /// <summary>
        /// Archivo PDF del formulario a cumplimentar.
        /// </summary>
        byte[] PdfFormulario { get; }

        /// <summary>
        /// Color de fuente a utilizar en el formulario.
        /// </summary>
        BaseColor ColorFuente { get; set; }

        /// <summary>
        /// Tipo de fuente a utilizar en el formulario.
        /// </summary>
        BaseFont TipoFuente { get; set; }

        /// <summary>
        /// Permite definir si queremos que los campos del formulario PDF 
        /// a rellenar no sean modificables.
        /// </summary>
        bool BloquearEdicionCamposFormulario { get; set; }

        /// <summary>
        /// Si la instancia actual contiene más páginas
        /// estas se muestran como ConjuntoDeEmpaquetables
        /// en esta propiedad. Si no el valor de la propiedad
        /// es null.
        /// </summary>
        ConjuntoDeEmpaquetables Paginas { get; }

        #endregion

        #region Indexadores

        /// <summary>
        /// Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.
        /// </summary>
        /// <param name="descripcion">Descipción del campo.</param>
        /// <returns>Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.</returns>
        RegistroCampo this[string descripcion]
        {
            get;
        }

        #endregion

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Calcula el valor de una casilla a partir de otras.
        /// </summary>
        /// <param name="claves">Listado de casillas a acumular.</param>
        /// <param name="casilla">Casilla a calcular.</param>
        void CalculaCasilla(string[] claves, string casilla);

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        void Calcular();

        /// <summary>
        /// Rellena el formulario PDF correspondiente al modelo en curso.
        /// </summary>
        /// <returns>Documento PDF rellenado.</returns>
        byte[] RellenarFormulario();

        #endregion
    }
}
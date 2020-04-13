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

using System;

namespace RegistroMercantilModelos.Conversores
{
    /// <summary>
    /// Conversor por defecto.
    /// </summary>
    public class ConversorPorDefecto : IConversor
    {
        #region Variables Privadas Estáticas

        /// <summary>
        /// Campo subyacente.
        /// </summary>
        protected RegistroCampo _RegistroCampo;

        #endregion

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="registroCampo">Registro campo subyacente.</param>
        public ConversorPorDefecto(RegistroCampo registroCampo)
        {
            _RegistroCampo = registroCampo;
        }

        #endregion

        #region Indexadores

        /// <summary>
        /// Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.
        /// </summary>
        /// <param name="descripcion">Descipción del campo.</param>
        /// <returns>Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.</returns>
        public RegistroCampo this[string descripcion]
        {
            get
            {
                throw new NotImplementedException(Errores.MostrarMensaje("Conversor.000",
                  "indexador Conversor[string descripcion]"));
            }
        }

        #endregion

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// Valor del campo.
        /// </summary>
        public object Valor
        {
            get
            {
                return _RegistroCampo.Valor;
            }
            set
            {
                _RegistroCampo.Valor = value;
            }
        }

        /// <summary>
        /// Descripción del campo.
        /// </summary>
        public string Descripcion
        {
            get
            {
                return _RegistroCampo.Descripcion;
            }
        }

        #endregion        

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Convierte el campo al valor tipado.
        /// </summary>
        /// <param name="valor">Valor a convertir.</param>
        public virtual object EstableceValor(object valor)
        {
            string resultado = null;

            if (valor == null)
            {
                resultado = "";
            }
            else
            {
                resultado = valor.ToString();
            }

            return resultado;
        }

        /// <summary>
        /// Devuelve el valor formateado como cadena por defecto.
        /// </summary>
        /// <returns>Valor formateado como cadena por defecto.</returns>
        public virtual string ValorFormateado()
        {
            return _RegistroCampo.Valor.ToString();
        }

        public int CompareTo(object obj)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}

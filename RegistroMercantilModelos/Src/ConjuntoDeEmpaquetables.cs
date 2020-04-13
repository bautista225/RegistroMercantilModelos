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
using System.Collections.Generic;

namespace RegistroMercantilModelos
{
    /// <summary>
    /// Conjunto de elementos empaquetables.
    /// Puede representar el conjunto de varias páginas de un formulario.
    /// </summary>
    public class ConjuntoDeEmpaquetables : IEmpaquetable
    {
        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        public ConjuntoDeEmpaquetables() : this("Paginas")
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="descripcion">Descripción del conjunto de empaquetables.</param>
        public ConjuntoDeEmpaquetables(string descripcion)
        {
            Descripcion = descripcion;
        }

        #endregion

        #region Indexadores

        /// <summary>
        /// Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.
        /// </summary>
        /// <param name="descripcion">Descripción del campo.</param>
        /// <returns>Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.</returns>
        public RegistroCampo this[string descripcion]
        {
            get
            {
                throw new NotImplementedException(Errores.MostrarMensaje("ConjuntoDeEmpaquetables.000",
                    "indexador ConjuntoDeEmpaquetables[string descripcion]"));
            }
        }

        #endregion

        #region Métodos Privados de Instancia

        /// <summary>
        /// Lista de elementos empaquetables
        /// que compone el conjunto.
        /// </summary>
        public List<IEmpaquetable> Empaquetables { get; set; }

        #endregion

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// Valor del campo.
        /// </summary>
        public object Valor
        {
            get
            {
                throw new NotImplementedException(Errores.MostrarMensaje("ConjuntoDeEmpaquetables.000",
                    "método get de la propiedad ConjuntoDeEmpaquetables.Valor"));
            }
            set
            {
                throw new NotImplementedException(Errores.MostrarMensaje("ConjuntoDeEmpaquetables.000",
                    "método set de la propiedad ConjuntoDeEmpaquetables.Valor"));
            }
        }

        /// <summary>
        /// Descripción del campo.
        /// </summary>
        public string Descripcion { get; private set; }

        #endregion

        #region Métodos Públicos de Instancia

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

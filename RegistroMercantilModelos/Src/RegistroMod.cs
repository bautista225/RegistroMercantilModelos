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
using System;
using System.Collections.Generic;
using System.IO;

namespace RegistroMercantilModelos
{
    /// <summary>
    /// Modelo de un registro.
    /// </summary>
    public class RegistroMod : IEmpaquetable, IModelo
    {
        #region Variables Privadas de Instancia

        /// <summary>
        /// Permite definir si queremos que los campos del formulario PDF 
        /// a rellenar no sean modificables.
        /// </summary>
        private bool _BloquearEdicionCamposFormulario = true;

        /// <summary>
        /// Archivo PDF del formulario a cumplimentar.
        /// </summary>
        private byte[] _PdfFormulario;

        /// <summary>
        /// Tipo de fuente a usar en el formulario.
        /// </summary>
        private BaseFont _TipoFuente = BaseFont.CreateFont("calibri.ttf", BaseFont.CP1252, BaseFont.EMBEDDED, BaseFont.CACHED, Properties.Resources.calibri, null);

        /// <summary>
        /// Color de la fuente a utilizar en el formulario.
        /// </summary>
        private BaseColor _ColotFuente = new BaseColor(0, 15, 85); // Color azul tipo bolígrafo.

        #endregion

        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        public RegistroMod(string ejercicio)
        {
            Ejercicio = ejercicio;
        }

        #endregion

        #region Indexadores

        /// <summary>
        /// Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.
        /// </summary>
        /// <param name="descripcion">Descipción del campo o clave del campo.</param>
        /// <returns>Devuelve el campo que se corresponde con la descripción facilitada
        /// o null si no lo encuentra.</returns>
        public RegistroCampo this[string descripcion]
        {
            get
            {
                foreach (var parClaveValor in RegistroCampos)
                {
                    RegistroCampo campo = parClaveValor.Value as RegistroCampo;

                    if (campo != null && campo?.Descripcion == descripcion)
                        return campo;

                    if (campo != null && campo?.ClavePersonalizada != null && campo?.ClavePersonalizada == descripcion)
                        return campo;

                    if (campo != null && campo?.Clave != null && campo?.Clave == descripcion)
                        return campo;
                }

                return null;
            }
        }

        #endregion

        #region Propiedades Públicas de Instancia

        /// <summary>
        /// Archivo PDF del formulario a cumplimentar.
        /// </summary>
        public byte[] PdfFormulario
        {
            get
            {
                return _PdfFormulario;
            }
            protected set
            {
                _PdfFormulario = value;
            }
        }

        /// <summary>
        /// Permite definir si queremos que los campos del formulario PDF 
        /// a rellenar no sean modificables.
        /// </summary>
        public bool BloquearEdicionCamposFormulario 
        {
            get 
            {
                return _BloquearEdicionCamposFormulario;
            }
            set 
            {
                _BloquearEdicionCamposFormulario = value;
            } 
        }

        /// <summary>
        /// Tipo de fuente a utilizar en el formulario.
        /// </summary>
        public BaseFont TipoFuente
        {
            get
            {
                return _TipoFuente;
            }
            set
            {
                _TipoFuente = value;
            }
        }

        /// <summary>
        /// Color de fuente a utilizar en el formulario.
        /// </summary>
        public BaseColor ColorFuente
        {
            get
            {
                return _ColotFuente;
            }
            set
            {
                _ColotFuente = value;
            }
        }

        /// <summary>
        /// Descripción del campo.
        /// </summary>
        public string Descripcion
        {
            get
            {
                return $"{GetType()}";
            }
        }

        /// <summary>
        /// Ejercicio del formulario.
        /// </summary>
        public string Ejercicio { get; private set; }

        /// <summary>
        /// Diccionario de campos del modelo.
        /// </summary>
        public virtual Dictionary<decimal, IEmpaquetable> RegistroCampos { get; protected set; }

        /// <summary>
        /// Mapa con la equivalencia entre número de página y nombre
        /// del tipo empaquetable que la representa.
        /// </summary>
        public virtual Dictionary<int, string> PaginasMapa { get; protected set; }

        /// <summary>
        /// Si la instancia actual contiene más páginas
        /// estas se muestran como ConjuntoDeEmpaquetables
        /// en esta propiedad. Si no el valor de la propiedad
        /// es null.
        /// </summary>
        public ConjuntoDeEmpaquetables Paginas { get; protected set; }

        public object Valor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        #endregion

        #region Métodos Públicos Estáticos

        /// <summary>
        /// Crear un modelo para la generación del formulario.
        /// </summary>
        /// <param name="clave">Nombre del modelo a obtener</param>
        /// <param name="ejercicio">Nombre del modelo a obtener</param>
        /// <param name="periodo">Nombre del modelo a obtener</param>
        /// <returns>Modelo tributario determinado por la clave.</returns>
        public static IModelo CrearModelo(string clave,
            string ejercicio)
        {
            return CrearEmpaquetable(clave, ejercicio) as IModelo;
        }


        /// <summary>
        /// Crear empaquetable para la generación del formulario.
        /// </summary>
        /// <param name="clave">Nombre del empaquetable a obtener</param>
        /// <param name="ejercicio">Nombre del empaquetable a obtener</param>
        /// <param name="periodo">Nombre del empaquetable a obtener</param>
        /// <returns>Empaquetable.</returns>
        public static IEmpaquetable CrearEmpaquetable(string clave,
            string ejercicio)
        {
            Type tipoEmpaquetable = Type.GetType($"RegistroMercantilModelos.{clave}.{clave}");
            return Activator.CreateInstance(tipoEmpaquetable, ejercicio) as IEmpaquetable;
        }

        #endregion

        #region Métodos Públicos de Instancia

        /// <summary>
        /// Calcula el valor de una casilla a partir de otras.
        /// </summary>
        /// <param name="claves">Listado de casillas a acumular.</param>
        /// <param name="casilla">Casilla a calcular.</param>
        public virtual void CalculaCasilla(string[] claves, string casilla)
        {
            RegistroMod mod = this;

            decimal totalClavesEC = 0;
            decimal totalClavesEA = 0;

            foreach (var clave in claves)
            {
                totalClavesEC += Convert.ToDecimal(mod["EC" + clave]?.Valor);
                totalClavesEA += Convert.ToDecimal(mod["EA" + clave]?.Valor);
            }

            if (totalClavesEC != 0)
                if (Convert.ToDecimal(mod["EC" + casilla]?.Valor) == 0)
                    mod["EC" + casilla].Valor = totalClavesEC;

            if (totalClavesEA != 0)
                if (Convert.ToDecimal(mod["EA" + casilla]?.Valor) == 0)
                    mod["EA" + casilla].Valor = totalClavesEA;
        }

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public virtual void Calcular()
        {
            throw new NotImplementedException(Errores.MostrarMensaje("RegistroMod.001",
                  "método Calcular() de la clase RegistroMod"));
        }

        /// <summary>
        /// Rellena el formulario PDF correspondiente al modelo en curso.
        /// </summary>
        /// <returns>Documento PDF rellenado.</returns>
        public virtual byte[] RellenarFormulario()
        {

            PdfReader pdfReader = new PdfReader(PdfFormulario);
            MemoryStream formularioSalida = new MemoryStream();

            PdfStamper pdfStamper = new PdfStamper(pdfReader, formularioSalida);
            AcroFields pdfFormFields = pdfStamper.AcroFields;

            // Recorremos los campos del formulario PDF y los rellenamos con los valores de entrada.
            foreach (KeyValuePair<decimal, IEmpaquetable> iEmpaquetable in RegistroCampos)
            {
                RegistroCampo registroCampo = iEmpaquetable.Value as RegistroCampo;

                if (registroCampo.Tipo.Equals(RegistroCampoTipo.Cm))
                {
                    // Si se trata de un tipo "Cm - Cantidad monetaria", lo alineamos a la derecha, de manera que los decimales estén siempre alineados.
                    pdfFormFields.GetFieldItem(registroCampo.Clave).GetMerged(0).Put(PdfName.Q, new PdfNumber(PdfFormField.Q_RIGHT));
                }

                // Establecemos el tipo y color de fuente.
                pdfFormFields.SetFieldProperty(registroCampo.Clave, "textfont", TipoFuente, null);                
                pdfFormFields.SetFieldProperty(registroCampo.Clave, "textcolor", ColorFuente, null);

                // Escribimos en los campos el valor y su visualización. Ejemplo: 5555.2 --> 5.555,20
                pdfFormFields.SetField(registroCampo.Clave, registroCampo.Valor.ToString(), registroCampo.ValorFormateado, true);
            }

            // Establecemos la edición de campos en el PDF.
            pdfStamper.FormFlattening = BloquearEdicionCamposFormulario;

            // Cerramos el documento PDF.
            pdfStamper.Close();

            return formularioSalida.ToArray();
        }

        /// <summary>
        /// Implementación de IComparable.
        /// </summary>
        /// <param name="obj">Objeto a comparar.</param>
        /// <returns>Resultado de la comparación.</returns>
        public virtual int CompareTo(object obj)
        {
            return 0;
        }

        #endregion
    }
}

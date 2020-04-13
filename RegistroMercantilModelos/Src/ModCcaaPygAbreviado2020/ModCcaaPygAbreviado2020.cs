/*
    Este archivo forma parte del proyecto RegistroMercantilModelosx(R).
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

namespace RegistroMercantilModelos.ModCcaaPygAbreviado2020
{
    /// <summary>
    /// Formulario de la "Cuenta de Pérdidas y Ganancias - Abreviado" del Depósito anual de cuentas
    /// del Registro Mercantil español.
    /// </summary>
    public class ModCcaaPygAbreviado2020 : RegistroMod
    {
        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public ModCcaaPygAbreviado2020(string ejercicio) : base(ejercicio)
        {
            int c = 0;  // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NIF_12",                   "NIF")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "DENOMINACIÓN SOCIAL",      "DenominacionSocial")},

                {++c,    new RegistroCampo(0,   "N",    Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO_29",             "EjercicioCurso1",      Convert.ToDecimal(ejercicio))},
                {++c,    new RegistroCampo(0,   "N",    Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO_30",             "EjercicioAnterior1",   Convert.ToDecimal(ejercicio) - 1)},

                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA40100", "NM40100")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 140100",         "EC40100")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 240100",         "EA40100")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA40200", "NM40200")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 140200",         "EC40200")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 240200",         "EA40200")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA40300", "NM40300")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 140300",         "EC40300")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 240300",         "EA40300")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA40400", "NM40400")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 140400",         "EC40400")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 240400",         "EA40400")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA40500", "NM40500")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 140500",         "EC40500")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 240500",         "EA40500")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA40600", "NM40600")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 140600",         "EC40600")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 240600",         "EA40600")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA40700", "NM40700")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 140700",         "EC40700")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 240700",         "EA40700")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA40800", "NM40800")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 140800",         "EC40800")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 240800",         "EA40800")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA40900", "NM40900")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 140900",         "EC40900")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 240900",         "EA40900")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA41000", "NM41000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 141000",         "EC41000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 241000",         "EA41000")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA41100", "NM41100")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 141100",         "EC41100")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 241100",         "EA41100")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA41200", "NM41200")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 141200",         "EC41200")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 241200",         "EA41200")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA41300", "NM41300")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 141300",         "EC41300")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 241300",         "EA41300")},

                // *** RESULTADO DE EXPLOTACIÓN
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA49100", "NM49100")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 149100",         "EC49100")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 249100",         "EA49100")},

                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA41400", "NM41400")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 141400",         "EC41400")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 241400",         "EA41400")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA41430", "NM41430")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 141430",         "EC41430")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 241430",         "EA41430")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA41490", "NM41490")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 141490",         "EC41490")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 241490",         "EA41490")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA41500", "NM41500")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 141500",         "EC41500")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 241500",         "EA41500")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA41600", "NM41600")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 141600",         "EC41600")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 241600",         "EA41600")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA41700", "NM41700")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 141700",         "EC41700")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 241700",         "EA41700")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA41800", "NM41800")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 141800",         "EC41800")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 241800",         "EA41800")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA42100", "NM42100")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 142100",         "EC42100")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 242100",         "EA42100")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA42110", "NM42110")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 142110",         "EC42110")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 242110",         "EA42110")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA42120", "NM42120")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 142120",         "EC42120")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 242120",         "EA42120")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA42130", "NM42130")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 142130",         "EC42130")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 242130",         "EA42130")},

                // *** RESULTADO FINANCIERO 
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA49200", "NM49200")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 149200",         "EC49200")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 249200",         "EA49200")},

                // *** RESULTADO ANTES DE IMPUESTOS 
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA49300", "NM49300")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 149300",         "EC49300")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 249300",         "EA49300")},

                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA41900", "NM41900")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 141900",         "EC41900")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 241900",         "EA41900")},

                // *** RESULTADO DEL EJERCICIO  
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA49500", "NM49500")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 149500",         "EC49500")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 249500",         "EA49500")},

            };

            PdfFormulario = Properties.Resources.ModCcaaPygAbreviado2020; // Formulario PDF a rellenar.0
        }

        #endregion

        #region Métodos Públicos de instancia

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public override void Calcular()
        {
            ModCcaaPygAbreviado2020 mod = this;

            // ********** RESULTADO DE EXPLOTACIÓN **********

            string[] clavesResultadoDeExplotacion =
            {
                "40100", "40200", "40300", "40400", "40500", "40600", "40700",
                "40800", "40900", "41000", "41100", "41200", "41300"
            };

            string resultadoDeExplotacion = "49100";

            CalculaCasilla(clavesResultadoDeExplotacion, resultadoDeExplotacion);


            // ********** RESULTADO FINANCIERO **********

            string[] clavesIngresosFinancieros =
            {
                "41430", "41490"
            };

            string ingresosFinancieros = "41400";

            CalculaCasilla(clavesIngresosFinancieros, ingresosFinancieros);


            string[] clavesOtrosIngresosYGastosDeCaracterFinanciero =
            {
                "42110", "42120", "42130"
            };

            string otrosIngresosYGastosDeCaracterFinanciero = "42100";

            CalculaCasilla(clavesOtrosIngresosYGastosDeCaracterFinanciero, otrosIngresosYGastosDeCaracterFinanciero);


            string[] clavesResultadoFinanciero =
            {
                ingresosFinancieros, "41500", "41600", "41700", "41800", otrosIngresosYGastosDeCaracterFinanciero
            };

            string resultadoFinanciero = "42100";

            CalculaCasilla(clavesResultadoFinanciero, resultadoFinanciero);


            // ********** RESULTADO ANTES DE IMPUESTOS **********

            string[] clavesResultadoAntesDeImpuestos =
            {
                resultadoDeExplotacion, resultadoFinanciero
            };

            string resultadoAntesDeImpuestos = "49300";

            CalculaCasilla(clavesResultadoAntesDeImpuestos, resultadoAntesDeImpuestos);


            // ********** RESULTADO DEL EJERCICIO **********

            string[] clavesResultadoDelEjercicio =
            {
                resultadoAntesDeImpuestos, "41900"
            };

            string resultadoDelEjercicio = "49500";

            CalculaCasilla(clavesResultadoDelEjercicio, resultadoDelEjercicio);
        }

        #endregion
    }
}

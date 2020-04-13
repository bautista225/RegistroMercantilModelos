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

namespace RegistroMercantilModelos.ModCcaaBceAbreviado2020
{
    /// <summary>
    /// Formulario del "Balance de situación - Abreviado" del Depósito anual de cuentas
    /// del Registro Mercantil español.
    /// </summary>
    public class ModCcaaBceAbreviado2020 : RegistroMod
    {
        #region Construtores de Instancia

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ejercicio">AAAA: 2018</param>
        /// <param name="periodo">Periodo: 1T, 2T...01, 02...12</param>
        public ModCcaaBceAbreviado2020(string ejercicio) : base(ejercicio)
        {
            int c = 0;  // contador

            RegistroCampos = new Dictionary<decimal, IEmpaquetable>()
            {
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NIF_12",                   "NIF")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "DENOMINACIÓN SOCIAL",      "DenominacionSocial")},

                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "09001_2",                  "UnidadEuros")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "09002_2",                  "UnidadMiles")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "09003_2",                  "UnidadMillones")},

                {++c,    new RegistroCampo(0,   "N",    Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO_23",             "EjercicioCurso1",      Convert.ToDecimal(ejercicio))},
                {++c,    new RegistroCampo(0,   "N",    Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO_24",             "EjercicioAnterior1",   Convert.ToDecimal(ejercicio) - 1)},

                // *** ACTIVO
                // ** ACTIVO NO CORRIENTE
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA11000", "NM11000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 211000",         "EC11000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 311000",         "EA11000")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA11100", "NM11100")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 211100",         "EC11100")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 311100",         "EA11100")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA11200", "NM11200")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 211200",         "EC11200")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 311200",         "EA11200")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA11300", "NM11300")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 211300",         "EC11300")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 311300",         "EA11300")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA11400", "NM11400")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 211400",         "EC11400")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 311400",         "EA11400")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA11500", "NM11500")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 211500",         "EC11500")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 311500",         "EA11500")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA11600", "NM11600")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 211600",         "EC11600")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 311600",         "EA11600")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA11700", "NM11700")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 211700",         "EC11700")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 311700",         "EA11700")},

                // ** ACTIVO CORRIENTE
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA12000", "NM12000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 212000",         "EC12000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 312000",         "EA12000")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA12100", "NM12100")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 212100",         "EC12100")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 312100",         "EA12100")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA12200", "NM12200")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 212200",         "EC12200")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 312200",         "EA12200")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA12300", "NM12300")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 212300",         "EC12300")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 312300",         "EA12300")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA12380", "NM12380")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 212380",         "EC12380")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 312380",         "EA12380")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA12381", "NM12381")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 212381",         "EC12381")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 312381",         "EA12381")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA12382", "NM12382")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 212382",         "EC12382")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 312382",         "EA12382")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA12370", "NM12370")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 212370",         "EC12370")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 312370",         "EA12370")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA12390", "NM12390")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 212390",         "EC12390")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 312390",         "EA12390")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA12400", "NM12400")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 212400",         "EC12400")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 312400",         "EA12400")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA12500", "NM12500")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 212500",         "EC12500")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 312500",         "EA12500")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA12600", "NM12600")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 212600",         "EC12600")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 312600",         "EA12600")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA12700", "NM12700")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 212700",         "EC12700")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 312700",         "EA12700")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA10000", "NM10000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 210000",         "EC10000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 310000",         "EA10000")},

                {++c,    new RegistroCampo(0,   "N",    Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO_25",             "EjercicioCurso2",      Convert.ToDecimal(ejercicio))},
                {++c,    new RegistroCampo(0,   "N",    Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO_26",             "EjercicioAnterior2",   Convert.ToDecimal(ejercicio) - 1)},

                // *** PATRIMONIO NETO Y PASIVO
                // ** PATRIMONIO NETO
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA20000", "NM20000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 120000",         "EC20000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 220000",         "EA20000")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA21000", "NM21000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 121000",         "EC21000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 221000",         "EA21000")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA21100", "NM21100")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 121100",         "EC21100")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 221100",         "EA21100")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA21110", "NM21110")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 121110",         "EC21110")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 221110",         "EA21110")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA21120", "NM21120")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 121120",         "EC21120")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 221120",         "EA21120")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA21200", "NM21200")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 121200",         "EC21200")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 221200",         "EA21200")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA21300", "NM21300")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 121300",         "EC21300")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 221300",         "EA21300")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA21350", "NM21350")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 121350",         "EC21350")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 221350",         "EA21350")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA21360", "NM21360")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 121360",         "EC21360")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 221360",         "EA21360")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA21400", "NM21400")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 121400",         "EC21400")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 221400",         "EA21400")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA21500", "NM21500")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 121500",         "EC21500")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 221500",         "EA21500")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA21600", "NM21600")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 121600",         "EC21600")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 221600",         "EA21600")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA21700", "NM21700")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 121700",         "EC21700")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 221700",         "EA21700")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA21800", "NM21800")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 121800",         "EC21800")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 221800",         "EA21800")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA21900", "NM21900")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 121900",         "EC21900")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 221900",         "EA21900")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA22000", "NM22000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 122000",         "EC22000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 222000",         "EA22000")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA23000", "NM23000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 123000",         "EC23000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 223000",         "EA23000")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA31000", "NM31000")},

                // ** PASIVO NO CORRIENTE
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 131000",         "EC31000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 231000",         "EA31000")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA31100", "NM31100")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 131100",         "EC31100")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 231100",         "EA31100")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA31200", "NM31200")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 131200",         "EC31200")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 231200",         "EA31200")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA31220", "NM31220")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 131220",         "EC31220")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 231220",         "EA31220")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA31230", "NM31230")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 131230",         "EC31230")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 231230",         "EA31230")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA31290", "NM31290")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 131290",         "EC31290")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 231290",         "EA31290")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA31300", "NM31300")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 131300",         "EC31300")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 231300",         "EA31300")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA31400", "NM31400")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 131400",         "EC31400")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 231400",         "EA31400")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA31500", "NM31500")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 131500",         "EC31500")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 231500",         "EA31500")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA31600", "NM31600")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 131600",         "EC31600")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 231600",         "EA31600")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA31700", "NM31700")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 131700",         "EC31700")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 231700",         "EA31700")},

                {++c,    new RegistroCampo(0,   "N",    Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO_27",             "EjercicioCurso3",      Convert.ToDecimal(ejercicio))},
                {++c,    new RegistroCampo(0,   "N",    Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO_28",             "EjercicioAnterior3",   Convert.ToDecimal(ejercicio) - 1)},
                
                // ** PASIVO CORRIENTE
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA32000", "NM32000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 132000",         "EC32000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 232000",         "EA32000")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA32100", "NM32100")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 132100",         "EC32100")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 232100",         "EA32100")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA32200", "NM32200")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 132200",         "EC32200")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 232200",         "EA32200")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA32300", "NM32300")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 132300",         "EC32300")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 232300",         "EA32300")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA32320", "NM32320")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 132320",         "EC32320")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 232320",         "EA32320")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA32330", "NM32330")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 132330",         "EC32330")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 232330",         "EA32330")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA32390", "NM32390")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 132390",         "EC32390")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 232390",         "EA32390")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA32400", "NM32400")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 132400",         "EC32400")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 232400",         "EA32400")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA32500", "NM32500")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 132500",         "EC32500")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 232500",         "EA32500")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA32580", "NM32580")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 132580",         "EC32580")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 232580",         "EA32580")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA32581", "NM32581")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 132581",         "EC32581")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 232581",         "EA32581")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA32582", "NM32582")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 132582",         "EC32582")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 232582",         "EA32582")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA32590", "NM32590")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 132590",         "EC32590")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 232590",         "EA32590")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA32600", "NM32600")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 132600",         "EC32600")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 232600",         "EA32600")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA32700", "NM32700")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 132700",         "EC32700")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 232700",         "EA32700")},
                {++c,    new RegistroCampo(0,   "S",    Txt.Den[("" + c).PadLeft(3,'0')],   "NOTAS DE LA MEMORIA30000", "NM30000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 130000",         "EC30000")},
                {++c,    new RegistroCampo(0,   "Cm",   Txt.Den[("" + c).PadLeft(3,'0')],   "EJERCICIO 230000",         "EA30000")},
            };

            PdfFormulario = Properties.Resources.ModCcaaBceAbreviado2020; // Formulario PDF a rellenar.0
        }

        #endregion

        #region Métodos Públicos de instancia

        /// <summary>
        /// Actualiza el valor de todos los campos calculados.
        /// </summary>
        public override void Calcular()
        {
            ModCcaaBceAbreviado2020 mod = this;


            // ********** UNIDAD DE LAS CANTIDADES **********

            if (string.IsNullOrEmpty(mod["UnidadEuros"]?.Valor.ToString()) && string.IsNullOrEmpty(mod["UnidadMiles"]?.Valor.ToString()) && string.IsNullOrEmpty(mod["UnidadMillones"]?.Valor.ToString()))
                mod["UnidadEuros"].Valor = "X"; // Si no se indica lo contrario, por defecto unidades en euros.


            // ********** ACTIVO NO CORRIENTE **********

            string[] clavesActivoNoCorriente = 
            { 
                "11100", "11200", "11300", "11400", "11500", "11600", "11700" 
            };

            string activoNoCorriente = "11000";

            CalculaCasilla(clavesActivoNoCorriente, activoNoCorriente);


            // ********** ACTIVO CORRIENTE **********

            string[] clavesClientesPorVentasYPrestacionesServicios = 
            {
                "12381", "12382"
            };

            string clientesPorVentasYPrestacionesServicios = "12380";

            CalculaCasilla(clavesClientesPorVentasYPrestacionesServicios, clientesPorVentasYPrestacionesServicios);


            string[] clavesDeudoresComercialesYOtrasCuentasACobrar = 
            {
                clientesPorVentasYPrestacionesServicios, "12370", "12390"
            };

            string deudoresComercialesYOtrasCuentasACobrar = "12300";

            CalculaCasilla(clavesDeudoresComercialesYOtrasCuentasACobrar, deudoresComercialesYOtrasCuentasACobrar);
                       

            string[] clavesActivoCorriente = 
            {
                "12100", "12200", deudoresComercialesYOtrasCuentasACobrar,
                "12400", "12500", "12600", "12700"
            };

            string activoCorriente = "12000";

            CalculaCasilla(clavesActivoCorriente, activoCorriente);

            // **********************************
            // ********** TOTAL ACTIVO **********
            // **********************************

            string[] clavesTotalActivo = 
            {
                activoNoCorriente, activoCorriente
            };

            string totalActivo = "10000";

            CalculaCasilla(clavesTotalActivo, totalActivo);


            // ********** PATRIMONIO NETO **********

            string[] clavesCapital = 
            {
                "21110", "21120"
            };

            string capital = "21100";

            CalculaCasilla(clavesCapital, capital);


            string[] clavesReservas = 
            {
                "21350", "21360"
            };

            string reservas = "21300";

            CalculaCasilla(clavesReservas, reservas);


            string[] clavesFondosPropios =
            {
                capital, "21200", reservas, "21400", "21500", "21600", "21700",
                "21800", "21900"
            };

            string fondosPropios = "21000";

            CalculaCasilla(clavesFondosPropios, fondosPropios);


            string[] clavesPatrimonioNeto =
            {
                fondosPropios, "22000", "23000"
            };

            string patrimonioNeto = "20000";

            CalculaCasilla(clavesPatrimonioNeto, patrimonioNeto);


            // ********** PASIVO NO CORRIENTE **********

            string[] clavesDeudasLargoPlazo =
            {
                "31220", "31230", "31290"
            };

            string deudasLargoPlazo = "31200";

            CalculaCasilla(clavesDeudasLargoPlazo, deudasLargoPlazo);


            string[] clavesPasivoNoCorriente =
            {
                "31100", deudasLargoPlazo, "31300", "31400", "31500", "31600", "31700"
            };

            string pasivoNoCorriente = "31000";

            CalculaCasilla(clavesPasivoNoCorriente, pasivoNoCorriente);


            // ********** PASIVO NO CORRIENTE **********

            string[] clavesDeudasCortoPlazo =
            {
                "32320", "32330", "32390"
            };

            string deudasCortoPlazo = "32300";

            CalculaCasilla(clavesDeudasCortoPlazo, deudasCortoPlazo);


            string[] clavesProveedores =
            {
                "32581", "32582"
            };

            string proveedores = "32580";

            CalculaCasilla(clavesProveedores, proveedores);


            string[] clavesAcreedoresComercialesYOtrasCuentasPagar =
            {
                proveedores, "32590"
            };

            string acreedoresComercialesYOtrasCuentasPagar = "32500";

            CalculaCasilla(clavesAcreedoresComercialesYOtrasCuentasPagar, acreedoresComercialesYOtrasCuentasPagar);


            string[] clavesPasivoCorriente =
            {
                "32100", "32200", deudasCortoPlazo, "32400", acreedoresComercialesYOtrasCuentasPagar,
                "32600", "32700"
            };

            string pasivoCorriente = "32000";

            CalculaCasilla(clavesPasivoCorriente, pasivoCorriente);

            // ****************************************************
            // ********** TOTAL PATRIMONIO NETO Y PASIVO **********
            // ****************************************************

            string[] clavesTotalPatrimonioNetoYPasivo =
            {
                patrimonioNeto, pasivoNoCorriente, pasivoCorriente
            };

            string totalPatrimonioNetoYPasivo = "30000";

            CalculaCasilla(clavesTotalPatrimonioNetoYPasivo, totalPatrimonioNetoYPasivo);
        }

        #endregion
    }
}

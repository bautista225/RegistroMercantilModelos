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

using System.Collections.Generic;

namespace RegistroMercantilModelos.ModCcaaPygAbreviado2020
{
    /// <summary>
    /// Descripciones de los campos a rellenar.
    /// </summary>
    public class Txt
    {
        #region Propiedades Públicas Estáticas

        /// <summary>
        /// Diccionario con las descripciones de campo
        /// según clave (Número de casilla en el formulario oficial, adjunto).
        /// </summary>
        public static Dictionary<string, string> Den = new Dictionary<string, string>() {
            {"001",     "NIF"},
            {"002",     "Denominación social"},
            {"003",     "Ejercicio en curso - PA"},
            {"004",     "Ejercicio anterior - PA"},
            {"005",     "NOTAS DE LA MEMORIA; 1. Importe neto de la cifra de negocios"},
            {"006",     "1. Importe neto de la cifra de negocios"},
            {"007",     "EJERCICIO ANTERIOR; 1. Importe neto de la cifra de negocios"},
            {"008",     "NOTAS DE LA MEMORIA; 2. Variación de existencias de productos terminados y en curso de fabricación"},
            {"009",     "2. Variación de existencias de productos terminados y en curso de fabricación"},
            {"010",     "EJERCICIO ANTERIOR; 2. Variación de existencias de productos terminados y en curso de fabricación"},
            {"011",     "NOTAS DE LA MEMORIA; 3. Trabajos realizados por la empresa para su activo"},
            {"012",     "3. Trabajos realizados por la empresa para su activo"},
            {"013",     "EJERCICIO ANTERIOR; 3. Trabajos realizados por la empresa para su activo"},
            {"014",     "NOTAS DE LA MEMORIA; 4. Aprovisionamientos"},
            {"015",     "4. Aprovisionamientos"},
            {"016",     "EJERCICIO ANTERIOR; 4. Aprovisionamientos"},
            {"017",     "NOTAS DE LA MEMORIA; 5. Otros ingresos de explotación"},
            {"018",     "5. Otros ingresos de explotación"},
            {"019",     "EJERCICIO ANTERIOR; 5. Otros ingresos de explotación"},
            {"020",     "NOTAS DE LA MEMORIA; 6. Gastos de personal"},
            {"021",     "6. Gastos de personal"},
            {"022",     "EJERCICIO ANTERIOR; 6. Gastos de personal"},
            {"023",     "NOTAS DE LA MEMORIA; 7. Otros gastos de explotación"},
            {"024",     "7. Otros gastos de explotación"},
            {"025",     "EJERCICIO ANTERIOR; 7. Otros gastos de explotación"},
            {"026",     "NOTAS DE LA MEMORIA; 8. Amortización del inmovilizado"},
            {"027",     "8. Amortización del inmovilizado"},
            {"028",     "EJERCICIO ANTERIOR; 8. Amortización del inmovilizado"},
            {"029",     "NOTAS DE LA MEMORIA; 9. Imputación de subvenciones de inmovilizado no financiero y otras"},
            {"030",     "9. Imputación de subvenciones de inmovilizado no financiero y otras"},
            {"031",     "EJERCICIO ANTERIOR; 9. Imputación de subvenciones de inmovilizado no financiero y otras"},
            {"032",     "NOTAS DE LA MEMORIA; 10. Excesos de provisiones"},
            {"033",     "10. Excesos de provisiones"},
            {"034",     "EJERCICIO ANTERIOR; 10. Excesos de provisiones"},
            {"035",     "NOTAS DE LA MEMORIA; 11. Deterioro y resultado por enajenaciones del inmovilizado"},
            {"036",     "11. Deterioro y resultado por enajenaciones del inmovilizado"},
            {"037",     "EJERCICIO ANTERIOR; 11. Deterioro y resultado por enajenaciones del inmovilizado"},
            {"038",     "NOTAS DE LA MEMORIA; 12. Diferencia negativa de combinaciones de negocio"},
            {"039",     "12. Diferencia negativa de combinaciones de negocio"},
            {"040",     "EJERCICIO ANTERIOR; 12. Diferencia negativa de combinaciones de negocio"},
            {"041",     "NOTAS DE LA MEMORIA; 13. Otros resultados"},
            {"042",     "13. Otros resultados"},
            {"043",     "EJERCICIO ANTERIOR; 13. Otros resultados"},
            {"044",     "NOTAS DE LA MEMORIA; A) RESULTADO DE EXPLOTACIÓN (1+2+3+4+5+6+7+8+9+10+11+12+13)"},
            {"045",     "A) RESULTADO DE EXPLOTACIÓN (1+2+3+4+5+6+7+8+9+10+11+12+13)"},
            {"046",     "EJERCICIO ANTERIOR; A) RESULTADO DE EXPLOTACIÓN (1+2+3+4+5+6+7+8+9+10+11+12+13)"},
            {"047",     "NOTAS DE LA MEMORIA; 14. Ingresos financieros"},
            {"048",     "14. Ingresos financieros"},
            {"049",     "EJERCICIO ANTERIOR; 14. Ingresos financieros"},
            {"050",     "NOTAS DE LA MEMORIA; a) Imputación de subvenciones, donaciones y legados de carácter financiero"},
            {"051",     "a) Imputación de subvenciones, donaciones y legados de carácter financiero"},
            {"052",     "EJERCICIO ANTERIOR; a) Imputación de subvenciones, donaciones y legados de carácter financiero"},
            {"053",     "NOTAS DE LA MEMORIA; b) Otros ingresos financieros"},
            {"054",     "b) Otros ingresos financieros"},
            {"055",     "EJERCICIO ANTERIOR; b) Otros ingresos financieros"},
            {"056",     "NOTAS DE LA MEMORIA; 15. Gastos financieros"},
            {"057",     "15. Gastos financieros"},
            {"058",     "EJERCICIO ANTERIOR; 15. Gastos financieros"},
            {"059",     "NOTAS DE LA MEMORIA; 16. Variación de valor razonable en instrumentos financieros"},
            {"060",     "16. Variación de valor razonable en instrumentos financieros"},
            {"061",     "EJERCICIO ANTERIOR; 16. Variación de valor razonable en instrumentos financieros"},
            {"062",     "NOTAS DE LA MEMORIA; 17. Diferencias de cambio"},
            {"063",     "17. Diferencias de cambio"},
            {"064",     "EJERCICIO ANTERIOR; 17. Diferencias de cambio"},
            {"065",     "NOTAS DE LA MEMORIA; 18. Deterioro y resultado por enajenaciones de instrumentos financieros"},
            {"066",     "18. Deterioro y resultado por enajenaciones de instrumentos financieros"},
            {"067",     "EJERCICIO ANTERIOR; 18. Deterioro y resultado por enajenaciones de instrumentos financieros"},
            {"068",     "NOTAS DE LA MEMORIA; 19. Otros ingresos y gastos de carácter financiero"},
            {"069",     "19. Otros ingresos y gastos de carácter financiero"},
            {"070",     "EJERCICIO ANTERIOR; 19. Otros ingresos y gastos de carácter financiero"},
            {"071",     "NOTAS DE LA MEMORIA; a) Incorporación al activo de gastos financieros"},
            {"072",     "a) Incorporación al activo de gastos financieros"},
            {"073",     "EJERCICIO ANTERIOR; a) Incorporación al activo de gastos financieros"},
            {"074",     "NOTAS DE LA MEMORIA; b) Ingresos financieros derivados de convenios de acreedores"},
            {"075",     "b) Ingresos financieros derivados de convenios de acreedores"},
            {"076",     "EJERCICIO ANTERIOR; b) Ingresos financieros derivados de convenios de acreedores"},
            {"077",     "NOTAS DE LA MEMORIA; c) Resto de ingresos y gastos"},
            {"078",     "c) Resto de ingresos y gastos"},
            {"079",     "EJERCICIO ANTERIOR; c) Resto de ingresos y gastos"},
            {"080",     "NOTAS DE LA MEMORIA; B) RESULTADO FINANCIERO (14+15+16+17+18+19)"},
            {"081",     "B) RESULTADO FINANCIERO (14+15+16+17+18+19)"},
            {"082",     "EJERCICIO ANTERIOR; B) RESULTADO FINANCIERO (14+15+16+17+18+19)"},
            {"083",     "NOTAS DE LA MEMORIA; C) RESULTADO ANTES DE IMPUESTOS (A+B)"},
            {"084",     "C) RESULTADO ANTES DE IMPUESTOS (A+B)"},
            {"085",     "EJERCICIO ANTERIOR; C) RESULTADO ANTES DE IMPUESTOS (A+B)"},
            {"086",     "NOTAS DE LA MEMORIA; 20. Impuestos sobre beneficios"},
            {"087",     "20. Impuestos sobre beneficios"},
            {"088",     "EJERCICIO ANTERIOR; 20. Impuestos sobre beneficios"},
            {"089",     "NOTAS DE LA MEMORIA; D) RESULTADO DEL EJERCICIO (C+20)"},
            {"090",     "D) RESULTADO DEL EJERCICIO (C+20)"},
            {"091",     "EJERCICIO ANTERIOR; D) RESULTADO DEL EJERCICIO (C+20)"},
        };

        #endregion
    }
}

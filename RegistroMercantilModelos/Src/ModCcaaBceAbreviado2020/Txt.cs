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

namespace RegistroMercantilModelos.ModCcaaBceAbreviado2020
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
            {"003",     "Unidad. Euros"},
            {"004",     "Unidad. Miles"},
            {"005",     "Unidad. Millones"},
            {"006",     "Ejercicio en curso - BA1"},
            {"007",     "Ejercicio anterior - BA1"},
            {"008",     "NOTAS DE LA MEMORIA; A) ACTIVO NO CORRIENTE"},
            {"009",     "EJERCICIO EN CURSO; A) ACTIVO NO CORRIENTE"},
            {"010",     "EJERCICIO ANTERIOR; A) ACTIVO NO CORRIENTE"},
            {"011",     "NOTAS DE LA MEMORIA; I. Inmovilizado intangible"},
            {"012",     "EJERCICIO EN CURSO; I. Inmovilizado intangible"},
            {"013",     "EJERCICIO ANTERIOR; I. Inmovilizado intangible"},
            {"014",     "NOTAS DE LA MEMORIA; II. Inmovilizado material"},
            {"015",     "EJERCICIO EN CURSO; II. Inmovilizado material"},
            {"016",     "EJERCICIO ANTERIOR; II. Inmovilizado material"},
            {"017",     "NOTAS DE LA MEMORIA; III. Inversiones inmobiliarias"},
            {"018",     "EJERCICIO EN CURSO; III. Inversiones inmobiliarias"},
            {"019",     "EJERCICIO ANTERIOR; III. Inversiones inmobiliarias"},
            {"020",     "NOTAS DE LA MEMORIA; IV. Inversiones en empresas del grupo y asociadas a largo plazo"},
            {"021",     "EJERCICIO EN CURSO; IV. Inversiones en empresas del grupo y asociadas a largo plazo"},
            {"022",     "EJERCICIO ANTERIOR; IV. Inversiones en empresas del grupo y asociadas a largo plazo"},
            {"023",     "NOTAS DE LA MEMORIA; V. Inversiones financieras a largo plazo"},
            {"024",     "EJERCICIO EN CURSO; V. Inversiones financieras a largo plazo"},
            {"025",     "EJERCICIO ANTERIOR; V. Inversiones financieras a largo plazo"},
            {"026",     "NOTAS DE LA MEMORIA; VI. Activos por impuesto diferido"},
            {"027",     "EJERCICIO EN CURSO; VI. Activos por impuesto diferido"},
            {"028",     "EJERCICIO ANTERIOR; VI. Activos por impuesto diferido"},
            {"029",     "NOTAS DE LA MEMORIA; VII. Deudores comerciales no corrientes"},
            {"030",     "EJERCICIO EN CURSO; VII. Deudores comerciales no corrientes"},
            {"031",     "EJERCICIO ANTERIOR; VII. Deudores comerciales no corrientes"},
            {"032",     "NOTAS DE LA MEMORIA; B) ACTIVO CORRIENTE"},
            {"033",     "EJERCICIO EN CURSO; B) ACTIVO CORRIENTE"},
            {"034",     "EJERCICIO ANTERIOR; B) ACTIVO CORRIENTE"},
            {"035",     "NOTAS DE LA MEMORIA; I. Activos no corrientes mantenidos para la venta"},
            {"036",     "EJERCICIO EN CURSO; I. Activos no corrientes mantenidos para la venta"},
            {"037",     "EJERCICIO ANTERIOR; I. Activos no corrientes mantenidos para la venta"},
            {"038",     "NOTAS DE LA MEMORIA; II. Existencias"},
            {"039",     "EJERCICIO EN CURSO; II. Existencias"},
            {"040",     "EJERCICIO ANTERIOR; II. Existencias"},
            {"041",     "NOTAS DE LA MEMORIA; III. Deudores comerciales y otras cuentas a cobrar"},
            {"042",     "EJERCICIO EN CURSO; III. Deudores comerciales y otras cuentas a cobrar"},
            {"043",     "EJERCICIO ANTERIOR; III. Deudores comerciales y otras cuentas a cobrar"},
            {"044",     "NOTAS DE LA MEMORIA; 1. Clientes por ventas y prestaciones de servicios"},
            {"045",     "EJERCICIO EN CURSO; 1. Clientes por ventas y prestaciones de servicios"},
            {"046",     "EJERCICIO ANTERIOR; 1. Clientes por ventas y prestaciones de servicios"},
            {"047",     "NOTAS DE LA MEMORIA; a) Clientes por ventas y prestaciones de servicios a largo plazo"},
            {"048",     "EJERCICIO EN CURSO; a) Clientes por ventas y prestaciones de servicios a largo plazo"},
            {"049",     "EJERCICIO ANTERIOR; a) Clientes por ventas y prestaciones de servicios a largo plazo"},
            {"050",     "NOTAS DE LA MEMORIA; b) Clientes por ventas y prestaciones de servicios a corto plazo"},
            {"051",     "EJERCICIO EN CURSO; b) Clientes por ventas y prestaciones de servicios a corto plazo"},
            {"052",     "EJERCICIO ANTERIOR; b) Clientes por ventas y prestaciones de servicios a corto plazo"},
            {"053",     "NOTAS DE LA MEMORIA; 2. Accionistas (socios) por desembolsos exigidos"},
            {"054",     "EJERCICIO EN CURSO; 2. Accionistas (socios) por desembolsos exigidos"},
            {"055",     "EJERCICIO ANTERIOR; 2. Accionistas (socios) por desembolsos exigidos"},
            {"056",     "NOTAS DE LA MEMORIA; 3. Otros deudores"},
            {"057",     "EJERCICIO EN CURSO; 3. Otros deudores"},
            {"058",     "EJERCICIO ANTERIOR; 3. Otros deudores"},
            {"059",     "NOTAS DE LA MEMORIA; IV. Inversiones en empresas del grupo y asociadas a corto plazo"},
            {"060",     "EJERCICIO EN CURSO; IV. Inversiones en empresas del grupo y asociadas a corto plazo"},
            {"061",     "EJERCICIO ANTERIOR; IV. Inversiones en empresas del grupo y asociadas a corto plazo"},
            {"062",     "NOTAS DE LA MEMORIA; V. Inversiones financieras a corto plazo"},
            {"063",     "EJERCICIO EN CURSO; V. Inversiones financieras a corto plazo"},
            {"064",     "EJERCICIO ANTERIOR; V. Inversiones financieras a corto plazo"},
            {"065",     "NOTAS DE LA MEMORIA; VI. Periodificaciones a corto plazo"},
            {"066",     "EJERCICIO EN CURSO; VI. Periodificaciones a corto plazo"},
            {"067",     "EJERCICIO ANTERIOR; VI. Periodificaciones a corto plazo"},
            {"068",     "NOTAS DE LA MEMORIA; VII. Efectivo y otros activos líquidos equivalentes"},
            {"069",     "EJERCICIO EN CURSO; VII. Efectivo y otros activos líquidos equivalentes"},
            {"070",     "EJERCICIO ANTERIOR; VII. Efectivo y otros activos líquidos equivalentes"},
            {"071",     "NOTAS DE LA MEMORIA; TOTAL ACTIVO (A+B)"},
            {"072",     "EJERCICIO EN CURSO; TOTAL ACTIVO (A+B)"},
            {"073",     "EJERCICIO ANTERIOR; TOTAL ACTIVO (A+B)"},
            {"074",     "Ejercicio en curso - BA2.1"},
            {"075",     "Ejercicio anterior - BA2.1"},
            {"076",     "NOTAS DE LA MEMORIA; A) PATRIMONIO NETO"},
            {"077",     "A) PATRIMONIO NETO"},
            {"078",     "EJERCICIO ANTERIOR; A) PATRIMONIO NETO"},
            {"079",     "NOTAS DE LA MEMORIA; A-1) Fondos propios"},
            {"080",     "A-1) Fondos propios"},
            {"081",     "EJERCICIO ANTERIOR; A-1) Fondos propios"},
            {"082",     "NOTAS DE LA MEMORIA; I. Capital"},
            {"083",     "I. Capital"},
            {"084",     "EJERCICIO ANTERIOR; I. Capital"},
            {"085",     "NOTAS DE LA MEMORIA; 1. Capital escriturado"},
            {"086",     "1. Capital escriturado"},
            {"087",     "EJERCICIO ANTERIOR; 1. Capital escriturado"},
            {"088",     "NOTAS DE LA MEMORIA; 2. (Capital no exigido)"},
            {"089",     "2. (Capital no exigido)"},
            {"090",     "EJERCICIO ANTERIOR; 2. (Capital no exigido)"},
            {"091",     "NOTAS DE LA MEMORIA; II. Prima de emisión"},
            {"092",     "II. Prima de emisión"},
            {"093",     "EJERCICIO ANTERIOR; II. Prima de emisión"},
            {"094",     "NOTAS DE LA MEMORIA; III. Reservas"},
            {"095",     "III. Reservas"},
            {"096",     "EJERCICIO ANTERIOR; III. Reservas"},
            {"097",     "NOTAS DE LA MEMORIA; 1. Reserva de capitalización"},
            {"098",     "1. Reserva de capitalización"},
            {"099",     "EJERCICIO ANTERIOR; 1. Reserva de capitalización"},
            {"100",     "NOTAS DE LA MEMORIA; 2. Otras reservas"},
            {"101",     "2. Otras reservas"},
            {"102",     "EJERCICIO ANTERIOR; 2. Otras reservas"},
            {"103",     "NOTAS DE LA MEMORIA; IV. (Acciones y participaciones en patrimonio propias)"},
            {"104",     "IV. (Acciones y participaciones en patrimonio propias)"},
            {"105",     "EJERCICIO ANTERIOR; IV. (Acciones y participaciones en patrimonio propias)"},
            {"106",     "NOTAS DE LA MEMORIA; V. Resultados de ejercicios anteriores"},
            {"107",     "V. Resultados de ejercicios anteriores"},
            {"108",     "EJERCICIO ANTERIOR; V. Resultados de ejercicios anteriores"},
            {"109",     "NOTAS DE LA MEMORIA; VI. Otras aportaciones de socios"},
            {"110",     "VI. Otras aportaciones de socios"},
            {"111",     "EJERCICIO ANTERIOR; VI. Otras aportaciones de socios"},
            {"112",     "NOTAS DE LA MEMORIA; VII. Resultado del ejercicio"},
            {"113",     "VII. Resultado del ejercicio"},
            {"114",     "EJERCICIO ANTERIOR; VII. Resultado del ejercicio"},
            {"115",     "NOTAS DE LA MEMORIA; VIII. (Dividendo a cuenta)"},
            {"116",     "VIII. (Dividendo a cuenta)"},
            {"117",     "EJERCICIO ANTERIOR; VIII. (Dividendo a cuenta)"},
            {"118",     "NOTAS DE LA MEMORIA; IX. Otros instrumentos de patrimonio neto"},
            {"119",     "IX. Otros instrumentos de patrimonio neto"},
            {"120",     "EJERCICIO ANTERIOR; IX. Otros instrumentos de patrimonio neto"},
            {"121",     "NOTAS DE LA MEMORIA; A-2) Ajustes por cambios de valor"},
            {"122",     "A-2) Ajustes por cambios de valor"},
            {"123",     "EJERCICIO ANTERIOR; A-2) Ajustes por cambios de valor"},
            {"124",     "NOTAS DE LA MEMORIA; A-3) Subvenciones, donaciones y legados recibidos"},
            {"125",     "A-3) Subvenciones, donaciones y legados recibidos"},
            {"126",     "EJERCICIO ANTERIOR; A-3) Subvenciones, donaciones y legados recibidos"},
            {"127",     "NOTAS DE LA MEMORIA; B) PASIVO NO CORRIENTE"},
            {"128",     "B) PASIVO NO CORRIENTE"},
            {"129",     "EJERCICIO ANTERIOR; B) PASIVO NO CORRIENTE"},
            {"130",     "NOTAS DE LA MEMORIA; I. Provisiones a largo plazo"},
            {"131",     "I. Provisiones a largo plazo"},
            {"132",     "EJERCICIO ANTERIOR; I. Provisiones a largo plazo"},
            {"133",     "NOTAS DE LA MEMORIA; II. Deudas a largo plazo"},
            {"134",     "II. Deudas a largo plazo"},
            {"135",     "EJERCICIO ANTERIOR; II. Deudas a largo plazo"},
            {"136",     "NOTAS DE LA MEMORIA; 1. Deudas con entidades de crédito"},
            {"137",     "1. Deudas con entidades de crédito"},
            {"138",     "EJERCICIO ANTERIOR; 1. Deudas con entidades de crédito"},
            {"139",     "NOTAS DE LA MEMORIA; 2. Acreedores por arrendamiento financiero"},
            {"140",     "2. Acreedores por arrendamiento financiero"},
            {"141",     "EJERCICIO ANTERIOR; 2. Acreedores por arrendamiento financiero"},
            {"142",     "NOTAS DE LA MEMORIA; 3. Otras deudas a largo plazo"},
            {"143",     "3. Otras deudas a largo plazo"},
            {"144",     "EJERCICIO ANTERIOR; 3. Otras deudas a largo plazo"},
            {"145",     "NOTAS DE LA MEMORIA; III. Deudas con empresas del grupo y asociadas a largo plazo"},
            {"146",     "III. Deudas con empresas del grupo y asociadas a largo plazo"},
            {"147",     "EJERCICIO ANTERIOR; III. Deudas con empresas del grupo y asociadas a largo plazo"},
            {"148",     "NOTAS DE LA MEMORIA; IV. Pasivos por impuesto diferido"},
            {"149",     "IV. Pasivos por impuesto diferido"},
            {"150",     "EJERCICIO ANTERIOR; IV. Pasivos por impuesto diferido"},
            {"151",     "NOTAS DE LA MEMORIA; V. Periodificaciones a largo plazo"},
            {"152",     "V. Periodificaciones a largo plazo"},
            {"153",     "EJERCICIO ANTERIOR; V. Periodificaciones a largo plazo"},
            {"154",     "NOTAS DE LA MEMORIA; VI. Acreedores comerciales no corrientes"},
            {"155",     "VI. Acreedores comerciales no corrientes"},
            {"156",     "EJERCICIO ANTERIOR; VI. Acreedores comerciales no corrientes"},
            {"157",     "NOTAS DE LA MEMORIA; VII. Deuda con características especiales a largo plazo"},
            {"158",     "VII. Deuda con características especiales a largo plazo"},
            {"159",     "EJERCICIO ANTERIOR; VII. Deuda con características especiales a largo plazo"},
            {"160",     "Ejercicio en curso - BA2.2"},
            {"161",     "Ejercicio anterior - BA2.2"},
            {"162",     "NOTAS DE LA MEMORIA; C) PASIVO CORRIENTE"},
            {"163",     "C) PASIVO CORRIENTE"},
            {"164",     "EJERCICIO ANTERIOR; C) PASIVO CORRIENTE"},
            {"165",     "NOTAS DE LA MEMORIA; I. Pasivos vinculados con activos no corrientes mantenidos para la venta"},
            {"166",     "I. Pasivos vinculados con activos no corrientes mantenidos para la venta"},
            {"167",     "EJERCICIO ANTERIOR; I. Pasivos vinculados con activos no corrientes mantenidos para la venta"},
            {"168",     "NOTAS DE LA MEMORIA; II. Provisiones a corto plazo"},
            {"169",     "II. Provisiones a corto plazo"},
            {"170",     "EJERCICIO ANTERIOR; II. Provisiones a corto plazo"},
            {"171",     "NOTAS DE LA MEMORIA; III. Deudas a corto plazo"},
            {"172",     "III. Deudas a corto plazo"},
            {"173",     "EJERCICIO ANTERIOR; III. Deudas a corto plazo"},
            {"174",     "NOTAS DE LA MEMORIA; 1. Deudas con entidades de crédito"},
            {"175",     "1. Deudas con entidades de crédito"},
            {"176",     "EJERCICIO ANTERIOR; 1. Deudas con entidades de crédito"},
            {"177",     "NOTAS DE LA MEMORIA; 2. Acreedores por arrendamiento financiero"},
            {"178",     "2. Acreedores por arrendamiento financiero"},
            {"179",     "EJERCICIO ANTERIOR; 2. Acreedores por arrendamiento financiero"},
            {"180",     "NOTAS DE LA MEMORIA; 3. Otras deudas a corto plazo"},
            {"181",     "3. Otras deudas a corto plazo"},
            {"182",     "EJERCICIO ANTERIOR; 3. Otras deudas a corto plazo"},
            {"183",     "NOTAS DE LA MEMORIA; IV. Deudas con empresas del grupo y asociadas a corto plazo"},
            {"184",     "IV. Deudas con empresas del grupo y asociadas a corto plazo"},
            {"185",     "EJERCICIO ANTERIOR; IV. Deudas con empresas del grupo y asociadas a corto plazo"},
            {"186",     "NOTAS DE LA MEMORIA; V. Acreedores comerciales y otras cuentas a pagar"},
            {"187",     "V. Acreedores comerciales y otras cuentas a pagar"},
            {"188",     "EJERCICIO ANTERIOR; V. Acreedores comerciales y otras cuentas a pagar"},
            {"189",     "NOTAS DE LA MEMORIA; 1. Proveedores"},
            {"190",     "1. Proveedores"},
            {"191",     "EJERCICIO ANTERIOR; 1. Proveedores"},
            {"192",     "NOTAS DE LA MEMORIA; a) Proveedores a largo plazo"},
            {"193",     "a) Proveedores a largo plazo"},
            {"194",     "EJERCICIO ANTERIOR; a) Proveedores a largo plazo"},
            {"195",     "NOTAS DE LA MEMORIA; b) Proveedores a corto plazo"},
            {"196",     "b) Proveedores a corto plazo"},
            {"197",     "EJERCICIO ANTERIOR; b) Proveedores a corto plazo"},
            {"198",     "NOTAS DE LA MEMORIA; 2. Otros acreedores"},
            {"199",     "2. Otros acreedores"},
            {"200",     "EJERCICIO ANTERIOR; 2. Otros acreedores"},
            {"201",     "NOTAS DE LA MEMORIA; VI. Periodificaciones a corto plazo"},
            {"202",     "VI. Periodificaciones a corto plazo"},
            {"203",     "EJERCICIO ANTERIOR; VI. Periodificaciones a corto plazo"},
            {"204",     "NOTAS DE LA MEMORIA; VII. Deuda con características especiales a corto"},
            {"205",     "VII. Deuda con características especiales a corto"},
            {"206",     "EJERCICIO ANTERIOR; VII. Deuda con características especiales a corto"},
            {"207",     "NOTAS DE LA MEMORIA; TOTAL PATRIMONIO NETO Y PASIVO (A + B + C)"},
            {"208",     "TOTAL PATRIMONIO NETO Y PASIVO (A + B + C)"},
            {"209",     "EJERCICIO ANTERIOR; TOTAL PATRIMONIO NETO Y PASIVO (A + B + C)"},
        };

        #endregion
    }
}

using System;

namespace IndustriaAgroalimentaria
{
    class Program
    {
        static void Main(string[] args)
        {
            
                /*Integrantes:

                    ----- ITIC92 ------
                - Cordero Diaz Jose Alejandro
                - Gutierrez Torres Andrea Lilian
                - Vazquez Tuz Itzel Donaji

                 */

                //Objeto Producto Fresco
                Fresh productFresh = new Fresh();
                productFresh.typeProduct = "Producto Fresco";
                productFresh.expDate = "20/01/2010";
                productFresh.lotNum = 2;
                productFresh.packDate = "19/01/2009";
                productFresh.countOrigin = "México";

                productFresh.productFresh();

                ////Objeto Producto Refrigerado
                Refrigerated productRefrigerated = new Refrigerated();
                productRefrigerated.typeProduct = "Producto Refrigerado";
                productRefrigerated.expDate = "21/10/2021";
                productRefrigerated.lotNum = 25;
                productRefrigerated.packDate = "19/01/2020";
                productRefrigerated.countOrigin = "España";
                productRefrigerated.temp = 2.0;
                productRefrigerated.orgCode = 222;

                productRefrigerated.productRefrigerated();

                ////Objeto Producto Congelado
                Frozen productFrozen = new Frozen();
                productFrozen.typeProduct = "Producto Congelado";
                productFrozen.expDate = "20/09/2024";
                productFrozen.lotNum = 32;
                productFrozen.packDate = "05/03/2019";
                productFrozen.countOrigin = "China";
                productFrozen.temp = -3.0;

                productFrozen.productFrozen();


                //Objeto Producto Congelado por Agua
                FWater productFwater = new FWater();
                productFwater.typeProduct = "Producto Congelado";
                productFwater.expDate = "19/04/2023";
                productFwater.lotNum = 32;
                productFwater.packDate = "26/04/2029";
                productFwater.countOrigin = "Portugal";
                productFwater.temp = -15.0;

                productFwater.salinity = 5.2;

                productFwater.productFWater();


                //Objeto Producto Congelado por Nitrogeno
                FNitrogen productFNitrogen = new FNitrogen();
                productFNitrogen.typeProduct = "Producto congelado";
                productFNitrogen.expDate = "20/01/2010";
                productFNitrogen.lotNum = 2;
                productFNitrogen.packDate = "19/01/2009";
                productFNitrogen.countOrigin = "Canada";
                productFNitrogen.temp = -150.20;

                productFNitrogen.methodUsed = " Inmersion con Nitrogeno Liquido";
                productFNitrogen.expoTime = 10;

                productFNitrogen.productFNitrogen();


                //Objeto Producto Congelado por Aire
                FAir productFAir = new FAir();
                productFAir.typeProduct = "Producto Refrigerado";
                productFAir.expDate = "21/10/2021";
                productFAir.lotNum = 25;
                productFAir.packDate = "19/01/2020";
                productFAir.countOrigin = "Malasia";
                productFAir.temp = -10.8;

                productFAir.perNitro = 2.5;
                productFAir.perVapor = 5.9;
                productFAir.perOxigen = 43.4;
                productFAir.perCO2 = 1.2;

                productFAir.productFAir();


            }
        }

        class Products
        {
            public string expDate { get; set; }
            public int lotNum { get; set; }
            public string packDate { get; set; }
            public string countOrigin { get; set; }
            public string typeProduct { get; set; }

        }

        class Fresh : Products
        {
            public void productFresh()
            {
                Console.WriteLine(
                                   "Tipo de producto: " + typeProduct + "\n" +
                                   "La fecha de expiracion es: " + expDate + "\n" +
                                   "Numero de lote: " + lotNum + "\n" +
                                   "Fecha de empaquetado: " + packDate + "\n" +
                                   "Pais de origen: " + countOrigin + "\n"
                                   );
            }

        }

        class Frozen : Products
        {


            public double temp { get; set; }
            public void productFrozen()
            {
                Console.WriteLine(
                                   "Tipo de producto: " + typeProduct + "\n" +
                                   "La fecha de expiracion es: " + expDate + "\n" +
                                   "Numero de lote: " + lotNum + "\n" +
                                   "Fecha de empaquetado: " + packDate + "\n" +
                                   "Pais de origen: " + countOrigin + "\n" +
                                   "Temperatura: " + temp + "° \n"
                                   );

            }

        }
        class FWater : Frozen
        {
            public double salinity { get; set; }

            public void productFWater()
            {
                Console.WriteLine(
                                   "Tipo de producto: " + typeProduct + "\n" +
                                   "Tipo de congelacion: Agua \n" +
                                   "La fecha de expiracion es: " + expDate + "\n" +
                                   "Numero de lote: " + lotNum + "\n" +
                                   "Fecha de empaquetado: " + packDate + "\n" +
                                   "Pais de origen: " + countOrigin + "\n" +
                                   "Temperatura: " + temp + "° \n" +

                                   "Salinidad del agua: " + salinity + " g/L \n"
                                   );
            }

        }

        class FNitrogen : Frozen
        {
            public string methodUsed { get; set; }

            public double expoTime { get; set; }

            public void productFNitrogen()
            {
                Console.WriteLine(
                                   "Tipo de producto: " + typeProduct + "\n" +
                                   "Tipo de congelacion: Nitrogeno \n" +
                                   "La fecha de expiracion es: " + expDate + "\n" +
                                   "Numero de lote: " + lotNum + "\n" +
                                   "Fecha de empaquetado: " + packDate + "\n" +
                                   "Pais de origen: " + countOrigin + "\n" +
                                   "Temperatura: " + temp + "° \n" +

                                   "Metodo de congelacion: " + methodUsed + "\n" +
                                   "Tiempo de exposicion al nitrogeno: " + expoTime + " s \n"
                                   );
            }
        }

        class FAir : Frozen
        {
            public double perNitro { get; set; }
            public double perVapor { get; set; }
            public double perOxigen { get; set; }
            public double perCO2 { get; set; }

            public void productFAir()
            {
                Console.WriteLine(
                                   "Tipo de producto: " + typeProduct + "\n" +
                                   "Tipo de congelacion: Hidrogeno \n" +
                                   "La fecha de expiracion es: " + expDate + "\n" +
                                   "Numero de lote: " + lotNum + "\n" +
                                   "Fecha de empaquetado: " + packDate + "\n" +
                                   "Pais de origen: " + countOrigin + "\n" +
                                   "Temperatura: " + temp + "° \n" +

                                   "Composicion del aire \n" +
                                   "Nitrogeno: " + perNitro + "% \n" +
                                   "Vapor: " + perVapor + "% \n" +
                                   "Oxigeno: " + perOxigen + "% \n" +
                                   "CO2: " + perCO2 + "% \n"
                                   );
            }
        }
        class Refrigerated : Products
        {
            public double temp { get; set; }
            public int orgCode { get; set; }

            public void productRefrigerated()
            {
                Console.WriteLine(
                                   "Tipo de producto: " + typeProduct + "\n" +
                                   "La fecha de expiracion es: " + expDate + "\n" +
                                   "Numero de lote: " + lotNum + "\n" +
                                   "Fecha de empaquetado: " + packDate + "\n" +
                                   "Pais de origen: " + countOrigin + "\n" +
                                   "Temperatura: " + temp + "° \n" +
                                    "Codigo de organismo: " + orgCode + "\n"
                                   );

            }

        }


    }

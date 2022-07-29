using System;

namespace Preguntas_ramdon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Categoria_1 = new string[20];
            string[] Categoria_2 = new string[20];
            string[] Categoria_3 = new string[20];
            string[] Categoria_4 = new string[20];
            string[] Categoria_5 = new string[20];
            string[] Jugadores = new string[10];
            Random Changer = new Random();
            int Num = 0;
            int Puntuacion = 0;
            int Intento = 1;

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //CATEGOTIA 1

            Categoria_1[0] = "¿Cuál es la representación gráfica del número nueve mil treinta y seis?";                        //9036
            Categoria_1[1] = "¿A cuántas unidades equivale 10 decenas de millar?";                                             //100000
            Categoria_1[2] = "¿Escribe el número ordinal trigésimo quinto en cifras?";                                         //35
            Categoria_1[3] = "¿Qué cantidad expresa el número romano V?";                                                      //5
            Categoria_1[4] = "¿Qué número resulta si divides 56 entre 7?";                                                     //8
            Categoria_1[5] = "¿Cómo escribirías en cifras seiscientos veinticinco mil doscientos dos?";                        //625202
            Categoria_1[6] = "¿Si en una carrera vas tres puestos por detrás del vigésimo segundo, ¿en qué puesto vas? ?";     //Decimonoveno
            Categoria_1[7] = "¿Verdadero o falso? Una división entera es aquella en la que el resto es cero";                  //Falso
            Categoria_1[8] = "¿Un perro pesa 20 kilos y un cachorro pesa 10 kilos menos que él, ¿cuánto pesa la cría?";        //10 kilos
            Categoria_1[9] = "¿Cómo se llama el polígono de siete lados?";                                                     //heptágono
            Categoria_1[10] = "¿Cuál es el resultado de multiplicar 7x9?";                                                     //63
            Categoria_1[11] = "¿Cuántos minutos tiene una hora?";                                                              //60
            Categoria_1[12] = "¿Cuánto es un lustro?";                                                                         //5 años
            Categoria_1[13] = "¿Qué número es mayor 37,4 o 37,09?";                                                            //37,4
            Categoria_1[14] = "¿Cuál es el nombre del triángulo que tiene dos lados iguales y uno desigual?";                  //isósceles
            Categoria_1[15] = "¿Qué hora es si, tanto la manilla pequeña del reloj como la grande están en las 3?";            //15:15
            Categoria_1[16] = "¿Cuál es el número anterior a 1,000?";                                                          //999
            Categoria_1[17] = "¿Cuál es el 7mo número anterior a 24,552,649?";                                                 //24,552,642 
            Categoria_1[18] = "¿Cual es la decena aproximada del numero 58?";                                                  //60
            Categoria_1[19] = "¿Cuantos es un kilometro en metro?";                                                            //1000

            string[] respuesta_1 = new string[] {"9036", "100000", "35", "5", "8", "625202", "decimonoveno", "falso", "10 kilos", "heptagono", "63", "60", "5 años",
            "37,4", "isosceles", "15:15", "999", "24552642", "60", "1000"};

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //CATEGOTIA 2

            Categoria_2[0] = "¿En qué año fue la independencia de los estados unidos?";                        //1776                                                                           
            Categoria_2[1] = "¿En qué país está ubicado la torre Eiffel?";                                     //Francia
            Categoria_2[2] = "¿Quién fue el primer presidente de los Estados Unidos?";                         //George Washington
            Categoria_2[3] = "¿Cuál es el continente más grande?";                                             //Asiático
            Categoria_2[4] = "¿Cómo se llama la capital de Republica Dominicana?";                             //Santo Dominingo
            Categoria_2[5] = "¿En que año Cristóbal Colon descubre América ?";                                 //1492
            Categoria_2[6] = "¿Cuál es lugar mas alto de la republica dominicana ?";                           //El pico duarte
            Categoria_2[7] = "¿Cuánta provincia tiene la republica dominicana?";                               //32
            Categoria_2[8] = "¿Cuál es el país mas grande del mundo ?";                                        //Rusia
            Categoria_2[9] = "¿Cuál es el país mas poblado del mundo?";                                        //China
            Categoria_2[10] = "¿Quien es el mejor tirador en la historia de la NBA?";                          //Stephen Curry          
            Categoria_2[11] = "¿en que años fue la primera guerra mundial ?";                                  //1914     
            Categoria_2[12] = "¿Quién es el presidente Rusia ?";                                               //Bladimir Putin
            Categoria_2[13] = "¿Cuál es el océano mas grande?";                                                //Pacifico    
            Categoria_2[14] = "¿Cuál es la  segunda provincia más grande republica dominicana?";               //Santiago  
            Categoria_2[15] = "¿Quién pinto el cuadro la Monalisa ?";                                          //Leonardo Davinci
            Categoria_2[16] = "¿Quien es el mejor profesor de progamacion en Itla?";                           //Orison Soto
            Categoria_2[17] = "¿Cual es la mejor consola de video juegos hoy en dia?";                         //Play Station 5
            Categoria_2[18] = "¿El alfa regalo el 50% de las taquillas de su consierto?";                      //No
            Categoria_2[19] = "¿Quien ganaria en una pelea Iron man o Capitan america?";                       //Iron man

            string[] respuesta_2 = new string[] { "1776", "francia", "george washington", "asiatico", "santo domingo", "1492", "el pico duarte", "32", "rusia",
            "china", "stephen curry", "1914", "bladimir putin", "pacifico", "santiago", "leonardo davinci", "orison soto", "play station 5", "no", "iron man"};

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //CATEGOTIA 3

            Categoria_3[0] = "¿Que puerto se usa para conectarse al puerto 22?";                                                                                     //ssh
            Categoria_3[1] = "¿En que año microsoft corp. livera la version 5 de su internet explore?";                                                              //1999
            Categoria_3[2] = "¿En que año nace la primera compaq portatil o latop?";                                                                                 //1983
            Categoria_3[3] = "¿Cual es la herramienta informatica mas utilizadas en la empresas?";                                                                   //Office 
            Categoria_3[4] = "¿Cual es el navegar mas utilizado?";                                                                                                   //Google Chrome
            Categoria_3[5] = "¿El sistema de numeración que sólo utiliza dos dígitos, 0 y 1, se llama el sistema de número?";                                        //Binario
            Categoria_3[6] = "¿Es un programa utilizado para crear documentos tales como cartas, ensayos, y currículums?";                                           //Word
            Categoria_3[7] = "Cual es el comando para verificar la ip en cmd de windows?";                                                                           //Ipconfig 
            Categoria_3[8] = "¿Son programas que se introducen en nuestra computadora de forma muy diversa con el objetivo de aserle daño a nuestra información ?";  //Virus
            Categoria_3[9] = "¿Es una serie de información vinculada y de referencia cruzada disponible para el agseso publico?";                                    //Red LAN
            Categoria_3[10] = "¿Cual es el sistema operativo mas utilizado del mundo en pc?";                                                                        //Windows
            Categoria_3[11] = "¿Cual es el fenómeno que domina en la actualidad el servicuo de internet?";                                                           //Web. 2.0
            Categoria_3[12] = "¿En que año la IBM introduce el trecientos cienco RAMAC que almacenava datos en un disco duro?";                                      //1956
            Categoria_3[13] = "¿En programación que variable se usa para imprimir una palabra o mensaje en C# ?";                                                    //Console.whireline
            Categoria_3[14] = "¿Cual es el protocolo para navegar seguro?";                                                                                          //HTTPS
            Categoria_3[15] = "¿Se refiere a la parte física de la computadora: teclado, monitores, etc.?";                                                          //Hardare 
            Categoria_3[16] = "¿Almacena datos y programas temporalmente.?";                                                                                         //Memoria RAM
            Categoria_3[17] = "¿El Disco Duro, la Unidad de CD o DVD son dispositivos de:?";                                                                         //Almacenamiento 
            Categoria_3[18] = "¿Quien invento windows?";                                                                                                             //Microsoft
            Categoria_3[19] = "¿En programacion cual es la primera palabra que sale impresa antes de programar?";                                                    //Hola mundo

            string[] respuesta_3 = new string[] { "ssh", "1999", "1983", "office", "geogle chrome", "binario", "word", "ipconfig", "virus", "red lan", "windows",
            "web 2.0", "1956", "console.writeline", "https", "hardware", "memoria ram", "almacenamiento", "microsoft", "hola mundo"};

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //CATEGOTIA 4

            Categoria_4[0] = "¿Cual es la pelicula mas famosa de dinosaurios?";                                                                        //Jurassic World  
            Categoria_4[1] = "¿Cual es la pelicula donde un anillo gobierna el que posee?";                                                            //El Señor de los Anillos  
            Categoria_4[2] = "¿Como se llama la pelicula que sale un niño famoso con una cicatriz en la frente?";                                      //Harry Potter 
            Categoria_4[3] = "¿Cual es la pelicula que mas Oscars ha ganado en la historia?";                                                          //Titanic 
            Categoria_4[4] = "¿Cuantas veces Arnold Schwarzenegger ha interpretado al Terminator T800?";                                               //6
            Categoria_4[5] = "¿En que pelicula de la Saga de Star Wars la princesa Leia empieza a usar la fuerza?";                                    //Episodio VI
            Categoria_4[6] = "¿En que pelicula protagonizada por Robert De Niro en 1976 tiene una escena muy famosa en la que dice Me hablas a mi?";   //Taxi driver
            Categoria_4[7] = "¿Cual fue el primer filme de corea del sur en ganar un Oscar a la mejor pelicula?";                                      //Parasitos del 2020
            Categoria_4[8] = "¿Con que pelicula gana Steven Spielberg su primer Oscar al mejor director?";                                             //La lista de Schindler  
            Categoria_4[9] = "¿Cual era la primera regla en el Club de la Lucha de Brad Pitt y Edward Norton?";                                        //Nunca hablar del Club de la Lucha. 
            Categoria_4[10] = "¿Cual es el nombre del hobbit interpretado por Elijah Wood en las peliculas de El señor de los anillos?";               //Frodo Bolson. 
            Categoria_4[11] = "¿Quien es la unica princesa de Disney que se inspira en una persona real?";                                             //Pocahontas
            Categoria_4[12] = "¿Cual es el nombre del barco de Jack Sparrow?";                                                                         //El perla negra 
            Categoria_4[13] = "¿Cual es el verdadero nombre de Darth Vader?";                                                                          //Anakin Skywalker. 
            Categoria_4[14] = "¿A que escuela fue Harry Potter?";                                                                                      //Colegio de Hogwarts 
            Categoria_4[15] = "¿En que isla se encuentra Jurassic Park?";                                                                              //isla numblar 
            Categoria_4[16] = "¿Que libro de Stephen King fue llevado al cine y protagonizado por Jack Nicholson?";                                    //El resplandor. 
            Categoria_4[17] = "¿Cual es el actor mejor pagado de hollywood?";                                                                          //Daniel Craig  
            Categoria_4[18] = "¿Cuantas peliculas tiene la saga de harry potter?";                                                                     //8
            Categoria_4[19] = "¿Cual es la pelicula mas taquillera del mundo actualmente?";                                                            //Avatar

            string[] respuesta_4 = new string[] { "jurassic world", "el señor de los anillos", "harry potter", "titanic", "6", "episodio vi", "taxi driver",
            "parasitos del 2020", "la lista de schindler", "nunca hablar del club de la lucha", "frodo bolson", "el perla negra", "anikin skywalker",
            "colegio de hogwarts", "isla numblar", "el resplandor", "daniel craig", "8", "avatar"};

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Categoria 5

            Categoria_5[0] = "¿Quien fue el primer presidente de la Republica Dominicana?";                                                             //Pedro Santana
            Categoria_5[1] = "¿Fecha de la Primera Guerra Mundial";                                                                                     //1914
            Categoria_5[2] = "¿Que presidente goberno en RD en 1996-2000?";                                                                             //Leonel Fernandez
            Categoria_5[3] = "¿La politica es la toma de decisiones en grupo para fines ya sea de distribucion de recursos o estatus?";                 //Si
            Categoria_5[4] = "¿La union Europea es una comunidad politica|organizacion internacional en la que pertenece paises de Europa y Latam?";    //No
            Categoria_5[5] = "¿La ONU se creo con el objetivo de no monopolizar el mercado tecnologico internacional a comienzo del siglo 21?";         //No
            Categoria_5[6] = "¿Danilo Medina es un ladron?";                                                                                            //Si
            Categoria_5[7] = "¿El PLD es: Partido Lucrativo Dominicano?";                                                                               //No
            Categoria_5[8] = "¿La independencia efimera termino con la ocupacion haitiana?";                                                            //Si
            Categoria_5[9] = "¿Juan Bosch fundo el PLD?";                                                                                               //Si
            Categoria_5[10] = "¿Gonzalo Castillo sera el proximo excelentisimo presidente de la Republica Dominicana";                                  //No
            Categoria_5[11] = "¿Hipolito Mejia mejoro el futuro de su gobierno?";                                                                       //No
            Categoria_5[12] = "¿Trujillo era el jefe y lo matan?";                                                                                      //Si
            Categoria_5[13] = "¿El partido Democrata se fundo en el siglo 17?";                                                                         //No
            Categoria_5[14] = "¿Rusia y Ucrania tuvieron en estos ultimos años conflictos?";                                                            //Si
            Categoria_5[15] = "¿El Presidente de la Republica Dominicana vive en el Palacio Nacional?";                                                 //No
            Categoria_5[16] = "¿El conflicto entre el PLD y el PRD atraso la reforma?";                                                                 //Si
            Categoria_5[17] = "¿Luis Abinader encontro el pais en crisis?";                                                                             //Si
            Categoria_5[18] = "¿Presidente que estafo a tabaqueros en Santiago";                                                                        //Buenaventura Baez
            Categoria_5[19] = "¿Presidente de la Republica Dominicana en el 1 de septiembre de 1882?";                                                  //Heureaux

            string[] respuesta_5 = new string[] { "pedro santana", "1914", "leonel fernandez", "si", "no", "no", "si", "no", "si", "si", "no", "no",
            "si", "no", "si", "no", "si", "si", "buenaventura baez", "heureaux"};

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////

            void forrunning(string[] Categoria_1, string[] respuesta, int R)
            {
                for (int I = 0; I <= 1; I++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("                              ¡");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("Estas en la categoria que seleccionaste");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("");
                    Console.WriteLine("Intenta ganar, si puedes.");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("Ingresa tu nombre: ");
                    string Nombre = Console.ReadLine()!;
                    string var;
                    do
                    {
                        int Random = Changer.Next(0, 19);
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("");
                        Console.Write("Intento numero" + "[" + Intento + "]" + " ");
                        Console.WriteLine(Categoria_1[Random]);

                        if (Categoria_1[Random] == Categoria_1[0])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();
                            var = respuesta[0];
                            switch (Letra)
                            {
                                case var value when value == respuesta[0]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[1])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[1]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[2])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[2]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[3])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[3]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[4])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[4]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[5])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[5]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[6])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[6]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[7])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[7]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[8])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[8]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[9])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[9]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[10])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[10]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[11])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[11]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[12])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[12]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[13])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[13]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[14])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[14]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[15])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[15]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[16])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[16]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[17])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[17]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[18])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[18]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }
                        else if (Categoria_1[Random] == Categoria_1[19])
                        {
                            Console.Write("Responde:");
                            string Letra = Convert.ToString(Console.ReadLine())!;
                            Letra.ToLower();

                            switch (Letra)
                            {
                                case var value when value == respuesta[19]: Puntuacion++; Console.ForegroundColor = ConsoleColor.Green; Console.Write("correcto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                                default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("incorrecto, "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("tu puntuacion actual es de"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(" [" + Puntuacion + "]"); Console.ForegroundColor = ConsoleColor.DarkGray; break;
                            }
                        }

                        if (Intento == 5)
                        {
                            Intento = 1; Num = 0; break;
                        }

                        Num++;
                        Intento++;
                    } while (Num <= 19);


                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("La puntuacion total de (");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(Nombre);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(") fue de ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" [" + Puntuacion + "]");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Puntuacion = 0;

                    for (int T = 0; T <= 1; T++)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("                                   [1] Hacer otro intento");
                        Console.WriteLine("                                   [2] Cambiar de categoria");
                        Console.WriteLine("                                   [3] terminar el juego");
                        Console.Write("                                        ¿Que deseas?: ");
                        int Cambio = Convert.ToInt32(Console.ReadLine());

                        switch (Cambio)
                        {
                            case 1: Console.Clear(); T = 1; I--; break;
                            case 2: Console.Clear(); T = 1; I = 1; R--; break;
                            case 3: T = 1; I = 1; R = 1; Console.Clear(); Console.WriteLine("                                      ¡Fin del juego!"); break;
                            default: Console.WriteLine("                                       Opcion invalida"); T--; break;
                        }
                    }
                }
            }


            for (int R = 0; R <= 1; R++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("");
                Console.WriteLine("                               Bienvenido al inicio del juego");
                Console.WriteLine("                 Seleciona una categoria de preguntas e intenta responderlas");
                Console.WriteLine("");
                Console.WriteLine("                                 Matematicas [1] - by Jorgelis Castillo");
                Console.WriteLine("                             Cultura general [2] - by Tony Mateo");
                Console.WriteLine("                                 Informatica [3] - by Daninson Minaya");
                Console.WriteLine("                                   Peliculas [4] - by Emil Nicolas Crespo");
                Console.WriteLine("                                    Politica [5] - by Andyson");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.Write("                                    Selecciona una categoria: ");
                int Categoria = Convert.ToInt32(Console.ReadLine());
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //CATEGOTIA 1
                if (Categoria == 1)
                {
                    forrunning(Categoria_1, respuesta_1, R);
                }


                /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //CATEGOTIA 2
                else if (Categoria == 2)
                {
                    forrunning(Categoria_2, respuesta_2, R);
                }


                /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //CATEGOTIA 3
                else if (Categoria == 3)
                {
                    forrunning(Categoria_3, respuesta_3, R);
                }


                /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //CATEGOTIA 4
                else if (Categoria == 4)
                {
                    forrunning(Categoria_4, respuesta_4, R);
                }


                /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //CATEGOTIA 5
                else if (Categoria == 5)
                {
                    forrunning(Categoria_5, respuesta_5, R);
                }
                else
                {
                    Console.WriteLine("                                          Opcion invalida"); R--;
                }

            }
            Console.ReadKey();
        }
    }
}

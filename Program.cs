// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");
//PUNTO1
/*        int num;
        string entrada;
        Console.WriteLine("ingrese su numero para invertilo");
        entrada = Console.ReadLine();
        bool chequeo = false;
        
        if(int.TryParse(entrada, out num)){
            chequeo = true;
            
        }else{
            
            while(chequeo == false){
                Console.WriteLine("error ingrese un numero");
                entrada = Console.ReadLine();
                if(int.TryParse(entrada, out num)){
                    chequeo = true;
                 }
            }
        }
       Invertir(num);
    
    static void Invertir(int num){
        string invertido ="";
        
        while(num!=0){
            int dig = num%10;
            invertido += dig.ToString();
            num = num/10;
        }
        Console.WriteLine("su numero invertido: " + invertido);
    }*/                
    //PUNTO2
   /* Calculadora();

    static void Calculadora(){
        int continuar=1;

        while (continuar == 1)
        {
             Console.WriteLine ("Ingrese el num operacion que quiere 1:suma 2:resta 3:multiplicacion 4:division");
            int operacion;
            operacion = int.Parse(Console.ReadLine());
            string aux1;
            double num1;

            while (true)
            {
                Console.WriteLine("ingrese un numero");
                aux1 = Console.ReadLine();
                if(double.TryParse(aux1, out num1)){//Intenta convertir a double
                    Console.WriteLine("numero valido");
                    break;//sale del bucle 
                }else
                {
                    Console.WriteLine("numero invalido");
                }
            }
        
            string aux2;
            double num2;
        
            while (true)
            {
                Console.WriteLine("ingrese otro numero");
                aux2 = Console.ReadLine();
                if(double.TryParse(aux2, out num2)){
                    Console.WriteLine("numero valido");
                    break;
                }else
                {
                    Console.WriteLine("numero invalido");
                }
            }
        
        
            switch(operacion){
             case 1:suma(num1,num2);
                break;
                case 2:resta(num1,num2);
                break;
                case 3:multiplica(num1,num2);
                break;
                case 4: dividir( num1, num2);
                break;
            }
            //PUNTO 3
            
            Console.WriteLine("ingrese la operacion 1:valAbs 2:cuadrado 3:raiz 4:seno 5:coseno  6:ver parte entera");
            operacion = int.Parse(Console.ReadLine());

            string aux;
            double num3;
             while (true)
            {
                Console.WriteLine("ingrese un numero");
                aux = Console.ReadLine();
                if(double.TryParse(aux, out num3)){
                    Console.WriteLine("numero valido");
                    break;
                }else
                {
                    Console.WriteLine("numero invalido");
                }
            }

            switch (operacion)
            {
                case 1:valorAbs(num3);
                break;
                case 2:cuadrado(num3);
                break;
                case 3:raizC(num3);
                break;
                case 4:seno(num3);
                break;
                case 5:coseno(num3);
                break;
                case 6: parteEntera(num3);
                break;

            }
            double num4,num5;
            while (true)
            {
                Console.WriteLine("ingrese un numero");
                aux = Console.ReadLine();
                if(double.TryParse(aux,out num4)){
                    Console.WriteLine("numero valido");
                    break;
                }else
                {
                    Console.WriteLine("numero invalido");
                }
            }
            while (true){
                Console.WriteLine("ingrese un numero");
                aux = Console.ReadLine();
                if(double.TryParse(aux,out num5)){
                    Console.WriteLine("numero valido");
                    break;
                }else
                {
                    Console.WriteLine("numero invalido");
                }
            }
            minYmax(num4,num5);
            

            Console.WriteLine("desea hacer seguir calculando 1:si 0:no");
            continuar = int.Parse(Console.ReadLine());    
        }
       
    }
    static void suma(double a,double b){
        double resul = a+b;
        Console.WriteLine("resultado:"+resul);
    }
    static void resta(double a,double b){
        double resul = a-b;
        Console.WriteLine("resultado:"+resul);
    }
    static void multiplica(double a,double b){
        double resul = a*b;
        Console.WriteLine("resultado:"+resul);
    } 
    static void dividir(double a,double b){
        if(b == 0){
            Console.WriteLine("error no se puede dividir por 0");
            return;
        }
        double resul = a/b;
        Console.WriteLine("resultado:"+resul);
    }

    static void valorAbs(double a){
        double resul = Math.Abs(a);
        Console.WriteLine("valor absoluto:"+resul);
    }
    static void cuadrado(double a){
        double resul = a*a;
        Console.WriteLine("al cuadrado:"+resul);
    }
    static void raizC(double a){
        double resul = Math.Sqrt(a);
        Console.WriteLine("raiz cuadrada:"+resul);
    }
    static void seno(double a){
        double radianes = a *(Math.PI /180);
        double resul = Math.Sin(radianes);
        Console.WriteLine("seno:"+resul);
    }
    static void coseno(double a){
        double rad = a*(Math.PI / 180);
        double resul = Math.Cos(rad);
        Console.WriteLine("coseno:"+resul);
    }
    static void parteEntera(double a){
        int resul = (int)a;//deja parte entera
        Console.WriteLine("Parte entera:"+resul);
    }
    static void minYmax(double a,double b){
        if (a>b)
        {
            Console.WriteLine("maximo:"+a+",minimo: "+b);
        }else
        {
            Console.WriteLine("maximo:"+b+",minimo: "+a);
        }
    }*/
    //Punto 4
    string cadena;
    Console.WriteLine("ingrese la primera cadena");
    cadena = Console.ReadLine();
    int tam;
    tam = cadena.Length;
    Console.WriteLine("el tamaño de la cadena es:" +tam+" caracteres");
    
    string cadena2;
    Console.WriteLine("ingrese otra cadena");
    cadena2 = Console.ReadLine();
    string concatenado = string.Concat(cadena,cadena2);
    Console.WriteLine("concatenadas: "+concatenado);

    string subcadena;
    subcadena = cadena.Substring(0,3);//toma desde 0 a 3 ,Substring(3)desde 3 en adelante
    Console.WriteLine("subcadena:" +subcadena);

    Console.WriteLine("foreach:");
    foreach (char a in cadena)
    {
        Console.WriteLine(a);
    }

    if (concatenado.Contains("hola"))
    {
        Console.WriteLine("la cadena tiene la palabra hola");
    }else
    {
        Console.WriteLine("la cadena no tiene la palabra hola");
    }

    string mayus = cadena.ToUpper();
    string minus = cadena.ToLower();
    Console.WriteLine("mayuscula: "+mayus+" miniscula: "+minus);

    Console.WriteLine("Split:");
    string texto="mango+pera+sandia";
    string []comida = texto.Split("+");
    foreach (string a in comida)
    {
        Console.WriteLine(a);
    }

    Console.WriteLine("ingrese num1+num2");
    string sumar= Console.ReadLine();
    string[] valores = sumar.Split("+");
    double total;
    total = double.Parse(valores[0]) + double.Parse(valores[1]);
    Console.WriteLine("resultado:"+total);
    
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int num;
        string entrada;
        Console.WriteLine("ingrese su numero");
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
    }

using System;
using static System.Console;

namespace Praxtica1{
    class program{  
        static void Main(){
       
                               
        string datos ;
        datos = ReadLine();

        WriteLine(isValid(datos)) ;
        
        
        }
            
        static public bool isValid(string datos){
            int Paren1 = 0, Cor1 = 0,llave1 = 0;
            Array caracteres = datos.ToArray();
            for(int i = 0; i< datos.Length;i ++){

            switch(caracteres.GetValue(i)){
                case '{' :
                llave1 += 1 ;
                                                   
                break;

                case '[' :
                Cor1 +=1;
                break;

                case '(' :
                Paren1 +=1;
                break;

                case '}' :
                llave1 -= 1 ;
                if(llave1 < 0)
                    {
                    return(false);
                    }
                break;

                case ')' :
                Paren1 -=1;
                if(Paren1 < 0)
                    {
                    return(false);
                    }
                break;

                case ']' :
                Cor1 -=1;
                if(Cor1 < 0)
                    {
                    return(false);
                    }
                break;
                }
            }
        
        if(llave1 == 0 && Paren1 == 0 && Cor1 == 0){

            return(true);
        }
        else{
            return(false);
        }

        }
        
        
    }
    
}


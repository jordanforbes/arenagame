using System; 

namespace csharp
{
    public class Arena
    {

        static string makeBorder(int length){
                string wall="#";
                for(int i = 0; i<length;i++){
                    wall +="#";
                }
                wall+="#";
                return wall;
            }   

            //the rows
            static string makeRow(int length){
                string wall="#";
                for(int i = 0; i<length; i++){
                    wall+="*";
                }
                wall+="#";
                return wall;
            }

            //makes row if character is on that y axis
            static string makePlayerRow(int length, int[] playerX){
                string wall="#";
                for(int i = 0; i<length; i++){
                    if(i==playerX[0]){
                        wall+="@";
                    }else{
                        wall+="*";
                    }
                }
                wall+="#";
                return wall;
            }


            //actual arena

            public static void drawArena(int rows, int cols){

                //top coordinates

                int[] placement={6,2}; //x,y

                Console.Write(" ");
                for(int j = 1; j<=cols;j++){
                    Console.Write(j);
                }
                Console.Write(" \n");
                Console.WriteLine(makeBorder(cols));

                for(int i = 0; i<rows; i++){
                    if(i == placement[1]){

                        Console.WriteLine(makePlayerRow(cols,placement)+(i+1)); //side
                    }else{
                        Console.WriteLine(makeRow(cols)+(i+1)); //side
                    };
                }
                Console.WriteLine(makeBorder(cols));
                
            }
        
    }
}
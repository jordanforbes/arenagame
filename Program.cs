using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //build modulating arena 
            //create arena 
            //print an ascii array
           
            //the border
            string makeBorder(int length){
                string wall="#";
                for(int i = 0; i<length;i++){
                    wall +="#";
                }
                wall+="#";
                return wall;
            }   

            //the rows
            string makeRow(int length){
                string wall="#";
                for(int i = 0; i<length; i++){
                    wall+="*";
                }
                wall+="#";
                return wall;
            }


            //actual arena

            void drawArena(int rows, int cols){

                int[] placement=[3,4]
                
                //top coordinates
                Console.Write(" ");
                for(int j = 1; j<=rows;j++){
                    Console.Write(j);
                }
                Console.Write(" \n");
                Console.WriteLine(makeBorder(rows));

                for(int i = 0; i<cols; i++){
                    Console.WriteLine(makeRow(rows)+(i+1)); //side
                }
                Console.WriteLine(makeBorder(rows));
                
            };

            drawArena(8,4);
        }
    }
}
